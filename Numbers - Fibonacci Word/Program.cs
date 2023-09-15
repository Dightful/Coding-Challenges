using System;
using System.Collections.Generic;
namespace FibonacciWordVryHard
{
    class Program
    {
        static void Fibo(int numbv)
        {
            List<string> sequence = new List<string>();
            sequence.Add("b");
            sequence.Add("a");
            for (int i = 0; i < (numbv-2); i++)
            {
                string temporary = sequence[i];
                string temporary2 = sequence[i+1];
                string joinedTemporary = temporary2 + temporary;
                sequence.Add(joinedTemporary);
            }

            foreach (string i in sequence)
            {
                Console.Write("{0} ",i);
            }


        }


        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 1)
            {
                Fibo(number);
            } else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
