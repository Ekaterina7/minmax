using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int[,] mas = new int[3, 4];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = gen.Next(1, 10);
                    Console.Write(mas[i, j]+"\t");
                }
                Console.WriteLine();
            }

            //поиск минимума в 1 строке
          int  min1 = mas[0,0];
            int indexmin1 = 0;
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (mas[0,j]<min1)
                {
                    min1 = mas[0, j];
                    indexmin1 = j;
                }
            }
            Console.WriteLine(min1 + " " + indexmin1);
            //поиск минимума во 2  строке
            int min3 = mas[0, 0];
            int indexmin3 = 0;
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (mas[2, j] < min3)
                {
                    min3 = mas[2, j];
                    indexmin3 = j;
                }
            }
            Console.WriteLine(min3 + " " + indexmin3);
            //замена
            int C = mas[0, indexmin1];
            mas[0, indexmin1] = mas[2, indexmin3];
            mas[2, indexmin3] = C;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
