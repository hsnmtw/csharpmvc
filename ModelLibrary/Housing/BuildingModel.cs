using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Housing {
    public class BuildingModel : BaseModel {
        public string Building_Name { get; set; }
        public string Compound_Name { get; set; }

        public override string[] GetFields() => new string[]{
            "Compound_Name","Building_Name",
            "Id","Created_By","Created_On","Updated_By","Updated_On" };
        public override string[] GetPrimaryKeyFields() => "Id".Split(',');
        public override string[] GetRequiredFields() => "Id,Building_Name,Compound_Name".Split(',');
        public override string GetSource() => "Housing_Building";
        public override string[] GetUniqueKeyFields() => new string[] { "Building_Name" };
    }
}
