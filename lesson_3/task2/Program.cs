namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество карт на руках.");
            int numberCards = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberCards; i++)
            {
                Console.WriteLine($"Введите номинал карты");
                var nominal = Console.ReadLine();
                switch (nominal.ToUpper())
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        sum += int.Parse(nominal);
                        break;
                }
            }
            Console.WriteLine($"Сумма карт на руках = {sum}");
            Console.ReadKey();
        }
    }
}