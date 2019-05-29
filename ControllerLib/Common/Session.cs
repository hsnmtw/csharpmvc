using MVCHIS.Security;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace MVCHIS.Common {
    public class Session {
        private static Session instance = null;

        public UserModel CurrentUser { get; set; }
        public IEnumerable<ProfileEntitlementsModel> UserEntitlements { get; set;}

        private Session() {
        }

        public void Initialize() {
            ConfigLoader.Initialize();

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(ConfigLoader.CultureInfoGlobalization);

            cultureInfo.DateTimeFormat.ShortDatePattern = ConfigLoader.CultureInfoDateTimeFormatShortDatePattern;
            cultureInfo.DateTimeFormat.LongDatePattern = ConfigLoader.CultureInfoDateTimeFormatLongDatePattern;
            cultureInfo.DateTimeFormat.DateSeparator = ConfigLoader.CultureInfoDateTimeFormatDateSeparator;
            cultureInfo.DateTimeFormat.ShortTimePattern = ConfigLoader.CultureInfoDateTimeFormatShortTimePattern;
            cultureInfo.DateTimeFormat.LongTimePattern = ConfigLoader.CultureInfoDateTimeFormatLongTimePattern;
            cultureInfo.DateTimeFormat.TimeSeparator = ConfigLoader.CultureInfoDateTimeFormatTimeSeparator;


            cultureInfo.DateTimeFormat.Calendar = new GregorianCalendar();

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            

            DBConnectionManager.FACTORY = ConfigLoader.DatabaseFactory;
            DBConnectionManager.CONNECTION_STRING = ConfigLoader.ConnectionString;


            DBEntitiesFactory.Initialize();
            DBControllersFactory.Initialize();
        }

        public static Session Instance { get { if (instance == null) { instance = new Session(); }  return instance; } }
    }
}
