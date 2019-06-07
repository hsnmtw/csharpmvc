using System;
using System.Collections.Generic;
using System.Data;
using MVCHIS.Common;

namespace MVCHIS.Configurations {
    public class CryptoController : IController {
        public Action<int> OnSaveAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Action<int> OnDeleteAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DataTable GetData() {
            throw new System.NotImplementedException();
        }

        public string GetValues(int id) {
            throw new NotImplementedException();
        }

        public Dictionary<int,string> GetKeysAndValues() {
            throw new NotImplementedException();
        }

        public MetaData GetMetaData() {
            throw new System.NotImplementedException();
        }

        public Type GetModelType() => typeof(CryptoModel);

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
