using MVCHIS.Common;
using System;
using System.Linq;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.Entity, Enabled = true)]
    public class EntityController : AbstractDBController<EntityModel> {

        public void InitializeDBValues() {

            foreach (var e in Read()) { Delete(e); }

            foreach (MODELS t in Enum.GetValues(typeof(MODELS))) {
                var e = (IEntity)DBEntitiesFactory.GetEntity(t);
                var model = new EntityModel() {
                    EntityName = t.ToString(),
                    EntityDesc = e.MetaData.Source
                };
                try {
                    Save(model);
                    Console.WriteLine("OK -> :::" + model);
                } catch (Exception ex) {
                    Console.WriteLine("ERROR:" + ex.Message + ":::" + model);
                }
            }
        }
    }
}
