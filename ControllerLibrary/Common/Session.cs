using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary;
using ModelLibrary.Security;

namespace ControllerLibrary.Common
{
    public class Session
    {
        private static Session _instance = null;

        public UserModel CurrentUser { get; set; }

        private Session() { }

        public static Session Instance { get { if (_instance == null) { _instance = new Session(); }  return _instance; } }
    }
}
