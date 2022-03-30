using System;
using System.Collections.Generic;

namespace _05PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DumpList(GetPrimeFactors(9));
        }

        public static List<int> GetPrimeFactors(int number)
        {
            if (number == 0 || number == 1)
                return new List<int>() { number };

            var list = new List<int>();

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                while (number % divisor == 0)
                {
                    number = number / divisor;
                    list.Add(divisor);
                }
            }

            if(number!=1)
                list.Add(number);

            return list;
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
