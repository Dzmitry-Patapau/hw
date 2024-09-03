using Microsoft.VisualBasic;
using System.Text;

namespace task1
{
    internal class Program
    {
        private const string Path = "anketa.txt";
        static void Main(string[] args)
        {
            string path = "anketa.txt";
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine();
                Console.WriteLine("Введите:\n" +
                    "1 - для вывода данных\n" +
                    "2 - для ввода данных \n" +
                    "любую другую клавишу - для выхода из программы");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                char symbol = keyInfo.KeyChar;
                Console.WriteLine();

                switch (symbol)
                {
                    case '1':
                        ReadData();
                        break;
                    case '2':
                        WriteData();
                        break;
                    default:
                        isRunning = false;
                        Console.WriteLine("\nВыход из программы...");
                        break;
                }
            }
            Console.ReadKey();
        }




        /// <summary>
        /// Метод для записи данных в анкету
        /// </summary>

        static void WriteData()
        {

            int lastId = ReturnLastId();

            DateTime currentTime = DateTime.Now;

            Console.WriteLine("Введите Ф. И. О.: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите дату рождения (дд.мм.гггг): ");
            string birthDate = Console.ReadLine();

            Console.Write("Введите место рождения: ");
            string birthPlace = Console.ReadLine();

            string newRecord = $"{lastId}#{currentTime}#{name}#{age}#{height}#{birthDate}#{birthPlace}";

            using (StreamWriter sw = new StreamWriter(Path, true))
            {
                sw.WriteLine(newRecord);
            }

            Console.WriteLine("Запись добавлена успешно.");


        }



        /// <summary>
        /// Метод для вывода данных в консоль
        /// </summary>

        static void ReadData()
        {
            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    string line = null;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        string[] temp = line.Split("#");
                        foreach (var item in temp)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();

                    }
                }
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }
        }


        /// <summary>
        /// Метод определяющий ID след. записи
        /// </summary>
        /// <returns>ID для текущей записи</returns>
        static int ReturnLastId()
        {
            int id = 1;
            string lastLine = null;
            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while (!sr.EndOfStream)
                    {
                        lastLine = sr.ReadLine();
                    }
                }
                if (!string.IsNullOrEmpty(lastLine))
                {
                    string[] lineSplit = lastLine.Split("#");
                    id = Convert.ToInt32(lineSplit[0]) + 1;
                }
            }
            return id;
        }
    }
}