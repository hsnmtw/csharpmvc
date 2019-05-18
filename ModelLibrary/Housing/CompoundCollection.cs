using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Housing
{
    public class CompoundCollection : AbstractCollection {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(CompoundModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = "Id,Compound_Name".Split(',')
            , GetSource = "Housing_Compounds"
            , GetUniqueKeyFields = new string[] { "Compound_Name" }
            };
    }
}
