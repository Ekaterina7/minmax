using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\Sredniy.txt");
            string[] textmas = text.Split(' ', '-', '.',',');

            var dictionary = new Dictionary<string, int>();
            for (int i = 0; i < textmas.Length; i++)
            {
                if(textmas[i]!="")
                if (!dictionary.ContainsKey(Convert.ToString(textmas[i])))
                {
                    dictionary[Convert.ToString(textmas[i])] = 1;
                }
                else dictionary[Convert.ToString(textmas[i])]++;
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Сортировка по значению:");
            Console.WriteLine();
            foreach (var pair in dictionary.OrderBy(pair => pair.Value))
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Сортировка по алфавиту ");

           dictionary = dictionary.OrderBy(k => k.Key).ToDictionary(process => process.Key, process => process.Value);

            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0}", pair.Key);
            }
        }
    }
}
