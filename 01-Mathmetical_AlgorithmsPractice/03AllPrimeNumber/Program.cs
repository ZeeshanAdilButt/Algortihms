using System;
using System.Collections.Generic;

namespace _03AllPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeNumbers = FindAllPrimeNumbers(6);
            DumpList(primeNumbers);
            Console.WriteLine("Hello World!");
        }

        public static List<int> FindAllPrimeNumbers(int number)
        {
            if (number == 0 || number == 1)
                return null;

            if (number == 2)
                return new List<int>() { 2 };

            List<int> primeNumbers = new List<int>() { 2 };

            //looping on the number (3... 17)
            //currentNumber = 17
            for (int currentNumber = 3; currentNumber <= number; currentNumber++)
            {
                bool isPrime = true;

                // looping on the list of prime numbers 
                for (int primeNumberIndex = 0; IsLessThanCountAndSqrtOfNumber(primeNumberIndex, primeNumbers, currentNumber); primeNumberIndex++)
                {
                    //if any of the primenumbers divide it, its not prime

                    // if any number fully divides it, and is less than sqrt of number
                    if (currentNumber % primeNumbers[primeNumberIndex] == 0)
                    {
                        isPrime = false;
                    }

                }
                if (isPrime)
                {
                    primeNumbers.Add(currentNumber);
                }
            }
            return primeNumbers;
        }

        public static bool IsLessThanCountAndSqrtOfNumber(int primeNumberIndex, List<int> primeNumbers, int currentNumber)
        {
            // if(currentNumber < Math.Sqrt() )
            if (primeNumberIndex < primeNumbers.Count && primeNumbers[primeNumberIndex] <= (int)Math.Sqrt(currentNumber))
                return true;

            return false;
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
