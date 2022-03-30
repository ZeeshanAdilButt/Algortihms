using System;
using System.Collections.Generic;

namespace AbstractDSA_HashMap
{

    public class Node {
        public string key { get; set; }
        public string Value { get; set; }
    }

    class UEHashMap {

        //List<T> list = new List<T>();
        
        Tuple<string, string>[] list = new string[10];

        public void Add(string key, string value) { // cat // tag

            int index = CalculateHash(key, list); // 0 // 0

            list[index] = (key, value);

        }

        public void FIND(string key) // CHAINING // 
        {

            int index = CalculateHash(key, list); // 5000 mod 10

            List<string> item =list[index] ;
            object item =list[index] ;


            // enclose
            if (item.key == key) {
                return item
            }
            else { 
                return list[index++]
            }

            foreach (var item in collection)
            {
                if (item.Key == key) {

                    return item.Value;

                }
            }

            return null;
        }

        // 5 (0) (5)
        // 5 X y z , 

        // sum = 5

        private int CalculateHash(string key, Tuple<string, string>[] list)
        {

            // test
            hash(char charac)
            {
                long hash = 5381;
                int c;

                while (c = *key++)
                    hash = ((hash << 5) + hash) + c; /* hash * 33 + c */

                return hash;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
