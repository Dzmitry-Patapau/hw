using System.Xml.Linq;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<XElement> contacts = new List<XElement>();

            while (true)
            {
                Console.Write("Введите ФИО: ");
                string fio = Console.ReadLine();

                Console.Write("Введите улицу: ");
                string street = Console.ReadLine();

                Console.Write("Введите номер дома: ");
                string houseNumber = Console.ReadLine();

                Console.Write("Введите номер квартиры: ");
                string flatNumber = Console.ReadLine();

                Console.Write("Введите мобильный телефон: ");
                string mobilePhone = Console.ReadLine();

                Console.Write("Введите домашний телефон: ");
                string flatPhone = Console.ReadLine();

                XElement person = new XElement("Person",
                    new XAttribute("name", fio),
                    new XElement("Address",
                        new XElement("Street", street),
                        new XElement("HouseNumber", houseNumber),
                        new XElement("FlatNumber", flatNumber)
                    ),
                    new XElement("Phones",
                        new XElement("MobilePhone", mobilePhone),
                        new XElement("FlatPhone", flatPhone)
                    )
                );

                contacts.Add(person);

                Console.WriteLine("Хотите добавить еще контакт? (д/н): ");

                var userInput = Console.ReadLine();

                if (userInput.ToLower() != "д")
                    break;
            }

            XElement root = new XElement("Contacts", contacts);

            root.Save("contacts.xml");
        }
    }
}