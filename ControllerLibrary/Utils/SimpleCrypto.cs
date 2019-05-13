using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Utils
{
    public class SimpleCrypto : ICrypto
    {

        private static byte[] key = new byte[8] { 1,2,4,9,7,6,0,3 };
        private static byte[] iv  = new byte[8] { 2,3,5,1,8,6,7,1 };

        public string encrypt(string plaintext)
        {
            SymmetricAlgorithm algorithm = DES.Create();
            ICryptoTransform transform = algorithm.CreateEncryptor(key, iv);
            byte[] inputbuffer = Encoding.Unicode.GetBytes(plaintext);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            byte[] zipped = Zip(outputBuffer);
            return "{ENC}" + Convert.ToBase64String(zipped);
        }

        public string decrypt(string encypted)
        {
            if (encypted == null) return "";
            if (!encypted.StartsWith("{ENC}")) return encypted;
            encypted = encypted.Substring("{ENC}".Length);
            SymmetricAlgorithm algorithm = DES.Create();
            ICryptoTransform transform = algorithm.CreateDecryptor(key, iv);
            byte[] inputbuffer = Convert.FromBase64String(encypted);
            byte[] unzipped = Unzip(inputbuffer);
            byte[] outputBuffer = transform.TransformFinalBlock(unzipped, 0, unzipped.Length);
            return Encoding.Unicode.GetString(outputBuffer);
        }

        public static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        public static byte[] Zip(byte[] bytes)
        {
            using (var msi = new System.IO.MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public static byte[] Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return mso.ToArray();
            }
        }


    }
}
