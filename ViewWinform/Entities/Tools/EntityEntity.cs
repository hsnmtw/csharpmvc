using System.Collections.Generic;

namespace MVCWinform.Common {
    [ForEntity(Entities.Entity)]
    public class EntityEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
              GetModelType = typeof(EntityModel)
            , GetPrimaryKeyFields = new string[]{ "Id" }
            , GetRequiredFields = new string[] { "Id", "EntityName", "EntityDesc" }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"] = 50,
                ["UpdatedBy"] = 50,
                ["EntityName"] = 50,
                ["EntityDesc"] = 100
            }
            , GetSource = "CommonEntites"
            , GetUniqueKeyFields = new string[] { "EntityName" }
            };
    }
}
