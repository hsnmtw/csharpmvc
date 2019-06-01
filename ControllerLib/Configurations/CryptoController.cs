using System.Data;
using MVCHIS.Common;

namespace MVCHIS.Configurations {
    public class CryptoController : IController {
        public DataTable GetData() {
            throw new System.NotImplementedException();
        }

        public MetaData GetMetaData() {
            throw new System.NotImplementedException();
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
