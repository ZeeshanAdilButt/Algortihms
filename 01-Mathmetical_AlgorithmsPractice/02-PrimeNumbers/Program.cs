using System;

namespace _02_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // System.Console.WriteLine(IsPrimeNumber(2));
            // System.Console.WriteLine(IsPrimeNumber(3));
            // System.Console.WriteLine(IsPrimeNumber(4));
            // System.Console.WriteLine(IsPrimeNumber(5));
            System.Console.WriteLine(IsPrimeNumber(7));
            System.Console.WriteLine(IsPrimeNumber(36));

        }

        // the idea of a prime number here is that, it will be have two number (a,b)
        //which when multiplied give the number n
        //e.g 36 can be achived like this: 
        // {1,36} -> 1 divides 36  when multiplied with 36
        // {2,18} -> 2 divides 36  when multiplied with 18
        // {3,12} -> 3 divides 36  when multiplied with 12 and so on.. 
        // now at some point a is going to switch places with b
        // and one of (a,b) can never be greater than n/2 which means only loop till n/2
        // but if we consider it will also never be greater than square root of n
        // let's say for a complete square the factors are (6,6) here 6 (a) is sqrt of 36
        // which means only loop till sqrt(n)
        public static bool IsPrimeNumber(int number) // number -> n
        {

            if (number == 1)
                return false;

            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        //second method Like it says here, these pairs will have two numbers.  When we start, the first number, the divisor, is less than the quotient, but at some point, this inequality switches.
        //So, simply stop when the divisor becomes greater than the quotient.

         public static bool IsPrimeNumber2(int number) // number -> n
        {

            if (number == 1)
                return false;

            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
