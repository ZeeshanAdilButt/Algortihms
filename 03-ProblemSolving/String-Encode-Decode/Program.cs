using System.Text;

namespace String_Encode_Decode
{
    internal class Program
    {

        // Encodes a list of strings to a single string.
        public static string encode(IList<string> strs)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string str in strs)
            {
                sb.Append(str.Length + "#");
                sb.Append(str);
            }
            return sb.ToString();
        }

        // Decodes a single string to a list of strings.
        public static IList<string> decode(string s)
        {
            List<string> res = new List<string>();
            int i = 0;
            while (i < s.Length)
            {
                int j = i;
                while (s[j] != '#') j++;
                int len = int.Parse(s.Substring(i, j - i));
                res.Add(s.Substring(j + 1, len));
                i = j + len + 1;
            }
            return res;
        }

        static void Main(string[] args)
        {
            IList<string> input = new List<string>() { "Hello", "World" };
            string output = encode(input);
            IList<string> decoded = decode(output);



            Console.WriteLine("Hello, World!");
        }
    }
}