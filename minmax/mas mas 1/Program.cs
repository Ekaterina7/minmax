using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\student\Desktop\мас.txt");
            string[][] mastext = new string[3][];
            for (int i = 0; i < mastext.Length; i++)
            {
                mastext[i] = new string[4];
                mastext[i] = text[i].Split(';');

            }

            for (int i = 0; i < mastext.Length; i++)
            {
                for (int j = 0; j < mastext[i].Length; j++)
                {

                    Console.Write(mastext[i][j] + "\t");
                    System.IO.File.AppendAllText(@"C:\Users\student\Desktop\result.txt", mastext[i][j] + "\t");
                }
                System.IO.File.AppendAllText(@"C:\Users\student\Desktop\result.txt", "\r\n");
                Console.WriteLine();
            }


            int min = Convert.ToInt32(mastext[2][0]);
            int indexmin = 0;
            for (int i = 0; i < mastext[2].Length; i++)
            {
                int a = ToFindIndexMin(mastext, min, indexmin);
                string c = mastext[2][i];
                mastext[2][i] = mastext[2][a];
                mastext[2][a] = c;
            }
            for (int i = 0; i < mastext.Length; i++)
            {
                for (int j = 0; j < mastext[i].Length; j++)
                {
                    System.IO.File.AppendAllText(@"C:\Users\student\Desktop\result.txt", mastext[i][j] + "\t");
                    Console.Write(mastext[i][j] + "\t");
                }
                System.IO.File.AppendAllText(@"C:\Users\student\Desktop\result.txt", "\r\n");
                Console.WriteLine();
            }

        }
        static int ToFindIndexMin(string[][] mastext, int min, int indexmin)
        {
            for (int i = 0; i < mastext[0].Length; i++)
            {
                if (Convert.ToInt32(mastext[2][i]) < min)
                {
                    min = Convert.ToInt32(mastext[2][i]);
                    indexmin = i;

                }
            }
            return indexmin;

        }
    }
}

