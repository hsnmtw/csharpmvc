namespace MVCWinform {
    public interface ICrypto
    {
        string encrypt(string plaintext);
        string decrypt(string encypted);
    }
}
