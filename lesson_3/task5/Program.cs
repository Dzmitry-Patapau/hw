namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное возможное число");

            int maxRange = Convert.ToInt32 (Console.ReadLine());

            Random random = new Random();

            int randomNumber = random.Next (0, maxRange + 1);

            int count = 0;

            while (true)
            {
                count++;

                Console.WriteLine("Введите число.");

                var userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine($"Число было равно {randomNumber}. Количество попыток {--count}");
                    break;
                }

                int userInputNumber = int.Parse(userInput);


                if (userInputNumber == randomNumber) 
                {
                    Console.WriteLine($"Вы угадали. Число было равно {randomNumber}. Количество попыток {count}");
                    break;
                }
                else
                {
                    if (userInputNumber > randomNumber)
                        Console.WriteLine("Загаданное число меньше загаданного.");
                    else
                        Console.WriteLine("Загаданное число больше загаданного.");
                }
            }
            Console.WriteLine("Игра завершена");
            Console.ReadKey();
        }
    }
}