using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\катя.txt");
            string[] textstolb = text.Split(new char[] { ';' });
            for (int i = 0; i < textstolb.Length-1; i+=6)
            {
                if (Convert.ToInt32(textstolb[i+5])>=50)
                {
                    Console.WriteLine(textstolb[i] + " " + textstolb[i + 1] + " " + textstolb[i + 2] + " " + textstolb[i + 3] + " " + textstolb[i + 4] + " " + textstolb[i + 5]);
                }
            }
        }
    }
}
