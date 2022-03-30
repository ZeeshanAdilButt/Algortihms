using System;
using System.Collections.Generic;

namespace _04FindAllFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DumpList(GetFactors(2236));
        }

        public static List<int> GetFactors(int number)
        {
            if (number == 0 || number == 1)
            {
                return new List<int> { number };
            }

            List<int> factors = new List<int> { 1 };

            for (int divisor = 2; divisor <= number/2; divisor++)
            {
                if(number % divisor == 0)
                factors.Add(divisor);
            }

            factors.Add(number);
            return factors;
        }

         public static void DumpList<T>(List<T> list)
        {
            if (list == null)
                Console.WriteLine("no items founds");

            foreach (var item in list)
            {

                Console.WriteLine(item);
            }
        }
    }
}
