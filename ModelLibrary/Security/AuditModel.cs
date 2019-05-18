using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security {
    public class AuditModel : BaseModel {
        public string   User_Name        { get; set; }
        public DateTime Event_Date       { get; set; }
        public string   Event_Comments   { get; set; }

        public override string[] GetFields() => new string[]{
            "User_Name","Event_Date","Event_Comments",
            "Id","Created_By","Created_On","Updated_By","Updated_On" };
        public override string[] GetPrimaryKeyFields() => "Id".Split(',');
        public override string[] GetRequiredFields() => "Id,Event_Date,Event_Comments".Split(',');
        public override string GetSource() => "Security_Audit";
        public override string[] GetUniqueKeyFields() => new string[] { };
    }
}
