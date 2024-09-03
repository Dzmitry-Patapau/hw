using System.Text;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string[] words = SplitText(Console.ReadLine());
            PrintWords(words);
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

        //static string[] SplitText(string inputUser)
        //{
        //    string[] wordsTemp = new string[inputUser.Count(x=>x == ' ') + 1];
        //    int count = 0;
        //    StringBuilder sb = new StringBuilder();

        //    foreach (char letter in inputUser)
        //    {
        //        if (letter != ' ')
        //        {
        //            sb.Append(letter);
        //        }
        //        else
        //        {
        //            if (sb.Length > 0)
        //            {
        //                wordsTemp[count] = sb.ToString();
        //                sb.Clear();
        //                count++;
        //            }
        //        }

        //        if (sb.Length > 0)
        //        {
        //            wordsTemp[count] = sb.ToString();
        //        }
        //    }
        //    return wordsTemp;
        //}




        /// <summary>
        /// Метод выводит все слова переданного массива
        /// </summary>
        /// <param name="input">Массив слов</param>
        static void PrintWords(string[] input) 
        {
            foreach (string word in input)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    Console.WriteLine(word);
                }
            }
        }

    }
}