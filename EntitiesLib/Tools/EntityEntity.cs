using System.Collections.Generic;

namespace MVCHIS.Common {
    [ForModel(MODELS.Entity)]
    public class EntityEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
              ModelType = typeof(EntityModel)
            , PrimaryKeyFields = new string[]{ "Id" }
            , RequiredFields = new string[] { "Id", "EntityName", "EntityDesc" }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"] = 50,
                ["UpdatedBy"] = 50,
                ["EntityName"] = 50,
                ["EntityDesc"] = 100
            }
            , Source = "CommonEntites"
            , UniqueKeyFields = new string[] { "EntityName" }
            };
    }
}
