using CapaInterfaces;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Utilidades.Seguridad
{
    class MD5Hash : IEncriptador
    {
        public bool Encriptar(ref string input)
        {
            try
            {
                MD5 md5Hash = MD5.Create();
                string hash = GetMd5Hash(md5Hash, input);
                if (VerifyMd5Hash(md5Hash, input, hash))
                {
                    input = hash;
                    return true;
                }
                else
                    throw new Exception();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo validar si la encriptación fue correcta",ex);
            }

        }
        private static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        private static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return 0 == comparer.Compare(hashOfInput, hash) ? true : false;

        }


    }
}
