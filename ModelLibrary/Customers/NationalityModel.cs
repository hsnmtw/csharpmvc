using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class NationalityModel : BaseModel {
        public string Nationality_Code { get; set; }
        public string Nationality_Desc { get; set; }
        public string Nationality_Arabic { get; set; }


        public override string[] GetFields() => new string[]{
            "Nationality_Code","Nationality_Desc","Nationality_Arabic",
            "Id","Created_By","Created_On","Updated_By","Updated_On" };
        
        public override string[] GetPrimaryKeyFields() => "Id".Split(',');
        public override string[] GetRequiredFields() => "Id,Nationality_Code,Nationality_Desc,Nationality_Arabic".Split(',');
        public override string GetSource() => "Customers_Nationalities";
        public override string[] GetUniqueKeyFields() => new string[] { "Nationality_Code" };
    }
}
