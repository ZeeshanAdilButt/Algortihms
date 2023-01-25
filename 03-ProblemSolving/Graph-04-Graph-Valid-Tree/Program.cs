namespace Graph_04_Graph_Valid_Tree
{
    internal class Program
    {

        public static bool ValidTree(int n, int[][] edges)
        {
            List<int>[] graph = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }
            for (int i = 0; i < edges.Length; i++)
            {
                graph[edges[i][0]].Add(edges[i][1]);
                graph[edges[i][1]].Add(edges[i][0]);
            }
            bool[] visited = new bool[n];
            if (HasCycle(graph, visited, 0, -1))
            {
                return false;
            }
            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool HasCycle(List<int>[] graph, bool[] visited, int curr, int parent)
        {
            visited[curr] = true;
            foreach (int neighbor in graph[curr])
            {
                if (!visited[neighbor])
                {
                    if (HasCycle(graph, visited, neighbor, curr))
                    {
                        return true;
                    }
                }
                else if (neighbor != parent)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int n = 5;
            int[][] edges = new int[][] 
                        {
                            new int[] {0, 1},
                            new int[] {0, 2},
                            new int[] {0, 3},
                            new int[] {1, 4}
                        };


            var result = ValidTree(n, edges);

            //output should be true

            Console.WriteLine("is valid tree?!");
            Console.WriteLine(result);

        }
    }
}