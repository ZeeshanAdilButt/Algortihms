using System;
using System.Collections.Generic;

namespace Stack_01_Easy_Sort_Stack_using_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> input = new Stack<int>();
            input.Push(34);
            input.Push(3);
            input.Push(31);
            input.Push(98);
            input.Push(92);
            input.Push(23);

            // This is the temporary stack 
            Stack<int> tmpStack = sortstack(input);

            Console.WriteLine("Sorted numbers are:");

            while (tmpStack.Count > 0)
            {
                Console.Write(tmpStack.Pop() + " ");
            }
        }

        private static Stack<int> sortstack(Stack<int> inputStack)
        {
            Stack<int> tmpStack = new Stack<int>(); // 34 3 98, 92


            while (inputStack.Count > 0)
            {
                var tempValue = inputStack.Pop(); // 23 , 92, 98, 31

                if (tmpStack.Count == 0 || tempValue > tmpStack.Peek()) // 92 > 23 // 98 > 92 // 31 > 98 X
                    tmpStack.Push(tempValue); // ->  23 
                else
                {
                    while (tmpStack.Count > 0 && tempValue < tmpStack.Peek()) // 31 < 23
                        inputStack.Push(tmpStack.Pop()); // 

                    inputStack.Push(tempValue);
                }


            }

            return tmpStack;

        }
    }
}
