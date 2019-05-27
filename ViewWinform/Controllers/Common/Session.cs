using MVCWinform.Security;

namespace MVCWinform.Common {
    public class Session
    {
        private static Session instance = null;

        public UserModel CurrentUser { get; set; }

        private Session() { }

        public static Session Instance { get { if (instance == null) { instance = new Session(); }  return instance; } }
    }
}
