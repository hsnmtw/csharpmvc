namespace MVCHIS.Configurations {
    class CryptoFactory {
        
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }




        public static string Encrypt(string input)
        {
            return new SimpleCrypto().encrypt(input);
        }

        public static string Decrypt(string input)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            return new SimpleCrypto().decrypt(input);
        }
    }
}
