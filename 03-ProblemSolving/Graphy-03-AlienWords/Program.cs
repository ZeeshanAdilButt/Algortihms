namespace Graph_02_MST_Prim
{
    // A C# program for Prim's Minimum
    // Spanning Tree (MST) algorithm.
    // The program is for adjacency
    // matrix representation of the graph
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography.X509Certificates;

    class MST
    {

        public static string AlienOrder(string[] words)
        {
            var graph = new Dictionary<char, HashSet<char>>();
            var visited = new Dictionary<char, int>();
            var stack = new Stack<char>();

            // Initialize the graph and visited map
            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    visited[c] = 0;
                    if (!graph.ContainsKey(c))
                    {
                        graph[c] = new HashSet<char>();
                    }
                }
            }

            // Build the graph
            for (int i = 0; i < words.Length - 1; i++)
            {
                var word1 = words[i];
                var word2 = words[i + 1];
                var minLen = Math.Min(word1.Length, word2.Length);
                for (int j = 0; j < minLen; j++)
                {
                    if (word1[j] != word2[j])
                    {
                        if (!graph[word1[j]].Contains(word2[j]))
                        {
                            graph[word1[j]].Add(word2[j]);
                        }
                        break;
                    }
                }
            }

            // Perform DFS
            var result = new List<char>();
            foreach (var c in graph.Keys)
            {
                if (visited[c] == 0)
                {
                    if (!DFS(graph, visited, stack, c))
                    {
                        return "";
                    }
                }
            }

            // Return the result as a string
            while (stack.Count > 0)
            {
                result.Add(stack.Pop());
            }
            return new string(result.ToArray());
        }

        private static bool DFS(Dictionary<char, HashSet<char>> graph, Dictionary<char, int> visited, Stack<char> stack, char curr)
        {
            visited[curr] = 1;
            foreach (var neighbor in graph[curr])
            {
                //this means a cycle, as this neighbor is already in the current path
                if (visited[neighbor] == 1)
                {
                    return false;
                }
                if (visited[neighbor] == 0)
                {
                    if (!DFS(graph, visited, stack, neighbor))
                    {
                        return false;
                    }
                }
            }


            visited[curr] = 2;
            stack.Push(curr);
            return true;
        }

        public static void Main()
        {
            var words = new string[]{"wrt", "wrf", "er", "ett", "rftt"};

            var result = AlienOrder(words);
            //should be "wertf"


            Console.WriteLine(result);

        }
    }
}