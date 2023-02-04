namespace Stack_01_Easy_Sort_Stack_using_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> result = GroupAnagrams(strs);

        }
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();

            foreach (string str in strs)
            {
                int[] count = new int[26];
                foreach (char c in str)
                {
                    count[c - 'a']++;
                }
                string key = string.Join(",", count);
                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }
                map[key].Add(str);
            }

            return map.Values.ToList();
        }
    }

}

