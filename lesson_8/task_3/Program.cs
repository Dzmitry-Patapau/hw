namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();

            while (true)
            {
                Console.WriteLine("Введите число для добавления в коллекцию. Для выхода из программы введите пробел.");

                var userIntput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userIntput))
                    break;

                if(numbers.Add(int.Parse(userIntput)))
                {
                    Console.WriteLine($"Цифра {userIntput} добавлена в коллекцию");
                }
                else
                {
                    Console.WriteLine($"Цифра {userIntput} не добавлена в коллекцию");
                }
                Console.WriteLine();
            }
        }
    }
}