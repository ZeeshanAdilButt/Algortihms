using System;
using System.Collections.Generic;

namespace _01_DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            int decimalNumber = 125;

            //what if the number is in points?
            var response = ConvertToBinary(decimalNumber);
            DumpStack(response);

            System.Console.WriteLine("second method");
            var response2 = ConvertToBinary2(decimalNumber);
            DumpList(response2);


            System.Console.WriteLine("second method");
            var response3 = ConvertToBinaryRecursion(decimalNumber);
            DumpList(response3);


            Console.WriteLine("decimal conversion!");
        }

        public static Stack<ushort> ConvertToBinary(int number)
        {
            if (number == 0)
            {
                var emptyStack = new Stack<ushort>();
                emptyStack.Push(0);
                return emptyStack;
            }

            Stack<ushort> binaryNumbers = new Stack<ushort>();

            while (true)
            {
                ushort remainder = (ushort)(number % 2);
                binaryNumbers.Push(remainder);
                number = number / 2;

                if (number == 0)
                    break;
            }
            return binaryNumbers;
        }

        public static List<ushort> ConvertToBinary2(int number)
        {
            if (number == 0)
                return new List<ushort> { 0 };

            List<ushort> binaryNumbers = new List<ushort>();

            while (number != 0)
            {
                ushort remainder = (ushort)(number % 2); // .5 -> 1
                binaryNumbers.Add(remainder);  // 1 

                number = number / 2;
            }

            binaryNumbers.Reverse();
            return binaryNumbers;
        }

        
        public static List<ushort> ConvertToBinaryRecursion(int number)
        {
            if (number == 0)
                return new List<ushort> { 0 };

            List<ushort> binaryNumbers = new List<ushort>();

            while (number != 0)
            {
                ushort remainder = (ushort)(number % 2); // .5 -> 1
                binaryNumbers.Add(remainder);  // 1 

                number = number / 2;
            }

            binaryNumbers.Reverse();
            return binaryNumbers;
        }

        public static void DumpStack<T>(Stack<T> stack)
        {
            foreach (var item in stack)
            {

                Console.WriteLine(item);

            }

        } // dumps list
        public static void DumpList<T>(List<T> list)
        {

            foreach (var item in list)
            {

                Console.WriteLine(item);

            }

        }
    }
}
