namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк в матрице");
            int xArray = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите кол-во столбцов в матрице");
            int yArray = int.Parse(Console.ReadLine());

            int[,] array = new int[xArray,yArray];

            int sum = 0;

            Random randomize = new Random();

            for (int x = 0; x < xArray; x++)
            {
                for (int y = 0; y < yArray; y++)
                {
                    array[x,y] = randomize.Next(10);
                    sum += array[x,y];
                    Console.Write($"{array[x,y]} ");
                }
                Console.WriteLine(array.Length);
            }
            Console.WriteLine($"Сумма всех элементов массива равна {sum}");
            Console.ReadKey();
        }
    }
}