using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullornotnull
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] www = new string[2];
            www[0] = "a b C";
            www[1] = "d Q e";
            Console.WriteLine(DecodeMessage(www));
            
           
        }
        private static string DecodeMessage(string[] lines)
        {
            

            List<string> words = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] a = lines[i].Split(' ');
                for (int j = 0; j < a.Length; j++) {
                    if (string.IsNullOrEmpty(a[i])) continue;
                    if (Char.IsUpper(a[j].ElementAt(0)))
                    {
                        words.Add(a[j]);
                    }
                }
            }
            words.Reverse();
            return string.Join(" ", words.ToArray());
        }
    }
}
