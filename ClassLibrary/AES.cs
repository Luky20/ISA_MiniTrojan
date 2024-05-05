using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AES
    {
        public static string key = "3A7F1D8E92B0C4F5E678A9BD0CEF2A4D";
        public static string Encrypt(string plainText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);

                // IV yang diberikan
                byte[] iv = new byte[aesAlg.BlockSize / 8]; // IV size in bytes

                // Buat IV statis, misalnya dengan nilai nol
                Array.Clear(iv, 0, iv.Length);

                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, iv))
                {
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plainText);
                            }
                        }
                        byte[] encryptedBytes = msEncrypt.ToArray();

                        // Combine IV and encrypted data into a single byte array
                        byte[] resultBytes = new byte[iv.Length + encryptedBytes.Length];
                        Buffer.BlockCopy(iv, 0, resultBytes, 0, iv.Length);
                        Buffer.BlockCopy(encryptedBytes, 0, resultBytes, iv.Length, encryptedBytes.Length);

                        return Convert.ToBase64String(resultBytes);
                    }
                }
            }
        }


        public static string Decrypt(string encryptedText, string key)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] iv = new byte[16]; // IV size for AES is always 16 bytes

            // Extract IV from the encrypted text
            Buffer.BlockCopy(cipherTextBytes, 0, iv, 0, iv.Length);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = iv;

                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                {
                    using (MemoryStream msDecrypt = new MemoryStream(cipherTextBytes, iv.Length, cipherTextBytes.Length - iv.Length))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }
    }
}
