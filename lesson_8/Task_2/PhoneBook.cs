using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class PhoneBook
    {
        static Dictionary<string, string> _phonebook = new Dictionary<string, string>();

        public static void InputPhone()
        {
            while (true)
            {
                Console.WriteLine("Введите номер телефона. Для выхода из ввода данных введите пробел.");

                var phoneNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(phoneNumber))
                    break;

                if (!_phonebook.ContainsKey(phoneNumber))
                {
                    Console.WriteLine("Введите фамилию владельца телефона.");

                    var ownerNumber = Console.ReadLine();

                    _phonebook.Add(phoneNumber, ownerNumber);
                }
                else
                {
                    Console.WriteLine("Номер телефона уже введен.");
                }
                Console.WriteLine();
            }
        }

        public static void SearchPhone()
        {
            while (true)
            {
                Console.WriteLine("Введите номер телефона для поиска владельца. Для выхода из поиска введите пробел.");

                var phoneNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(phoneNumber))
                    break;

                if (_phonebook.TryGetValue(phoneNumber, out string OwnerNumber))
                {
                    Console.WriteLine($"Владелец номера - {OwnerNumber}");
                }
                else
                {
                    Console.WriteLine("Номер не найден!");
                }
                Console.WriteLine();
            }
        }
    }
}
