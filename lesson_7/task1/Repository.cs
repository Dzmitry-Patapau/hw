using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Repository
    {
        private const string Path = "anketa.txt";

        #region Методы класса репозитория
        /// <summary>
        /// Возвращает массив всех работников
        /// </summary>
        /// <returns>Массив работников. Или пустой массив, если файл не существует или он пуст.</returns>
        public Worker[] GetAllWorkers()
        {
            List<Worker> workers = new List<Worker>();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var data = line.Split('#');
                    workers.Add(new Worker(
                        int.Parse(data[0]),
                        DateTime.Parse(data[1]),
                        data[2],
                        int.Parse(data[3]),
                        int.Parse(data[4]),
                        DateTime.Parse(data[5]),
                        data[6]
                    ));
                }
            }
            return workers.ToArray();
        }

        /// <summary>
        /// Возвращает работника по id
        /// </summary>
        /// <param name="id">ИД работника</param>
        /// <returns>Работник. Или default если не найдено совпадений</returns>
        public Worker GetWorkerByID(int id)
        {
            Worker worker = GetAllWorkers().FirstOrDefault(w => w.Id == id);
            return worker;
        }

        /// <summary>
        /// Удаляет работника по id
        /// </summary>
        /// <param name="id">ИД работника</param>
        public void DeleteWorker(int id)
        {
            var tempWorkers = GetAllWorkers().Where(w => w.Id != id);
            using (StreamWriter sw = new StreamWriter(Path, false))
            {
                foreach (var w in tempWorkers)
                {
                    var tempString = $"{w.Id}#{w.DateAddWorker}#{w.Name}#{w.Age}#{w.Height}#{w.BirthDate}#{w.BirthPlace}";
                    sw.WriteLine(tempString);
                }
            }
        }

        /// <summary>
        /// Добавляет работника
        /// </summary>
        /// <param name="worker">Работник</param>
        public void AddWorker(Worker worker)
        {
            worker.Id = ReturnLastId();
            var tempString = $"{worker.Id}#{worker.DateAddWorker}#{worker.Name}#{worker.Age}#{worker.Height}#{worker.BirthDate}#{worker.BirthPlace}";
            using (StreamWriter sw = new StreamWriter(Path, true))
            {
                sw.WriteLine(tempString);
            }
        }



        /// <summary>
        /// Редактирование работника
        /// </summary>
        /// <param name="worker">Работник</param>
        public void EditWorker(Worker newWorker)
        {
            var workers = GetAllWorkers();
            int index = Array.FindIndex(workers, w => w.Id == newWorker.Id);
            workers[index] = newWorker;
            using (StreamWriter sw = new StreamWriter(Path, false))
            {
                foreach (var w in workers)
                {
                    var tempString = $"{w.Id}#{w.DateAddWorker}#{w.Name}#{w.Age}#{w.Height}#{w.BirthDate}#{w.BirthPlace}";
                    sw.WriteLine(tempString);
                }
                
            }
        }



        /// <summary>
        /// Возвращает массив работников по диапазону дат ввода данных.
        /// </summary>
        /// <param name="startDate">Дата начала периода</param>
        /// <param name="endDate">Дата конца периода</param>
        /// <returns>Массив работников по периоду</returns>
        public Worker[] GetWorkersBetweenDates(DateTime startDate, DateTime endDate)
        {
            var workers = GetAllWorkers().Where(w => w.DateAddWorker >= startDate && w.DateAddWorker <= endDate).ToArray();
            return workers;
        }

        /// <summary>
        /// Генерирует записи
        /// </summary>
        /// <param name="countRecords">Количество записей которое необходимо сгенерировать</param>
        public void GenerateRecords(int countRecords) 
        { 
            int lastId = ReturnLastId();
            var records = new List<Worker>();
            for (int i = lastId; i < lastId + countRecords; i++)
            {
                var worker = new Worker(
                    i,
                    DateTime.Now,
                    "Имя " + i,
                    i,
                    i,
                    DateTime.Now,
                    "Место рождения " + i
                );
                records.Add(worker);
            }
            using (StreamWriter sw = new StreamWriter(Path, true))
            {
                foreach (var w in records)
                {
                    var tempString = $"{w.Id}#{w.DateAddWorker}#{w.Name}#{w.Age}#{w.Height}#{w.BirthDate}#{w.BirthPlace}";
                    sw.WriteLine(tempString);
                }
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



        #endregion
    }

}