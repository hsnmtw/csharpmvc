using System.Configuration;

namespace MVCWinform.Utils {
    public class ConfigLoader {
                                                                         
        public static string DatabaseFactory                             {get;set;}
        public static string DatabaseConnectionString                    {get;set;}
        public static string ConnectionString                            {get;set;}
        public static string CultureInfoGlobalization                    {get;set;}
        public static string CultureInfoDateTimeFormatShortDatePattern   {get;set;}
        public static string CultureInfoDateTimeFormatLongDatePattern    {get;set;}
        public static string CultureInfoDateTimeFormatDateSeparator      {get;set;}
        public static string CultureInfoDateTimeFormatShortTimePattern   {get;set;}
        public static string CultureInfoDateTimeFormatLongTimePattern    {get;set;}
        public static string CultureInfoDateTimeFormatTimeSeparator      {get;set;}

        public ConfigLoader() {
            foreach(var propinfo in typeof(ConfigLoader).GetProperties()) {
                propinfo.SetValue(this, ConfigurationManager.AppSettings[propinfo.Name]);
            }
            ConfigLoader.ConnectionString = ConfigurationManager.ConnectionStrings[ConfigLoader.DatabaseConnectionString].ConnectionString;
        }

    }
}
