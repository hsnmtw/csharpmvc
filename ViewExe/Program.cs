using MVCHIS.Common;
using MVCHIS.Security;
using MVCHIS.Tools;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using MVCHIS.Utils.Net;

namespace MVCHIS {
    /// <summary>
    /// 
    /// </summary>
    static class Program
    {
        //[DllImport("kernel32.dll")]
        //static bool AttachConsole(int dwProcessId);
        //const int ATTACHPARENTPROCESS = -1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // AttachConsole(ATTACHPARENTPROCESS);

            //CURL.Read("http://localhost:8080/HIS.asmx/Test", delegate(string response) {
            //    Console.WriteLine(response);
            //});

            MVCHISSession.Instance.Initialize();
            Application.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainView.Instance);
        }

    }
}
