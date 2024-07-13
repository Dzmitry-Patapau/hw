namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк в матрице");
            int xArray = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите кол-во столбцов в матрице");
            int yArray = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,,] threeDimensionalArray = new int[3, xArray, yArray];

            Random randomize = new Random();

            for (int x = 0; x < xArray; x++)
            {
                for (int y = 0; y < yArray; y++)
                {
                    threeDimensionalArray[0, x, y] = randomize.Next(10);
                    threeDimensionalArray[1, x, y] = randomize.Next(10);
                    threeDimensionalArray[2, x, y] = threeDimensionalArray[0, x, y] + threeDimensionalArray[1, x, y];
                }
            }

            for (int z = 0; z < 3; z++)
            {
                Console.WriteLine((z<2)?$"Матрица {z + 1}\n":"Суммарная матрица\n");
                for (int x = 0; x < xArray; x++)
                {
                    for (int y = 0; y < yArray; y++)
                    {
                        Console.Write($"{threeDimensionalArray[z,x,y],2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}