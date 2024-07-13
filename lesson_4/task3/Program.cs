namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool[,] arrayLife = new bool[20, 20];
            bool[,] nextArray = new bool[20, 20];
            bool isRunning = true;
            int lifeEpoch = 1;



            //Заполнение массива
            for (int x = 0; x < arrayLife.GetLength(0); x++)
            {
                for (int y = 0; y < arrayLife.GetLength(0); y++)
                {
                    arrayLife[x, y] = random.Next(2) == 0;
                }
            }

            //Вывод массива 1-ая эпоха жизни
            Console.WriteLine($"Эпоха жизни {lifeEpoch}");
            for (int i = 0; i < arrayLife.GetLength(0); i++)
            {
                for (int j = 0; j < arrayLife.GetLength(0); j++)
                {
                    Console.Write(arrayLife[i, j] ? "b " : "  ");
                }
                Console.WriteLine();
            }


            //Проверка правил и вывод на экран(1 - больше 3 бактерий вокруг погибает; 2 - меньше 3 бактерий вокруг погибает) Эпоха длится 10 сек.


            while (isRunning)
            {
                lifeEpoch++;
                int changeCount = 0;
                int countVirus = 0;

                Array.Copy(arrayLife, nextArray, arrayLife.Length);

                for (int i = 0; i < arrayLife.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayLife.GetLength(1); j++)
                    {
                        int countVirusAround = 0;

                        if (arrayLife[i, j])
                        {
                            countVirus++;
                            for (int x = -1; x < 2; x++)
                            {
                                for (int y = -1; y < 2; y++)
                                {
                                    if ((i + x >= 0 && i + x <= arrayLife.GetLength(0) - 1) && (j + y >= 0 && j + y <= arrayLife.GetLength(1) - 1) && !(x == 0 && y == 0) && arrayLife[i + x, j + y])
                                    {
                                        countVirusAround++;
                                    }
                                }
                            }
                            //Логи, что будет происходить с бактерией
                            //Console.WriteLine($"Вокруг бактерии [{i},{j}] - {countVirusAround} бактерий. {(countVirusAround != 3 ? "Бактерия умрет!" : "Бактерия будет жить!")} ");
                            if (countVirusAround != 3)
                            {
                                nextArray[i, j] = false;
                                changeCount++;
                            }
                        }
                    }
                }

                if (changeCount != 0)
                {
                    Console.WriteLine($"Всего количество бактерий {countVirus} на текущей эпохе жизни.");
                    Console.WriteLine($"Количество бактерий которые умрут {changeCount} к концу текущей эпохи.");
                    Thread.Sleep(10000);
                    Console.Clear();
                    Console.WriteLine($"Эпоха жизни {lifeEpoch}");
                    for (int i = 0; i < nextArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < nextArray.GetLength(0); j++)
                        {
                            Console.Write(nextArray[i, j] ? "b " : "  ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                    isRunning = false;

                Array.Copy(nextArray, arrayLife, nextArray.Length);

            }

            Console.WriteLine("Все бактерии погибли!");

            Console.ReadKey();
        }
    }
}