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
            string text = System.IO.File.ReadAllText(@"C:\\Users\student\Desktop\катя.txt");
            
            
            string[] textstolb = text.Split(new char[] { ';' });
            for (int i = 0; i < textstolb.Length-1; i+=8)
            {
                string[] ss = textstolb[i + 5].Split(new char[] { '.' });
                
                if (textstolb[i+3]=="ж")
                {
                    if (Convert.ToInt32(ss[2])<=1957)
                    {
                        Console.WriteLine(textstolb[i]);
                    }
                }
                else
                {
                    if (Convert.ToInt32(ss[2]) <= 1952)
                    {
                        Console.WriteLine(textstolb[i]);
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
