using System;
using System.Collections.Generic;
using System.Text;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class UserModel : BaseModel
    {
        public String   User_Name             { get; set; }
        public String   Full_Name             { get; set; }
        public String   User_Password         { get; set; }
        public String   Profile_Name          { get; set; }
        public Boolean  Is_Active             { get; set; } 
        public String   Email                 { get; set; } 
        public Int32    Failed_Login_Attempts { get; set; } 
        public DateTime? Last_Login_Date       { get; set; } 
        public DateTime? Last_Change_Password  { get; set; }

        public override string[] GetFields() => new string[]{
            "User_Name","Full_Name","User_Password","Profile_Name",
            "Is_Active","Email","Failed_Login_Attempts","Last_Login_Date",
            "Id","Created_By","Created_On","Updated_By","Updated_On" };
        public override string[] GetPrimaryKeyFields() => "Id".Split(',');
        public override string[] GetRequiredFields() => "Id,User_Name,User_Password,Created_By,Created_On".Split(',');
        public override string GetSource() => "Security_Users";
        public override string[] GetUniqueKeyFields() => "User_Name".Split(',');
    }
}
