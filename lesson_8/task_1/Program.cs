using System.Security.Cryptography;

namespace task_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            ListManager.NumberGenerator(list);

            ListManager.OutputList(list);

            Console.WriteLine($"List.count = {list.Count}");

            ListManager.DeleteNumbers(list);

            ListManager.OutputList(list);

            Console.WriteLine($"List.count = {list.Count}");

            Console.ReadKey();
        }

    }
}