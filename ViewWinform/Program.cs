using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Configuration;
using ModelLibrary.Common;
using ControllerLibrary.Common;
using System.IO;
using System.Runtime.InteropServices;

namespace ViewWinform
{

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

            DBConnectionManager.DBCONFIGFACTORY  = Utils.ConfigLoader.DatabaseFactory;
            DBConnectionManager.DBCONFIGPROVIDER = Utils.ConfigLoader.DatabaseProvider;
            DBConnectionManager.DBCONFIGSOURCE   = Utils.ConfigLoader.DatabaseSource;
            DBConnectionManager.DBCONFIGUSER     = Utils.ConfigLoader.DatabaseUserId;
            DBConnectionManager.DBCONFIGPASSWORD = Utils.ConfigLoader.DatabasePassword;


            //DBConnectionManager.Instance.FixColumnNames();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainView.Instance);
            //Application.Run(new Tools.CalendarForm());
        }
    }
}
