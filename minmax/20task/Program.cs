using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20task
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\катя.txt");
            
            
            string[] textstolb = text.Split(new char[] { ';' });
            for (int i = 0; i < textstolb.Length-1; i+=6)
            {
                string[] ss = textstolb[i + 4].Split(new char[] { '.' });
                
                if (textstolb[i+2]=="ж")
                {
                    if (Convert.ToInt32(ss[2])<=1957)
                    {
                        Console.WriteLine(textstolb[i]+" "+textstolb[i+1]+ " " + textstolb[i+2]+ " " + textstolb[i+3]+ " " + textstolb[i+4]+ " " + textstolb[i+5]);
                    }
                }
                else
                {
                    if (Convert.ToInt32(ss[2]) <= 1952)
                    {
                        Console.WriteLine(textstolb[i] + " " + textstolb[i + 1] + " " + textstolb[i + 2] + " " + textstolb[i + 3] + " " + textstolb[i + 4] + " " + textstolb[i + 5]);
                    }  
                }
            //    if (textstolb[i+3]=="ж")
            //    {
            //        //string[] ss= textstolb[i+7].Split(new char[] { '.' });
            //        //if (Convert.ToInt32(ss[3])<=1957)
            //        //{
            //        //    Console.WriteLine(textstolb[i]);
            //        //}
            //    }
            }



           

                

                


        }
    }
}
