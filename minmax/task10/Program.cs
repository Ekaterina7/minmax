using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\катя.txt");

            double midzn, sum=0;
            string[] textstolb = text.Split(new char[] { ';' });
            for (int i = 0; i < textstolb.Length-1; i+=6)
            {
                sum = 0;
                string[] stolbball = new string[textstolb.Length];
                
                stolbball = textstolb[i+5].Split(new char[] { '.' });
                for (int j = 0; j < stolbball.Length; j++)
                {
                    sum += Convert.ToInt32(stolbball[j]);
                }
                midzn = sum / stolbball.Length;
                
                if (midzn>=4)
                {
                    Console.WriteLine(textstolb[i] + " " + textstolb[i + 1] + " " + textstolb[i + 2] + " " + textstolb[i + 3] + " " + textstolb[i + 4] + " " + textstolb[i + 5]);
                }

                

            }
        }
    }
}
