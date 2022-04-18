// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");

        Console.WriteLine(flowerbox(new List<int> { 3, 10, 3, 1, 2 }));
    }

    public static int flowerbox(List<int> list)
    {
        int a = 0;
        int b = 0;

        foreach (int val in list)
        {
            a = b;
            b = Math.Max(a + val, b);
        }
        return b;
    }

}