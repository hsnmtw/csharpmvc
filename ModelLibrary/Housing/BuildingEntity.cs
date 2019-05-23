using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Housing {
    public class BuildingEntity : AbstractEntity,BaseEntity {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(BuildingModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = "Id,BuildingName,BuildingType,CompoundName".Split(',')
            , GetSource = "HousingBuilding"
            , GetUniqueKeyFields = new string[] { "BuildingName" }
        };
    }
}
