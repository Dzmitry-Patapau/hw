namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для определения четное оно или нет.");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Четное");
            else
                Console.WriteLine("Нечетное");
            Console.ReadKey();
        }
    }
}