using System;

namespace BitManipulation_01_Easy_Add_Numbers_Without_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add2(3,2));
        }

        static int Add(int x, int y)
        {
            if (y == 0)
                return x;
            else
                return Add(x ^ y, (x & y) << 1);
        }

        public static int Add2(int x, int y)
        {
            // Iterate till there is no carry
            while (y != 0)
            {
                // carry should be unsigned to
                // deal with -ve numbers
                // carry now contains common
                //set bits of x and y
                int carry = x & y;

                // Sum of bits of x and y where at
                //least one of the bits is not set
                x = x ^ y;

                // Carry is shifted by one so that adding
                // it to x gives the required sum
                y = carry << 1;
            }
            return x;
        }

    }
}
