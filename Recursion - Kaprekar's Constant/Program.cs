using System;
using System.Linq;

namespace Recursion___Kaprekar_s_Constant
{
    class Program
    {
        static int counter1 = 0;
        static void Kaprekar(double num)
        {
            int LengthofNum = num.ToString().Length;

            if (LengthofNum < 4)
            {
                num = num * Math.Pow(10,( 4 - LengthofNum)); //do 4 - LengthofNum then that equals 10 or 100, recursively? if not use a if
                LengthofNum = num.ToString().Length;
            }


            int[] Descending = new int[LengthofNum];
            int[] Ascending = new int[LengthofNum];
            string numString = num.ToString();
            for (int i = 0; i< LengthofNum; i++)
            {
                char StringToUse = numString[i];
                int NumberToUse = StringToUse - '0';
                Ascending[i] = NumberToUse;
            }
            Array.Sort(Ascending);
            int count = 3;
            foreach (int i in Ascending)
            {
                Descending[count] = i;
                count--;
            }

            int DescendingInt = 0;
            for (int i = 0; i < Descending.Length; i++)
            {
                DescendingInt += Descending[i] * Convert.ToInt32(Math.Pow(10, Descending.Length - i - 1));
            }
            int AscendingInt = 0;
            for (int i = 0; i < Ascending.Length; i++)
            {
                AscendingInt += Ascending[i] * Convert.ToInt32(Math.Pow(10, Ascending.Length - i - 1));
            }


            int result = DescendingInt - AscendingInt;
            counter1++;

            if (result == 6174)
            {
                
                Console.WriteLine(counter1);
            }
            else
            {
                
                Kaprekar(result);
            }

            


        }


        static void Main(string[] args)
        {
           Kaprekar(495);
        }
    }
}
