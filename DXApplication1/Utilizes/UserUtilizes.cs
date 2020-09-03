using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace DXApplication1.Utilizes
{
    public class UserUtilizes
    {
        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^([0-9]{6,10})$").Success;
        }

        public static bool IsValidDay(DateTime dateTime)
        {
            if (dateTime.Date <= DateTime.Now.Date)
                return true;
            return false;
        }
    }
}
