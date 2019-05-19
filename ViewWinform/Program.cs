﻿using System;
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
        private const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AttachConsole(ATTACH_PARENT_PROCESS);

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(ConfigurationManager.AppSettings["CultureInfo_Globalization"]);

            
            cultureInfo.DateTimeFormat.ShortDatePattern = ConfigurationManager.AppSettings["CultureInfo_DateTimeFormat_ShortDatePattern"];
            cultureInfo.DateTimeFormat.LongDatePattern  = ConfigurationManager.AppSettings["CultureInfo_DateTimeFormat_LongDatePattern"];
            cultureInfo.DateTimeFormat.DateSeparator    = ConfigurationManager.AppSettings["CultureInfo_DateTimeFormat_DateSeparator"];
            cultureInfo.DateTimeFormat.ShortTimePattern = ConfigurationManager.AppSettings["CultureInfo_DateTimeFormat_ShortTimePattern"];
            cultureInfo.DateTimeFormat.LongTimePattern  = ConfigurationManager.AppSettings["CultureInfo_DateTimeFormat_LongTimePattern"];
            cultureInfo.DateTimeFormat.TimeSeparator    = ConfigurationManager.AppSettings["CultureInfo_DateTimeFormat_TimeSeparator"];


            cultureInfo.DateTimeFormat.Calendar = new GregorianCalendar();

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            Application.CurrentCulture = cultureInfo;

            DBConnectionManager.DB_CONFIG_FACTORY  = ConfigurationManager.AppSettings["Database_Factory"];
            DBConnectionManager.DB_CONFIG_PROVIDER = ConfigurationManager.AppSettings["Database_Provider"];
            DBConnectionManager.DB_CONFIG_SOURCE   = ConfigurationManager.AppSettings["Database_Source"];
            DBConnectionManager.DB_CONFIG_USER     = ConfigurationManager.AppSettings["Database_User_Id"];
            DBConnectionManager.DB_CONFIG_PASSWORD = ConfigurationManager.AppSettings["Database_Password"];




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainView.Instance);
        }
    }
}
