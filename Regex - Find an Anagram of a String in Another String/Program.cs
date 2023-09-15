using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Regex___Find_an_Anagram_of_a_String_in_Another_String
{
    class Program
    {

        public static bool AnagramStrStr(string needle, string haystack)
        {
            if (Regex.IsMatch(haystack, needle) == false)
            {
                char[] charArray = needle.ToCharArray();
                Array.Reverse(charArray);
                needle = new string(charArray);
            }
            return Regex.IsMatch(haystack, needle);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AnagramStrStr("bol","sdfbolkug"));
        }
    }
}
