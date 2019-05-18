using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class ProfileModel : BaseModel
    {
        public String Profile_Name { get; set; }
        public String Profile_Desc { get; set; }

        public override string[] GetFields() => new string[]{
            "Profile_Name","Profile_Desc",
            "Id","Created_By","Created_On","Updated_By","Updated_On" };
        public override string[] GetPrimaryKeyFields() => "Id".Split(',');
        public override string[] GetRequiredFields() => "Id,Profile_Name".Split(',');
        public override string GetSource() => "Security_Profiles";
        public override string[] GetUniqueKeyFields() => "Profile_Name".Split(',');
    }
}
