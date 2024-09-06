namespace task1
{
    internal class Program
    {

        //private const string Path = "anketa.txt";

        static void Main(string[] args)
        {
            Repository repository = new Repository();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine();
                Console.WriteLine("Введите:\n" +
                    "1 - для вывода всех данных\n" +
                    "2 - для вывода одной записи \n" +
                    "3 - создание записи \n" +
                    "4 - удаление записи \n" +
                    "5 - загрузка данных из веденного диапазона (по дате записи)\n" +
                    "6 - генерация указанного количества записей \n" +
                    "7 - вывести сортированные данные по ФИО \n" +
                    "8 - вывести сортированные данные по возрасту \n" +
                    "9 - редактирование записи по id \n" +
                    "любую другую клавишу - для выхода из программы");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                char symbol = keyInfo.KeyChar;
                Console.WriteLine();

                switch (symbol)
                {
                    case '1':
                        ReadRecords(repository.GetAllWorkers());
                        break;
                    case '2':
                        Console.WriteLine("Введите id работника");
                        int id = int.Parse(Console.ReadLine());
                        var worker = repository.GetWorkerByID(id);
                        if (worker.Equals(default(Worker)))
                        {
                            Console.WriteLine("Нет такого пользователя");
                        }
                        else
                        {
                            ReadRecords(worker);
                        }
                        break;
                    case '3':
                        repository.AddWorker(WriteData());
                        break;
                    case '4':
                        Console.WriteLine("Введите id для удаления из списка");
                        repository.DeleteWorker(int.Parse(Console.ReadLine()));
                        break;
                    case '5':
                        Console.WriteLine("Введите 1 дату внесения записи c (дд.мм.гггг)");
                        DateTime firstDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 дату внесения записи до (дд.мм.гггг)");
                        DateTime secondDate = DateTime.Parse(Console.ReadLine());
                        ReadRecords(repository.GetWorkersBetweenDates(firstDate, secondDate));
                        break;
                    case '6':
                        Console.WriteLine("Введите количестко записей которое необходимо сгенерировать.");
                        repository.GenerateRecords(int.Parse(Console.ReadLine()));
                        break;
                    case '7':
                        ReadRecords(repository.GetAllWorkers().OrderBy(w => w.Name).ToArray());
                        break;
                    case '8':
                        ReadRecords(repository.GetAllWorkers().OrderBy(w => w.Age).ToArray());
                        break;
                    case '9':
                        Console.WriteLine("Введите id работника");
                        id = int.Parse(Console.ReadLine());
                        worker = repository.GetWorkerByID(id);
                        if (worker.Equals(default(Worker)))
                        {
                            Console.WriteLine("Нет такого пользователя");
                        }
                        else
                        {
                            var newWorkerData = WriteData();
                            newWorkerData.Id = id;
                            repository.EditWorker(newWorkerData);
                        }
                        break;
                    default:
                        isRunning = false;
                        Console.WriteLine("\nВыход из программы...");
                        break;
                }
            }
            Console.ReadKey();
        }


        #region Ввод данных
        /// <summary>
        /// Метод для записи данных в анкету
        /// </summary>

        static Worker WriteData()
        {

            DateTime currentTime = DateTime.Now;

            Console.WriteLine("Введите Ф. И. О.: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите дату рождения (дд.мм.гггг): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите место рождения: ");
            string birthPlace = Console.ReadLine();

            Worker worker = new Worker(0, currentTime, name, age, height, birthDate, birthPlace);
            return worker;
        }
        #endregion



        #region Вывод данных в консоль
        /// <summary>
        /// Метод для вывода данных в консоль
        /// </summary>

        public static void ReadRecords(Worker[] workers)
        {
            HeaderReadWorker();
            foreach (Worker worker in workers)
            {
                Console.Write(worker.ToString());
                Console.WriteLine();
            }
        }

        public static void ReadRecords(Worker worker)
        {
            HeaderReadWorker();
            Console.Write(worker.ToString());
            Console.WriteLine();
        }

        static void HeaderReadWorker()
        {
            string header = String.Format("{0,-5} {1,-20} {2,-15} {3,-7} {4,-7} {5,-12} {6,-15}",
                                              "ID", "DateAddWorker", "Name", "Age", "Height", "Birth Date", "BirthPlace");
            Console.WriteLine(header);
            Console.WriteLine(new string('-', header.Length));
        }

        #endregion


    }
}