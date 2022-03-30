using System;
using System.Collections;

namespace Queue_01_Easy_usingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Queue q = new Queue();
            q.enQueue(1);
            q.enQueue(2);
            q.enQueue(3);

            Console.Write(q.deQueue() + " ");
            Console.Write(q.deQueue() + " ");
            Console.Write(q.deQueue());
        }

        public class Queue
        {
            public Queue()
            {
            }

            Stack s1 = new Stack();
            Stack s2 = new Stack();

            internal void enQueue(int value)
            {
                s1.Push(value);
            }

            internal int deQueue()
            {
                while (s1.Count != 0)
                {
                    s2.Push(s1.Pop());
                }

                return (int)s2.Pop();
            }


        }
    }
}

