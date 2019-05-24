using ControllerLibrary.Common;
using ModelLibrary.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using System.IO;
using System.Data;
using ModelLibrary.Common;

namespace ControllerLibrary.Configurations {
    public class ConfigurationsController : IDBController {       
        public string Source => string.Format(@"{0}.config", System.Reflection.Assembly.GetEntryAssembly().CodeBase.Replace("file:///",""));

        public List<ConfigurationModel> Database { private set; get; }
        public List<ConfigurationModel> CultureInfo { private set; get; }

        public ConfigurationsController() : base() {
            this.Database = new List<ConfigurationModel>();
            this.CultureInfo = new List<ConfigurationModel>();
            XmlDocument document = new XmlDocument();
            FileStream fs = new FileStream(this.Source,FileMode.Open,FileAccess.Read);
            document.Load(fs);
            XmlNodeList appSettings = document.GetElementsByTagName("appSettings");
            foreach(XmlNode node in appSettings[0].ChildNodes) {
                string key = node.Attributes["key"].Value;
                string val = node.Attributes["value"].Value;
                if (key.StartsWith("Database")) {
                    this.Database.Add(new ConfigurationModel() { Key = key, Value = val });
                }
                else if (key.StartsWith("CultureInfo")) {
                    this.CultureInfo.Add(new ConfigurationModel() { Key = key, Value = val });
                }
            }
            fs.Close();
        }

        public string GetShortDateFormat() {
            return this.CultureInfo.Where(x => x.Key.Contains("ShortDate")).First().Value;
        }

        public string GetLongDateFormat() {
            return this.CultureInfo.Where(x => x.Key.Contains("LongDate")).First().Value;
        }

        public DataTable GetTable() => throw new NotImplementedException();

        public DataTable GetTable(object model, string[] whereFields) {
            throw new NotImplementedException();
        }

        public List<object> Read() {
            throw new NotImplementedException();
        }

        public List<object> Read(object model, string[] whereFields) {
            throw new NotImplementedException();
        }

        public DBModificationResult Save(object model) {
            throw new NotImplementedException();
        }

        public DBModificationResult Delete(object model) {
            throw new NotImplementedException();
        }

        public MetaData GetMetaData() {
            throw new NotImplementedException();
        }

        public object Dispatch(string action, params object[] arguments) {
            throw new NotImplementedException();
        }

        public DataTable GetTable(object model, string[] whereFields, int offset, int length) {
            throw new NotImplementedException();
        }

        public object CreateNewModel() {
            throw new NotImplementedException();
        }

        public DataTable GetTable(object model, string[] whereFields, bool like = false) {
            throw new NotImplementedException();
        }

        public ResultSet GetTable(object model, string[] whereFields, bool like, int offset, int length) {
            throw new NotImplementedException();
        }
    }
}
