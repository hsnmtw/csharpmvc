using MVCHIS.Security;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace MVCHIS.Common {
    public class MVCHISSession {
        private static MVCHISSession instance = null;
        public static MVCHISSession Instance {
            get {
                if (instance == null) { instance = new MVCHISSession(); }
                return instance;
            }
        }
        public UserModel CurrentUser { get; set; }
        public IEnumerable<ProfileEntitlementModel> UserEntitlements { get; set;}

        private MVCHISSession() {}

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

        }

        
    }
}
