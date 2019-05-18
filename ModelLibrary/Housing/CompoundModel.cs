using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Housing
{
    public class CompoundModel : BaseModel
    {
        public String Compound_Name { get; set; }
        public override string[] GetFields() => new string[]{
            "Compound_Name",
            "Id","Created_By","Created_On","Updated_By","Updated_On" };
        public override string[] GetPrimaryKeyFields() => "Id".Split(',');
        public override string[] GetRequiredFields() => "Id,Compound_Name".Split(',');
        public override string GetSource() => "Housing_Compounds";
        public override string[] GetUniqueKeyFields() => new string[] { "Compound_Name" };
    }
}
