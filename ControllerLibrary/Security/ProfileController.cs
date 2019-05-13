using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Security;
using ControllerLibrary.Common;

namespace ControllerLibrary.Security
{
    public class ProfileController : AbstractController<ProfileModel>
    {
        public override string TABLE_NAME { get { return "Security_Profiles"; } }

        public override void updateMetaData() {
            MetaData["Profile_Name"] = "TEXT(50)";
        }

        public override DataTable search(ProfileModel model)
        {
            return db.query(new DBManagerLibrary.Common.Statement() {
                sql = string.Format(@"SELECT * FROM {0} WHERE [Profile_Name] LIKE @Profile_Name OR [Id]=@Id",this.TABLE_NAME),
                parameters = getParameters("Profile_Name,Id".Split(','), model)
            });
        }
    }
}
