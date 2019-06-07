using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using MVCHIS.Utils;

namespace MVCHIS.Common {
    public abstract class AbstractDBController<M> : IDBController<M> where M:BaseModel{
        public virtual IDBEntity<M> BaseEntity { get; set; }
        public Action<int> OnSaveAction   { get; set; }
        public Action<int> OnDeleteAction { get; set; }

        public AbstractDBController() : base() {
            BaseEntity = DBEntitiesFactory.GetEntityOfModel<M>();
        }
        public virtual string Validate(M model) {
            return BaseEntity.Validate(model);
        }
        //public abstract void Initialize();

        public virtual DataTable GetDataById(IEnumerable<int> Ids) => BaseEntity.GetDataById(NewModel(), Ids);
        public virtual IEnumerable<M> FindById(IEnumerable<int> Ids) => BaseEntity.FindById(NewModel(), Ids);
        public virtual M Find(M model, params string[] whereFields) => BaseEntity.Find(model,whereFields);
        public virtual M NewModel() => BaseEntity.NewModel();
        public virtual int Delete(M model) {
            int result = BaseEntity.Delete(model);
            OnDeleteAction?.Invoke(result);
            return result;
        }
        public virtual IEnumerable<M> Read() => Read(NewModel());
        public virtual IEnumerable<M> Read(M model, params string[] whereFields) => BaseEntity.Select(model,"*", false, whereFields);
        public virtual IEnumerable<M> Read(M model, bool like = false, params string[] whereFields) => BaseEntity.Select(model,"*", like, whereFields);
        public virtual int Save(M model){
            var validation = Validate(model);
            if (!"[]".Equals(validation)) throw new Exception(validation);
            int result;
            if (model.Id == 0) {
                model.CreatedBy = (MVCHISSession.Instance.CurrentUser==null ? "SYSTEM" : MVCHISSession.Instance.CurrentUser.UserName);
                model.CreatedOn = (DateTime.Now);
                result = BaseEntity.Create(model);
            } else {
                model.UpdatedBy = (MVCHISSession.Instance.CurrentUser == null ? "SYSTEM" : MVCHISSession.Instance.CurrentUser.UserName);
                model.UpdatedOn = (DateTime.Now);
                result = BaseEntity.Update(model,"Id");
                //if (keyvals.ContainsKey(model.Id)) keyvals.Remove(model.Id);
            }
            OnSaveAction?.Invoke( result );
            //dtGetKeysAndValues = null;
            return result;
        }
        public MetaData GetMetaData() => BaseEntity.MetaData;

        public DataTable GetData() => BaseEntity.GetData(NewModel());

        public Type GetModelType() => typeof(M);
        private Dictionary<int, string> dtGetKeysAndValues =null;
        public Dictionary<int,string> GetKeysAndValues() {
            if (dtGetKeysAndValues != null) return dtGetKeysAndValues;
            var UK = new[] { "Id" }.Concat(GetMetaData().UniqueKeyFields.SelectMany(x => x)).Distinct();//.OrderBy(x => x);
            var FK = GetMetaData().ForeignKeys.Where(x => UK.Contains(x.Key));
            var MD = Select(NewModel(), string.Join(",", UK), false);
            dtGetKeysAndValues = new Dictionary<int, string>();

            OnSaveAction   += Clear_dtGetKeysAndValues;
            OnDeleteAction += Clear_dtGetKeysAndValues;

            foreach (var record in MD) {
                var objects = new object[2];
                int id = (int)typeof(M).GetProperty("Id").GetValue(record);
                List<string> sb = new List<string>();
                foreach (var u in UK.Where(x => "Id" != x)) {
                    object val = typeof(M).GetProperty(u).GetValue(record);
                    var f = FK.Where(x => x.Key == u);
                    if (f.Count()>0) {
                        var Cntrl = DBControllersFactory.GetController(f.FirstOrDefault().Value.Item1);
                        sb.Add(Cntrl.GetValues((int)val));
                        Cntrl.OnSaveAction   += Clear_dtGetKeysAndValues;
                        Cntrl.OnDeleteAction += Clear_dtGetKeysAndValues;
                    } else {
                        sb.Add(val.ToString());
                    }
                }
                dtGetKeysAndValues[id] = string.Join(" | ", sb);
            }
            return dtGetKeysAndValues;
        }

        private void Clear_dtGetKeysAndValues(int obj) {
            dtGetKeysAndValues = null;
        }

        public string GetValues(int id) {
            if (id == 0) return null;
            if (dtGetKeysAndValues == null || dtGetKeysAndValues.ContainsKey(id)==false) GetKeysAndValues();
            return dtGetKeysAndValues[id];
        }

        public IEnumerable<M> Select(M model, string fields = "*", bool like = false, params string[] whereFields) {
            return BaseEntity.Select(model, fields, like, whereFields);
        }
    }
}
