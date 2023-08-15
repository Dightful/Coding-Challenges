using System;
using System.Linq;
namespace Conditions
{
    class Program
    {
        static string ValidatePassword(string password)
        {
            bool Valid0 = false;
            bool Valid1 = false;
            bool Valid2 = false;
            bool Valid3 = false;
            char[] AlphaLower = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] AlphaUpper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] intergers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
            if (password.Length < 25 & password.Length >5)
            {
                Valid0 = true;
                for (int i = 0; i < password.Length; i++)
                {
                    char tempo = password[i];

                    //int count = password.Split(tempo).Length - 1;//need to have this uin seperate
                    int count = password.Count(f => f == tempo);
                    if (count > 2)
                    {
                        Console.WriteLine(count);
                        return "false";
                    }


                    if (AlphaUpper.Contains(tempo))
                    {
                        Valid1 = true;
                    }
                    else if (AlphaLower.Contains(tempo))
                    {
                        Valid2 = true;
                    }
                    else if (intergers.Contains(tempo))
                    {
                        Valid3 = true;
                    }
                }
                
            }
            if (Valid3 & Valid1 & Valid2 &  Valid0)
            {
                return "true";
            }
            else
            {
                return "false";
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePassword("Fhg93@@@"));
        }
    }
}
