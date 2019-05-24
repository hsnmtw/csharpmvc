using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewWinform.Utils {
    public class ConfigLoader {
                                                                         
        public static string DatabaseFactory                             {get;set;}
        public static string DatabaseProvider                            {get;set;}
        public static string DatabaseSource                              {get;set;}
        public static string DatabaseUserId                              {get;set;}
        public static string DatabasePassword                            {get;set;}
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
        }

    }
}
