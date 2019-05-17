using ControllerLibrary.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Configurations;

namespace ControllerLibrary.Configurations {
    public class CryptoController : BaseController {
        public string Source => throw new NotImplementedException();

        public DataTable selectModelsAsDataTable() {
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
    }
}
