using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mas_task_11
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = System.IO.File.ReadAllLines(@"C:\Users\student\Desktop\мас.txt");
            System.IO.File.Delete(@"C:\Users\student\Desktop\masresult.txt");
            string[][] textmas = new string[text.Length][];
            for (int i = 0; i < text.Length; i++)
                textmas[i] = new string[4];
            for (int i = 0; i < textmas[0].Length-1; i++)
                textmas[i] = text[i].Split(';');
            for (int i = 0; i < textmas.Length; i++)
            {
                for (int j = 0; j < textmas[i].Length; j++)
                {
                    Console.Write(textmas[i][j] + "\t");
                    System.IO.File.AppendAllText(@"C:\Users\student\Desktop\masresult.txt", textmas[i][j] + "\t");
                }
                System.IO.File.AppendAllText(@"C:\Users\student\Desktop\masresult.txt","\r\n");
                Console.WriteLine();
            }
            ToGetCountEvenNumber(textmas);
            ToGetCountOddNumber(textmas);
            
            System.IO.File.AppendAllText(@"C:\Users\student\Desktop\masresult.txt","even=  "+ ToGetCountEvenNumber(textmas)
             + "\r\n" + "odd=  " + ToGetCountOddNumber(textmas));
            
        }
        static string ToGetCountEvenNumber(string[][] textmas)
        {
            int even = 0;
            for (int i = 0; i < textmas.Length; i++)
            {
                for (int j = 0; j < textmas[i].Length; j++)
                {
                    if (Convert.ToInt32(textmas[i][j]) % 2 == 0)
                    {
                        even++;
                    }
                }
            }
            return Convert.ToString(even);
        }
        static string ToGetCountOddNumber(string[][] textmas)
        {
            int odd = 0;
            for (int i = 0; i < textmas.Length; i++)
            {
                for (int j = 0; j < textmas[i].Length; j++)
                {
                    if (Convert.ToInt32(textmas[i][j]) % 2 != 0)
                    {
                        odd++;
                    }
                }
            }
            return Convert.ToString(odd);
        }

    }
}
