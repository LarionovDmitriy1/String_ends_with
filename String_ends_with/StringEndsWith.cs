using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_ends_with
{
    public class StringEndsWith
    {
        public static bool Solution(string str, string ending)
        {
            if (str.Length < ending.Length) { return false; }
            for (int i = 1; i < ending.Length + 1; i++)
            {
                string s = str.Substring(str.Length - i);
                string s1 = ending.Substring(ending.Length - i);

                if (s == s1)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
