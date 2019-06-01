using MVCHIS.Common;
using MVCHIS.Security;
using MVCHIS.Tools;
using MVCHIS.Utils;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

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
            Session.Instance.Initialize();

            //((Customers.CountryController)DBControllersFactory.GetController<Customers.CountryModel>()).Initialize();
            //System.Collections.Generic.List<object> tables = new System.Collections.Generic.List<object>();
            ////var f = typeof(IDBController<BaseModel>).GetMethod("GetMetaData");
                
            //foreach (MODELS m in Enum.GetValues(typeof(MODELS))) {
            //    var c = DBControllersFactory.GetController(m);
            //    var f = c.GetType().GetMethod("GetMetaData");
            //    var d = f.Invoke(c, null);
            //    tables.Add( d.GetType().GetProperty("Source").GetValue(d) );
            //}
            //foreach (var t in tables) {
                
            //    try {
            //        new SQLController().Execute("drop table " + t);
            //        Console.WriteLine("DROPPED : "+t);
            //    } catch {
            //        Console.WriteLine("NOT THERE : " + t);
            //    }
            //    //Application.Exit();
            //}

            Application.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            foreach(MODELS m in Enum.GetValues(typeof(MODELS))) {
                DBControllersFactory.GetController(m);
            }
            Application.Run(MainView.Instance);
            
        }
    }
}
