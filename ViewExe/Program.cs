using MVCHIS.Common;
using MVCHIS.Security;
using MVCHIS.Utils;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MVCHIS {

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
            Session.Instance.Initialize();
            //((ProfileEntitlementController)DBControllersFactory.GetController(MODELS.ProfileEntitlement)).Initialize();
            Application.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainView.Instance);
            
        }
    }
}
