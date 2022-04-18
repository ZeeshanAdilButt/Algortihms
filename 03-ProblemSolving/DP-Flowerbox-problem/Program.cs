using System;
using System.Collections.Generic;

namespace DP_Flowerbox_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(flowerbox(new List<int> { 3, 10, 3,1,2}));
            Console.WriteLine(flowerbox(new List<int> { 9,10,9}));
        }

        public static int flowerbox(List<int> spots)
        {
            int a = 0;
            int b = 0; // intial spots set to 0

            foreach (int value in spots)
            {
                int olda = a;
                int oldb = b;

                a = oldb;
                b= Math.Max(olda + value, oldb);

            }

            return b;

        }
    }
}
