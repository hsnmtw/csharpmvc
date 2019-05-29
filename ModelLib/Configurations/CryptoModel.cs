using MVCHIS.Common;
using System;

namespace MVCHIS.Configurations {
    public class CryptoModel : IModel {
        public string InputText { get; set; }
        public string Encrypted { get; set; }
        public string Decrypted { get; set; }
        public string Hashed    { get; set; }

        public object[] ToObjectArray(string[] fields) {
            throw new NotImplementedException();
        }
    }
}
