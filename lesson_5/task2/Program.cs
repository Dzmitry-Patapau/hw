using System.Text;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string inputUser = Console.ReadLine();
            Console.WriteLine(ReversWords(inputUser));
            Console.ReadKey();
        }


        /// <summary>
        /// Метод принимает строку и разделяет ее на слова
        /// </summary>
        /// <param name="inputUser">Строка</param>
        /// <returns></returns>
        static string[] SplitText(string inputUser)
        {
            string[] tempWords = inputUser.Split(' ');
            return tempWords;
        }



        /// <summary>
        /// Метод принимает строку и выводит в обратном порядке
        /// </summary>
        /// <param name="text">Строка</param>
        /// <returns></returns>
        static string ReversWords(string text)
        {
            string[] splitInputText = SplitText(text);
            StringBuilder sb = new StringBuilder();

            for (int i = splitInputText.Length - 1; i >= 0; i--)
            {
                sb.Append(splitInputText[i] + " ");
            }

            return sb.ToString();
        }






    }
}