namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minValue = int.MaxValue;

            Console.WriteLine("Введите кол-во элементов последовательности");

            int count = int.Parse(Console.ReadLine());

            if (count <= 0)
            {
                Console.WriteLine("Ошибка!Последовательность содержит меньше 1 элемента.");
            }
            else
            {
                while (count > 0)
                {
                    Console.WriteLine("Введите число:");

                    int value = int.Parse(Console.ReadLine());

                    if (value < minValue)
                    {
                        minValue = value;
                    }

                    count--;
                }

                Console.WriteLine($"Минимальное значение = {minValue}");
            }

            Console.ReadKey();

        }
    }
}