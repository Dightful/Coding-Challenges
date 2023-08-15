using System;

namespace Math___The_Smallest_Number
{
    class Program
    {
        public static string Smallest(int n)
        {
            bool x = true;
            long count = 0;
            if (n % 2 == 0 || n == 1)
            {
                count = n;
            }
            else
            {
                count = (n + 1);
            }
            int count2 = 0;
            while (x)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (count % i == 0)
                    {
                        count2++;
                    }
                                                            
                }
                
                if (count2 == n)
                {
                    return count.ToString();
                }
                else
                {

                    count += 2;                 
                    count2 = 0; 
                }
                
            }
            return null;  
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Smallest(20));
        }
    }
}
