using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Configurations {
    public class CryptoModel : IModel {
        public string InputText { get; set; }
        public string Encrypted { get; set; }
        public string Decrypted { get; set; }
        public string Hashed    { get; set; }
    }
}
