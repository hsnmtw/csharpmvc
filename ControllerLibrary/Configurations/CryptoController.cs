using ControllerLibrary.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Configurations;
using ModelLibrary.Common;

namespace ControllerLibrary.Configurations {
    public class CryptoController : BaseController {
        public string Source => throw new NotImplementedException();

        public void Delete(object model) {
            throw new NotImplementedException();
        }

        public object Dispatch(string action, params object[] arguments) {
            throw new NotImplementedException();
        }

        public MetaData GetMetaData() {
            throw new NotImplementedException();
        }

        public DataTable GetTable() {
            throw new NotImplementedException();
        }

        public DataTable GetTable(object model, string[] whereFields) {
            throw new NotImplementedException();
        }

        public CryptoModel Process(CryptoModel model) {
            model.Encrypted = CryptoFactory.Encrypt(model.InputText);
            if (model.InputText.StartsWith("{ENC}")) {
                model.Decrypted = CryptoFactory.Decrypt(model.InputText);
            }
            //model.Hashed = new System.Security.;
            return model;
        }

        public List<object> Read() {
            throw new NotImplementedException();
        }

        public List<object> Read(object model, string[] whereFields) {
            throw new NotImplementedException();
        }

        public object Save(object model) {
            throw new NotImplementedException();
        }
    }
}
