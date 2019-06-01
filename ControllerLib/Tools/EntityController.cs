using MVCHIS.Common;
using System;
using System.Linq;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.Entity, Enabled = true)]
    public class EntityController : AbstractDBController {
        public EntityController() : base(DBEntitiesFactory.GetEntity(MODELS.Entity)) { }
        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
        public void InitializeDBValues() {

            foreach (var e in Read<EntityModel>()) { Delete(e); }

            foreach (MODELS t in Enum.GetValues(typeof(MODELS))) {
                var e = DBEntitiesFactory.GetEntity(t);
                var model = new EntityModel() {
                    EntityName = t.ToString(),
                    EntityDesc = e.MetaData.Source
                };
                try {
                    Save(model);
                    Console.WriteLine("OK -> :::" + model);
                } catch (Exception ex){
                    Console.WriteLine("ERROR:" + ex.Message + ":::" + model);
                }
            }
        }
    }
}
