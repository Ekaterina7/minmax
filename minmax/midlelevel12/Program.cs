using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midlelevel12
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\средний.txt");
            Console.WriteLine(text);
            string number = "1234567890";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (text[i]==number[j])
                    {
                        Console.WriteLine(text[i] + " -цифра");
                    }
                }
            }
            string tmp = "";
            tmp += text[0];
            tmp += text[1];
           
            int tmpint = Convert.ToInt32(tmp);
            if (tmpint % 2 == 0)
            {
                Console.WriteLine(tmpint + " - четное");
            }
            else Console.WriteLine(tmpint + " - нечетное");
        }
    }
}
