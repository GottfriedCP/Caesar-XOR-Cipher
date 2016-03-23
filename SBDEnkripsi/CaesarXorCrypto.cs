using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBDEnkripsi
{
    class CaesarXorCrypto
    {
        public static string Encrypt(string msg, string key)
        {
            StringBuilder EncryptedString = new StringBuilder();

            for (int i = 0; i < msg.Length; i++)
            {
                EncryptedString.Append((char)((msg[i] + key[i % key.Length]) ^ key[i % key.Length]));
            }
            System.IO.File.WriteAllText("cipher.dat", EncryptedString.ToString());
            return EncryptedString.ToString();
        }

        public static string Decrypt(string msg, string key)
        {
            StringBuilder DecryptedString = new StringBuilder();

            for (int i = 0; i < msg.Length; i++)
            {
                DecryptedString.Append((char)((msg[i] ^ key[i % key.Length]) - key[i % key.Length]));
            }
            return DecryptedString.ToString();
        }
    }
}
