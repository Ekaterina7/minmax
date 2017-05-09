using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midlelevelstask21
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\21средний.txt");
            string[] textstolb = text.Split(';');
            DateTime min = DateTime.MinValue;
           
          
            for (int i = 0; i < textstolb.Length-1; i++)
            {
                if (Convert.ToDateTime(textstolb[i])>min)
                {
                    min = Convert.ToDateTime(textstolb[i]);
                }
            }
            Console.WriteLine(min+"- самая поздняя дата");
        }
    }
}
