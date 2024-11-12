CryptoStreamMode.Read))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encryption
{
    public class AesEncryption
    {
        private static readonly byte[] key = { /* Key bytes here */ };
        private static readonly byte[] iv = { /* IV bytes here */ };

        public static string Encrypt(string plainText)
        {
            byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(plainBytes, 0, plainBytes.Length);
                        cs.Close();
                    }
                    string cipherText = Convert.ToBase64String(ms.ToArray());
                    return cipherText;
                }
            }
        }
    }
}