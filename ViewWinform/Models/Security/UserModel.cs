using MVCWinform.Common;
using System;

namespace MVCWinform.Security {
    public class UserModel : BaseModel
    {
        public string    UserName             { get; set; }
        public string    FullName             { get; set; }
        public string    UserPassword         { get; set; }
        public string    ProfileName          { get; set; }
        public bool      IsActive             { get; set; } 
        public string    Email                { get; set; } 
        public int       FailedLoginAttempts { get; set; } 
        public DateTime? LastLoginDate       { get; set; } 
        public DateTime? LastChangePassword  { get; set; }
    }
}
