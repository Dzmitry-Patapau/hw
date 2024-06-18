namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для определения являются ли введенное число простыми. Введите число");

            bool isNotPrime = false;

            while (true)
            { 
                int divider = 1;

                var userInput = Console.ReadLine();

                if(userInput.ToUpper() == "Q")
                {
                    break;
                }

                int number = int.Parse(userInput); 

                if (number < 2)
                {
                    Console.WriteLine("Число не является простым(т.к. меньше 2).\nВведите новое число или введите Q для выхода из программы.");
                }
                else
                {
                    while (divider <= number - 1)
                    {
                        if (number % divider == 0 && divider != 1)
                        {
                            isNotPrime = true;
                            break;
                        }
                        divider++;
                    }

                    Console.WriteLine((isNotPrime)
                        ? "Число не является простым.\nВведите новое число или введите Q для выхода из программы."
                        : "Число является простым.\nВведите новое число или введите Q для выхода из программы.");

                    isNotPrime = false;
                }

            }

        }
    }
}