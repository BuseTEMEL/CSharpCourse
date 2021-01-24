using System;
using System.Runtime.CompilerServices;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //int number = 100;
            //while (number >=0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //Console.WriteLine("Now number is {0}", number);
            //Console.ReadLine();

            if (IsPrimeNumber(11))
            {
                Console.WriteLine("this is a prime number");
            }
            else
            {
                Console.WriteLine("this is a not prime number");
            }
            Console.ReadLine();
            
        }

        private static bool IsPrimeNumber(int number)
        {
            bool resault = true;
            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    resault = false;
                }
            }
            return resault;

            
        }
    }
}
