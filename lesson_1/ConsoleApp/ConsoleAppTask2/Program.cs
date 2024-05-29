namespace ConsoleAppTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Console.Write("World");
            Console.Write("!!!");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}