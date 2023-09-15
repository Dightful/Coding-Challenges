using System;

namespace Regex___Find_an_Anagram_of_a_String_in_Another_String
{
    class Program
    {

        public static bool AnagramStrStr(string needle, string haystack)
        {
            int index = haystack.IndexOf(needle[0]);
            if (index == -1) 
            {
                return false;
            }

            int PrevIndex = index;

            index = haystack.IndexOf(needle[1]);

            string operator1 = "";

            if (index - 1 == PrevIndex)
            {
                operator1 = "-";
            }
            else if (index + 1 == PrevIndex)
            {
                operator1 = "+";
            }

            else
            {
                return false;
            }

            if (needle.Length < 3)
            {
                return true;
            }

            for (int i = 2;i<needle.Length;i++)
            {
                //find the index - if not there return false
                //hgave old index and check it is +- 1 of that 
                //first time round decides plus or minus
                PrevIndex = index;

                index = haystack.IndexOf(needle[i]);

                if (operator1 == "+") 
                {
                    if (index + 1 != PrevIndex)
                    {
                        return false;
                    }
                }
                else if (operator1 == "+")
                {
                    if (index - 1 != PrevIndex)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AnagramStrStr("bag", "grab"));
        }
    }
}
