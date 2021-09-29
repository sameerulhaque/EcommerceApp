using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Commons.Utils
{
    public class StringUtils
    {
        /// <summary>
        /// Change the SMTP PORT and SMTP CLIENT
        /// </summary>
        private static string emailAddressFrom = "";
        private static string emailAddressPassword = "";
        private static int smtpPort = 26;
        private static string smtpClient = "";

        public static String getEntityNameByClassName(String className)
        {
            string replaced = Regex.Replace(className, @"(?<!_)([A-Z])", "_$1");
            if (replaced[0] == '_')
            {
                return replaced.Substring(1).Replace("_DAO", "").ToLower();
            }
            return replaced.Replace("_DAO", "").ToLower();
        }



        public static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static String encryptPassword(String str)
        {
            str = sortString(str); //aany
            str = CalculateMD5Hash(str);//gyufyuftdty
            str = sortString(str);//
            str = CalculateMD5Hash(str);//sorted md5 hash
            return str;
        }

        public static string sortString(string str)
        {
            char[] array = str.ToCharArray();
            Array.Sort<char>(array);
            return new String(array);//.ToString();

        }

        public static string calculateEmailHashForOutcircle(string emailId)
        {
            string hash = CalculateMD5Hash(emailId);
            hash = sortString(hash);
            hash = CalculateMD5Hash(hash);
            hash = sortString(hash);
            hash = CalculateMD5Hash(hash);
            return hash;
        }

        public static string generatePassword()
        {
            string password = Guid.NewGuid().ToString();
            return password.Split('-')[0];
        }

        public static String generateRandomString(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;

        }

        public static string base64Decode(string data)
        {
            byte[] toDecodeByte = Convert.FromBase64String(data);

            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();

            int charCount = utf8Decode.GetCharCount(toDecodeByte, 0, toDecodeByte.Length);

            char[] decodedChar = new char[charCount];
            utf8Decode.GetChars(toDecodeByte, 0, toDecodeByte.Length, decodedChar, 0);
            string result = new String(decodedChar);
            return result;
        }

    }
}
