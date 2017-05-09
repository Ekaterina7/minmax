using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midlelevel20
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\средний.txt");
            Console.WriteLine(text);
            string textnew = "";
            int dlina = text.Length;
            while(text.Length!=0)
            {
                textnew = textnew+ text.Remove(0, dlina-1);
                dlina--;
                text = text.Remove(text.Length-1);
                
            }
            Console.WriteLine(textnew);
           
        }
    }
}
