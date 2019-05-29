using System.Configuration;

namespace MVCHIS.Common {
    public static class ConfigLoader {
                                                                         
        public static string DatabaseFactory                             {get;private set;}
        public static string DatabaseConnectionString                    {get;private set;}
        public static string ConnectionString                            {get;private set;}
        public static string CultureInfoGlobalization                    {get;private set;}
        public static string CultureInfoDateTimeFormatShortDatePattern   {get;private set;}
        public static string CultureInfoDateTimeFormatLongDatePattern    {get;private set;}
        public static string CultureInfoDateTimeFormatDateSeparator      {get;private set;}
        public static string CultureInfoDateTimeFormatShortTimePattern   {get;private set;}
        public static string CultureInfoDateTimeFormatLongTimePattern    {get;private set;}
        public static string CultureInfoDateTimeFormatTimeSeparator      {get;private set;}

        public static void Initialize() {                                                                                                                         
            DatabaseFactory                            = ConfigurationManager.AppSettings["DatabaseFactory"] ;
            DatabaseConnectionString                   = ConfigurationManager.AppSettings["DatabaseConnectionString"] ;
            ConnectionString                           = ConfigurationManager.AppSettings["ConnectionString"] ;
            CultureInfoGlobalization                   = ConfigurationManager.AppSettings["CultureInfoGlobalization"] ;
            CultureInfoDateTimeFormatShortDatePattern  = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatShortDatePattern"] ;
            CultureInfoDateTimeFormatLongDatePattern   = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatLongDatePattern"] ;
            CultureInfoDateTimeFormatDateSeparator     = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatDateSeparator"] ;
            CultureInfoDateTimeFormatShortTimePattern  = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatShortTimePattern"] ;
            CultureInfoDateTimeFormatLongTimePattern   = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatLongTimePattern"] ;
            CultureInfoDateTimeFormatTimeSeparator     = ConfigurationManager.AppSettings["CultureInfoDateTimeFormatTimeSeparator"] ;
            ConfigLoader.ConnectionString              = ConfigurationManager.ConnectionStrings[ConfigLoader.DatabaseConnectionString].ConnectionString;
        }

    }
}
