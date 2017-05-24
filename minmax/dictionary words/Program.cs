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

        }
    }
}
