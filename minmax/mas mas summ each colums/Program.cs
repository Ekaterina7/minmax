using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mas_summ_each_colums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\Екатерина\Desktop\mas.txt");
            System.IO.File.Delete(@"C:\Users\Екатерина\Desktop\masresult.txt");
            string[][] textmas = new string[text.Length][];
            for (int i = 0; i < text.Length; i++)
                textmas[i] = new string[3];
            for (int i = 0; i < textmas[0].Length; i++)
                textmas[i] = text[i].Split(';');
            for (int i = 0; i < textmas.Length; i++)
            {
                for (int j = 0; j < textmas[i].Length; j++)
                {
                    Console.Write(textmas[i][j] + "\t");
                    System.IO.File.AppendAllText(@"C:\Users\Екатерина\Desktop\masresult.txt", textmas[i][j] + "\t");
                }
                System.IO.File.AppendAllText(@"C:\Users\Екатерина\Desktop\masresult.txt", "\r\n");
                Console.WriteLine();
            }
            
            for (int i = 0; i < textmas[0].Length; i++)
            {
                int summ = 0;
                for (int j = 0; j < textmas.Length; j++)
                {
                    summ += Convert.ToInt32(textmas[j][i]);
                }
                Console.WriteLine(" сумма столбца "+i+"= " +summ);
            }
        }
    }
}
