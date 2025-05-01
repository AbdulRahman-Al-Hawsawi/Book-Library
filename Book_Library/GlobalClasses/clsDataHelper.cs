using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library.GlobalClasses
{
    public class clsDataHelper
    {
        /// <summary>
        /// This function using for Encryption data one-way, that mean
        /// it can't be returned to its original form
        /// </summary>
        /// <param name="input">Data to encrytion</param>
        /// <returns>Encrypted value</returns>
        public static string ComputeHase(string input)
        {
            /// SHA is Secutred Hash Algorithm.
            /// Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                /// compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                /// convert th byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }



        /// <summary>
        /// This function using for encrypted the data with key
        /// </summary>
        /// <param name="plainText">Data to encrypt value</param>
        /// <param name="key">Encrypt key minimum size is 16 character</param>
        /// <returns>Encrypted data</returns>
        public static string Encrypt(string plainText, string key = "1234567890123456")
        {
            using (Aes aesAlg = Aes.Create())
            {
                /// set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);


                /*
                 Here, you are setting the IV of the AES algorithm to al block of bytes
                 with a size equal to the bolck size of the algorithm divided by 8.
                 The block size of AES is typically 128 bytes (16 bytes),
                 so the IV size is 128 bits / 8 = 16 bytes
                 */
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                /// Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                /// Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }

            }
        }

        /// <summary>
        /// This function using for decryption data with same encryption key
        /// </summary>
        /// <param name="cipherText">Encrypted data</param>
        /// <param name="key">Same encryption key</param>
        /// <returns>Decrypted data</returns>
        public static string Decrypt(string cipherText, string key = "1234567890123456")
        {
            using (Aes aesAlg = Aes.Create())
            {
                /// set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);

                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                /// Create an encryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                ///Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }

            }
        }
    }
}
