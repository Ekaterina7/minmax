using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatime
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\катя.txt");


            string[] textstolb = text.Split(';');
            DateTime min = DateTime.MaxValue;
            int it = 0;
            for (int i = 0; i < textstolb.Length - 1; i += 6)
            {

                DateTime tmp = Convert.ToDateTime(Convert.ToString(textstolb[i + 4]));
                if (tmp < min)
                {
                    min = tmp;
                    it = i;
                }



            }
            Console.WriteLine("Самый старший "+ textstolb[it] + " " + textstolb[it + 1] + " " + textstolb[it + 2] + " " + textstolb[it + 3] + " " + textstolb[it + 4] + " " + textstolb[it + 5]);



        }
    }
}
