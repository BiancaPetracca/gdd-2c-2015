using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Generics
{
    class Crypto
    {
        public static byte[] getSHA256(string input)
        {

            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] hashValue;
            hashValue = mySHA256.ComputeHash(GetBytes(input));
            return hashValue;

        }

        private static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

    }

}
