using System;
using System.Collections.Generic;
using System.Linq;

namespace _0_scratchpad
{
    class Program
    {

        // max occuring char
        // max occuring word?
        public static int CharToAscii(char c)
        {
            int ascii = c;
            return ascii;
        }
        private static int getIndex(char character)
        {
            var code = CharToAscii(character);

            if (code == 32)
                return int.MaxValue;

            return code % 65;
            //return code - 'A';
        }

        /// <summary>
        /// MaxOcuueringWord finds first max word
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string MaxOcuuringWord(string text)
        {
            if (String.IsNullOrWhiteSpace(text))
                return "";

            //hashamp  key(string)|word    value(count)
            Dictionary<string, int> dictionary = new Dictionary<string, int>(); // O(N)

            List<string> words = text.Split(' ').ToList();

            foreach (var word in words)
            {
                if (!dictionary.ContainsKey(word))
                {                 //key(HELLO) value(1) -> //WORLD 1
                    dictionary.Add(word, 1);
                }
                else
                {
                    dictionary[word]++; // WORLD

                }
            }

            List<string> keys = dictionary.Keys.ToList(); // HELLO, WORLD

            int MaxValue = 0;
            string maxOccuringWord = "";

            foreach (var key in keys) // hello  -> world
            {
                var value = dictionary[key]; // 2 ->  1

                if (value > MaxValue) // 2 > 0 |  1 > 2 X
                {
                    MaxValue = value;  //2
                    maxOccuringWord = key; // hello
                }
            }

            // max => and same // 2, 2
            //list.Add(); // list of string // add all max occuring words

            return maxOccuringWord; // edge case if two words have same count
        }

        // problem: string => text ==>  find max num of occuring charcaters

        // string ABCDEFABA ==> A occurs 3 times

        static void Main(string[] args)
        {
            var sentence = "HELLO WORLD HELLO WORLD";

            var maxOcurringWord = MaxOcuuringWord(sentence);

            // cat ==> 99 + 97 + xyz
            // tac ==> xyz +  99 + 97

            // 0 --> an alphabet

            //A => 0th index map ==> 'A' - 'A' > 0
            // 'B' - 'A' > 1

            // A mod 65

            // ascii ==> 
            // mapping something to an array ==> 
            // very very basic hashing ==> 
            // mod -> remainder - NOPE => 
            // assumpitions => string => upper case letters
            //[stack] =>| [heap]
            int[] arr  = new int[26];

            var text = "ABCABDDDD";

            for (int i = 0; i < text.Length; i++)
            {
                var index = getIndex(text[i]);

                arr[index]++;
            }

            int maxCount = 0;
            int maxIndex = 0;

            for (int currentIndex = 0; currentIndex < arr.Length; currentIndex++)
            {       // A {index:0 value:2} > 0 // B {index:1 value:1}
                
                if (arr[currentIndex] > maxCount) { 
                    maxCount = arr[currentIndex]; // 2
                    maxIndex = currentIndex; // 0
                }
            }

            var maxchar = (char)(maxIndex + 65); // A
            Console.WriteLine("maxchar: " + maxchar);

            Console.WriteLine("Hello World!");
        }


    }
}
