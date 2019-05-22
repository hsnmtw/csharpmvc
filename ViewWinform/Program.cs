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

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(ConfigurationManager.AppSettings["CultureInfoGlobalization"]);
            
            cultureInfo.DateTimeFormat.ShortDatePattern = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatShortDatePattern"];
            cultureInfo.DateTimeFormat.LongDatePattern  = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatLongDatePattern"];
            cultureInfo.DateTimeFormat.DateSeparator    = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatDateSeparator"];
            cultureInfo.DateTimeFormat.ShortTimePattern = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatShortTimePattern"];
            cultureInfo.DateTimeFormat.LongTimePattern  = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatLongTimePattern"];
            cultureInfo.DateTimeFormat.TimeSeparator    = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatTimeSeparator"];


            cultureInfo.DateTimeFormat.Calendar = new GregorianCalendar();

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            Application.CurrentCulture = cultureInfo;

            DBConnectionManager.DBCONFIGFACTORY  = ConfigurationManager.AppSettings["DatabaseFactory"];
            DBConnectionManager.DBCONFIGPROVIDER = ConfigurationManager.AppSettings["DatabaseProvider"];
            DBConnectionManager.DBCONFIGSOURCE   = ConfigurationManager.AppSettings["DatabaseSource"];
            DBConnectionManager.DBCONFIGUSER     = ConfigurationManager.AppSettings["DatabaseUserId"];
            DBConnectionManager.DBCONFIGPASSWORD = ConfigurationManager.AppSettings["DatabasePassword"];


            //DBConnectionManager.Instance.FixColumnNames();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainView.Instance);
        }
    }
}
