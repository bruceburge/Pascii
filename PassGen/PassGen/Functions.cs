using System;
using System.Collections.Generic;
using System.Text;

namespace PassGen
{
    public static class Functions
    {
        public static string GetRandomString(Random rnd, int length, string chars)
        {
            if (chars == null)
            {                
                /*set default values to upper/lower alphanumeric and special*/
                chars = PassGen.Properties.Settings.Default.PassChars.ToString()+PassGen.Properties.Settings.Default.ForcedSpecials.ToString();
            }

            StringBuilder rs = new StringBuilder();
            while (length > 0)
            {
                rs.Append(chars[(int)(rnd.NextDouble() * chars.Length)]);
                length--;
            }
            return rs.ToString();
        }

        public static string GenPassword(Random rnd)
        {
            string password = "";
            int passLen = PassGen.Properties.Settings.Default.DefaultLength;

            if (PassGen.Properties.Settings.Default.IncludeSpecials == true)
            {                
                password = Functions.GetRandomString(rnd, passLen, null);
            }
            else
            {
                string Chars = PassGen.Properties.Settings.Default.PassChars;
                password = Functions.GetRandomString(rnd, passLen, Chars);
            }

            if (PassGen.Properties.Settings.Default.ForceSpecial == true)
            {
                string specChars = PassGen.Properties.Settings.Default.ForcedSpecials;
                /*adds special char to start and end of password*/
                password = 
                    Functions.GetRandomString(rnd, 1, specChars) + 
                    password +
                    Functions.GetRandomString(rnd, 1, specChars);
            }
            return password;
        }

        public static int str2int(string str)
        {
            int seed = 0;
            /*turn the key phrase into an int and use it as seed*/
            char[] tmp = str.ToCharArray();
            foreach (char x in tmp)
            {
                seed += (int)x;
            }
            return seed;
        }
    }
}
