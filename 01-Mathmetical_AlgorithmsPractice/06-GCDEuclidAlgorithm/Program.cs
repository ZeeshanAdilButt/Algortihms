using System;
using System.Collections.Generic;

namespace _06_GCDEuclidAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DumpList(GetGCD(400,124));
        }

        public static List<int> GetGCD(int a, int b)
        {
            int divisor = a;
            int dividend = b;

            if ((a == 0 && b == 0) || (a == 1 || b == 1))
                return new List<int> { a };

            var list = new List<int>();

            while (divisor != 0)
            {
                int remainder = dividend % divisor;
                dividend = divisor;
                divisor = remainder;
            }
            list.Add(dividend);
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
