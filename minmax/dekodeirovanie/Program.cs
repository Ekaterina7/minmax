using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekodeirovanie
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\Канада.txt");
            char[] textchar = text.ToCharArray();
            Random gen = new Random();

            int[] element = new int[textchar.Length];

            for (int i = 0; i < textchar.Length; i++)
            {

                int rnd = gen.Next(1, 40);
                element[i] = rnd;
            }


            Kodir(textchar, element);
            for (int i = 0; i < textchar.Length; i++)
            {
                Console.Write((char)textchar[i] + " " + element[i] + "\t");

            }
            Console.WriteLine();
            DEKodir(textchar, element);
            for (int i = 0; i < textchar.Length; i++)
            {
                Console.Write((char)textchar[i] + " " + element[i] + "\t ");
            }





        }

        static void Kodir(char[] textchar, int[] element)
        {
            for (int i = 0; i < textchar.Length; i++)
            {
                textchar[i] = (char)(((int)textchar[i]) + element[i]);
            }


        }

        static void DEKodir(char[] textchar, int[] element)
        {
            for (int i = 0; i < textchar.Length; i++)
            {
                textchar[i] = (char)(((int)textchar[i]) - element[i]);
            }


        }
    }
}