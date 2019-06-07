using MVCHIS.Common;
using MVCHIS.Housing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace web {
    /// <summary>
    /// Summary description for HIS1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class HIS1 : System.Web.Services.WebService {

        [WebMethod, ScriptMethod(ResponseFormat = ResponseFormat.Json,UseHttpGet = true)]
        public void Test() {
            MVCHIS.Common.MVCHISSession.Instance.Initialize();

            json(DBControllersFactory.Room().Read());
        }


        private void json(object data) {
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(data));
        }
    }
}
