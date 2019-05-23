using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Housing
{
    public class CompoundEntity : AbstractEntity {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(CompoundModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = "Id,CompoundName".Split(',')
            , GetSource = "HousingCompounds"
            , GetUniqueKeyFields = new string[] { "CompoundName" }
            };
    }
}
