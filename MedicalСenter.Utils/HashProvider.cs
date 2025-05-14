using System.Security.Cryptography;
using System.Text;

namespace MedicalСenter.Utils
{
    public static class HashProvider
    {
        public static string CreateSHA256(string input)
        {
            return Convert.ToHexString(SHA256.HashData(Encoding.ASCII.GetBytes(input)));
        }
    }
}
