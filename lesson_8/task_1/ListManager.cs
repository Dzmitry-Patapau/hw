using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class ListManager
    {
        public static void NumberGenerator(List<int> list)
        {
            Random random = new Random();
            for(int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0,101));
            }
        }

        public static void OutputList(List<int> list)
        {
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }

        public static void DeleteNumbers(List<int> list)
        {
            list.RemoveAll(x=> x > 25 && x < 50);        
        }

        public static void frequencyDictionary(List<int> list)
        {
            Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();
            foreach(int i in list)
            {
                if(frequencyDictionary.ContainsKey(i))
                {
                    frequencyDictionary[i]++;
                }
                else
                {
                    frequencyDictionary.Add(i, 1);
                }
            }
            foreach(KeyValuePair<int, int> pair in frequencyDictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            Console.WriteLine("");
        }
    }
}
