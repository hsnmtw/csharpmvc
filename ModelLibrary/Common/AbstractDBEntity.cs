using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Common {
    public abstract class AbstractDBEntity : IDBEntity {

        private const string EQ = "=";
        private const string LIKE = "LIKE";

        protected DBConnectionManager database = DBConnectionManager.Instance;

        public abstract MetaData MetaData { get; }

        public virtual Statement GetDeleteStatement(object model) {
            return new Statement(MetaData.GetSource) {
                Sql = $"DELETE FROM [{MetaData.GetSource}] WHERE ([Id]=@Id) AND ([ReadOnly]=false)",
                Parameters = ParametersFactory.CreateParameters(model,new string[] { "Id" })
            };
        }

        public virtual Statement GetDeleteStatement(object model,params string[]whereFields) {
            string WHERE = string.Join(" AND ", (from field in whereFields select $"[{field}]=@{field}") );
            return new Statement(MetaData.GetSource) {
                Sql = $"DELETE FROM [{MetaData.GetSource}] WHERE ({WHERE}) AND ([ReadOnly]=false)",
                Parameters = ParametersFactory.CreateParameters(model, whereFields)
            };
        }

        public virtual Statement GetInsertStatement(object model) {

            string[] fieldswithoutid = (from field in MetaData.GetFields
                                          where !field.ToLower().Equals("id")
                                          select field).ToArray<string>();

            return new Statement(MetaData.GetSource) {
                Sql = string.Format("INSERT INTO [{0}] ([{1}]) VALUES (@{2})",
                    MetaData.GetSource,
                    string.Join("],[", fieldswithoutid),
                    string.Join(",@", fieldswithoutid)
                ),
                Parameters = ParametersFactory.CreateParameters(model,fieldswithoutid)
            };
        }

        public virtual Statement GetUpdateStatement(object model) {
            string[] fieldswithoutid = (from field in MetaData.GetFields
                                          where !(
                                                    field.ToLower().Equals("id") ||
                                                    field.ToLower().Equals("createdby") ||
                                                    field.ToLower().Equals("createdon")
                                                 )
                                          select field).ToArray<string>();


            return new Statement(MetaData.GetSource) {
                Sql = string.Format("UPDATE [{0}] SET {1} WHERE ([Id]=@Id) AND ([ReadOnly]=false)",
                    MetaData.GetSource,
                    string.Join(",", (from f in fieldswithoutid select string.Format("[{0}]=@{0}", f)).ToArray())
                ),
                Parameters = ParametersFactory.CreateParameters(model, fieldswithoutid.Concat(new string[] { "Id" }).ToArray())
            };
        }


        public virtual Statement GetUpdateStatement(object model,params string[]whereFields) {
            string[] fieldswithoutid = (from field in MetaData.GetFields
                                        where !(
                                                  field.ToLower().Equals("id") ||
                                                  field.ToLower().Equals("createdby") ||
                                                  field.ToLower().Equals("createdon")
                                               )
                                        select field).ToArray<string>();


            return new Statement(MetaData.GetSource) {
                Sql = string.Format("UPDATE [{0}] SET {1} WHERE ({2}) AND ([ReadOnly]=false)",
                    MetaData.GetSource,
                    string.Join(",", (from f in fieldswithoutid select string.Format("[{0}]=@{0}", f)).ToArray()),
                    string.Join(" AND ", (from field in whereFields select $"[{field}]=@{field}"))
                ),
                Parameters = ParametersFactory.CreateParameters(model, fieldswithoutid.Concat(whereFields).ToArray())
            };
        }


        public virtual Statement GetSelectStatement() {
            return new Statement(MetaData.GetSource) {
                Sql = string.Format($"SELECT * FROM [{MetaData.GetSource}] ORDER BY 1")
            };
        }

        public virtual Statement GetSelectStatement(object model, string[] whereFields,bool like=false) {
            string query = "";
            string OP = like ? LIKE : EQ;
            if (whereFields.Length == 0) {
                query = $"SELECT * FROM [{MetaData.GetSource}] ORDER BY 1";
            } else {
                query = string.Format("SELECT * FROM [{0}] WHERE ({1}) ORDER BY 1",
                                        MetaData.GetSource,
                                        string.Join(" AND ", (from string wf
                                                                in whereFields
                                                              select $"[{wf}] {OP} @{wf}"
                                                              )));
            }
            return new Statement(MetaData.GetSource) {
                Sql = query,
                Parameters = ParametersFactory.CreateParameters(model, whereFields)
            };
        }


        public List<object> Read() {
            return Read(CreateNew(), new string[] { });
        }

        public List<object> Read(object model, params string[] whereFields) {

            var dt = GetTable(model,whereFields);
            var result = new List<object>();
            foreach (DataRow row in dt.Rows) {
                var newModel = CreateNew();
                var props = (from prop in newModel.GetType().GetProperties() select prop.Name);
                for (int i = 0; i < dt.Columns.Count; i++) {
                    if (props.Contains(dt.Columns[i].ColumnName)) {
                        model.GetType().GetProperty(dt.Columns[i].ColumnName).SetValue(
                        newModel,
                        DBNull.Value.Equals(row[i]) ? null : row[i]
                    );}
                }
                result.Add(newModel);
            }
            //if (result.Count < 1) throw new Exception();
            return result;
        }

        public virtual ResultSet GetTable(object model, string[] whereFields, bool like, int page, int pagesize) {
            
            DataTable table = GetTable(model, whereFields, like);
            int rowcount = table.Rows.Count;
            
            int pages = (rowcount + pagesize - 1) / pagesize;
            int offset = pagesize * (page - 1);
            if (offset >= rowcount) return new ResultSet {
                RowsCount = rowcount,
                Pages = pages,
                PageSize = pagesize,
                Page = page,
                Table = table,
                Status = true,
                ResponseMessage = $"Data was retreived, but the offset [{offset}] is greater than row count [{table.Rows.Count}]"
            };
            if (pagesize < 1) pagesize = table.Rows.Count;
            if (offset + pagesize > table.Rows.Count) pagesize = table.Rows.Count - offset;
            

            table = table.AsEnumerable().Skip(offset).Take(pagesize).CopyToDataTable();
            return new ResultSet {
                RowsCount = rowcount,
                Pages = pages,
                Page = page,
                PageSize = pagesize,
                Table = table,
                Status = true,
                ResponseMessage = $"Data was retreived, offset [{offset}], length [{pagesize}], row count [{rowcount}]"
            };
        }
        public virtual DataTable GetTable(object model, string[] whereFields, bool like = false) {
            return database.Query(GetSelectStatement(model,whereFields,like));
        }
        public virtual DataTable GetTable() {
            return database.Query(GetSelectStatement());
        }

        public object CreateNew() {
            return Activator.CreateInstance(MetaData.GetModelType);
        }

        public virtual DBModificationResult Save(object model) {
            if (model == null) return new DBModificationResult() {
                Status = -1,
                Result = null
            };
            var properties = model.GetType().GetProperties().Where(x => x.PropertyType.Equals(typeof(string)));
            foreach (var property in properties) {
                var value = $"{property.GetValue(model)}".Trim();
                property.SetValue(model, value.Equals("")?null:value);
            }
            if (((BaseModel)model).Id == 0) {
                int affected = Create(model);
                return new DBModificationResult() {
                    Status = affected,
                    Result = this.Read(model, new string[] { "CreatedOn" }).First()
                };
            } else {
                int affected = Update(model);
                return new DBModificationResult() {
                    Status = affected,
                    Result = this.Read(model, new string[] { "Id" }).First()
                };
                //return this.Read(model, new string[] { "Id" }).First();
            }
        }

        private int Create(object model) {
            return database.Execute(GetInsertStatement(model)).RowsCount;
        }
        private int Update(object model) {
            return database.Execute(GetUpdateStatement(model)).RowsCount;
        }
        public virtual DBModificationResult Delete(object model) {
            return new DBModificationResult() {
                Status = database.Execute(GetDeleteStatement(model)).RowsCount
            };
        }

        public virtual DBModificationResult Delete(object model,string[]whereFields) {
            return new DBModificationResult() {
                Status = database.Execute(GetDeleteStatement(model,whereFields)).RowsCount
            };
        }
    }
}
