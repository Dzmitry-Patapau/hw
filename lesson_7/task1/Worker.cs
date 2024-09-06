using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal struct Worker
    {
        #region Свойства
        public int Id { get; set; }
        public DateTime DateAddWorker { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        #endregion

        #region Конструктор
        /// <summary>
        /// Конструктор работника
        /// </summary>
        /// <param name="id">Идентификатор работника</param>
        /// <param name="name">Имя работника</param>
        /// <param name="age">Возраст работника</param>
        /// <param name="heigth">Рост работника</param>
        /// <param name="dateBirth">Дата рождения работника</param>
        /// <param name="placeBirth">Место рождения работника</param>
        public Worker(int id,DateTime dateTimeAddWorker,string name,int age,int heigth,DateTime dateBirth,string placeBirth)
        {
            Id = id;
            DateAddWorker = dateTimeAddWorker;
            Name = name;
            Age = age;
            Height = heigth;
            BirthDate = dateBirth;
            BirthPlace = placeBirth;
        }
        #endregion

        public override string ToString()
        {
            string temp = String.Format("{0,-5} {1,-20} {2,-15} {3,-7} {4,-7} {5,-12} {6,-15}",
                                            Id,
                                            DateAddWorker,
                                            Name,
                                            Age,
                                            Height,
                                            BirthDate.ToShortDateString(),
                                            BirthPlace);
            return temp;
        }
        
    }
}
