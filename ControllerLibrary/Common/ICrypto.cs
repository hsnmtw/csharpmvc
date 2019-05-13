using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary
{
    public interface ICrypto
    {
        string encrypt(string plaintext);
        string decrypt(string encypted);
    }
}
