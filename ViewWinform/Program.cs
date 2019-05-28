using MVCWinform.Common;
using MVCWinform.Utils;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MVCWinform {

    static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACHPARENTPROCESS = -1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AttachConsole(ATTACHPARENTPROCESS);
            new Utils.ConfigLoader();

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(Utils.ConfigLoader.CultureInfoGlobalization);
            
            cultureInfo.DateTimeFormat.ShortDatePattern = Utils.ConfigLoader.CultureInfoDateTimeFormatShortDatePattern;
            cultureInfo.DateTimeFormat.LongDatePattern  = Utils.ConfigLoader.CultureInfoDateTimeFormatLongDatePattern;
            cultureInfo.DateTimeFormat.DateSeparator    = Utils.ConfigLoader.CultureInfoDateTimeFormatDateSeparator;
            cultureInfo.DateTimeFormat.ShortTimePattern = Utils.ConfigLoader.CultureInfoDateTimeFormatShortTimePattern;
            cultureInfo.DateTimeFormat.LongTimePattern  = Utils.ConfigLoader.CultureInfoDateTimeFormatLongTimePattern;
            cultureInfo.DateTimeFormat.TimeSeparator    = Utils.ConfigLoader.CultureInfoDateTimeFormatTimeSeparator;


            cultureInfo.DateTimeFormat.Calendar = new GregorianCalendar();

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            Application.CurrentCulture = cultureInfo;

            DBConnectionManager.FACTORY           = Utils.ConfigLoader.DatabaseFactory;
            DBConnectionManager.CONNECTION_STRING = Utils.ConfigLoader.ConnectionString;


            DBEntitiesFactory.InitEntitiesMap();
            DBControllersFactory.InitControllersMap();
            //DBViewsFactory.InitViewsMap();

            Session.Instance.CurrentUser = null;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainView.Instance);
        }
    }
}
