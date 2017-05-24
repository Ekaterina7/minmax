using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\Sredniy.txt");
            var dictionary = new Dictionary<string, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!dictionary.ContainsKey(Convert.ToString(text[i])))
                {
                    dictionary[Convert.ToString(text[i])] = 1;
                }
                else dictionary[Convert.ToString(text[i])]++;
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
           
        }
    }
}
