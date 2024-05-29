using Adiministativo.CCB.Aplication.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Adiministativo.CCB.Aplication.Services
{
    public class EncryptionService : IEncryptionService
    {
        private readonly string _key;
        private readonly string _iv;

        public EncryptionService(string key, string iv)
        {
            _key = key;
            _iv = iv;
        }

        public string Decrypt(string encryptedText)
        {
            using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(_key);
                aes.IV = Encoding.UTF8.GetBytes(_iv);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(encryptedText);
                        cs.Write(plainBytes, 0, plainBytes.Length);
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public string Encrypt(string plainText)
        {
            using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(_key);
                aes.IV = Encoding.UTF8.GetBytes(_iv);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        byte[] encryptedBytes = Convert.FromBase64String(plainText);
                        cs.Write(encryptedBytes, 0, encryptedBytes.Length);
                    }

                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }
    }
}
