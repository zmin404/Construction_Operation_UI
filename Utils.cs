using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ISOFormat
{
    public static class Utils
    {
        public static string HashPassword(string password)
        {
            byte[] hashedPassword;

            using (SHA1 sha1 = new SHA1Managed())
            {
                hashedPassword = sha1.ComputeHash(Encoding.ASCII.GetBytes(password));
            }

            string hexPassword = "0x" + BitConverter.ToString(hashedPassword).Replace("-", "");

            return hexPassword;
        }
    }
}
