using MVCHIS.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Common {
    public abstract class AbstractInMemoryEntity<M> : DBEntity, IDBEntity<M> where M : BaseModel {

        public abstract List<M> Data { get; set; }

        public AbstractInMemoryEntity() {
            ValidateMetaData(typeof(M));
        }

        public override string GetDDL() => GetDDL(typeof(M));

        public M Find(M model, params string[] whereFields) {
            int index = GetIndexOfModel(model);
            if (index > -1) return Data[index];
            return null;
        }

        public IEnumerable<M> FindById(M model,IEnumerable<int> Ids) {
            var pis = typeof(M).GetProperties().Where(p => "Id".Equals(p.Name));
            List<M> result = new List<M>();
            foreach (M m in Data) {
                if ( pis.All(p => Ids.Contains((int)p.GetValue(m))) ) {
                    result.Add(m);
                }
            }
            return result;
        }

        
        public DataTable GetDataById(M model,IEnumerable<int> Ids) => FindById(model,Ids).ToDataTable();
        
        public M NewModel() => Activator.CreateInstance<M>();

        public IEnumerable<M> Select(M model,string fields = "*", bool like = false, params string[] whereFields) {
            var pis = typeof(M).GetProperties().Where(p => whereFields.Contains(p.Name));
            List<M> result = new List<M>();
            foreach (M m in Data) {
                if (like && pis.All(p => $"{p.GetValue(model)}".Contains( $"{p.GetValue(m)}"))) {
                    result.Add(m);
                }else if (pis.All(p => $"{p.GetValue(model)}".Equals($"{p.GetValue(m)}"))) {
                    result.Add(m);
                }
            }
            return result;
        }

        private int GetIndexOfModel(M model,params string[]whereFields) {
            if (Data.Count() == 0) return -1;
            var pis = typeof(M).GetProperties().Where(p => whereFields.Contains(p.Name));
            for (int i=0;i<Data.Count();i++) {
                if (pis.All(p => p.GetValue(model) == p.GetValue(Data[i]))) {
                    return i;
                }
            }
            return -1;
        }

        public int Create(M model) {
            if (model.Id == 0) {
                if (Data.Count() > 0) {
                    model.Id = Data.Select(x => x.Id).Max() + 1;
                } else {
                    model.Id = 1;
                }
            }
            Data.Add(model);
            return 1;
        }

        public int Update(M model,params string[]whereFields) {
            int index = GetIndexOfModel(model);
            if (index > -1) {
                Data[index] = model;
                return 1;
            }
            return 0;
        }

        public int Delete(M model,params string[]whereFields) {
            var m = Data.Where(x => x.Id == model.Id).FirstOrDefault();
            if (m == default) return 0;
            bool status = Data.Remove(m);
            return status ? 1 : 0;
        }

        public string Validate(M model) => "[]";

        public DataTable GetData(M model,string fields="*", bool like = false, params string[] whereFields) => Select(model,fields, like, whereFields).ToDataTable();

        public M Exists(M model) {
            int index = GetIndexOfModel(model);
            if (index < 0) return null;
            return Data[index];
        }
    }
}