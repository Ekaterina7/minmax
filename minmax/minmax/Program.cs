
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\катя.txt");
            
           

            

            string[] textMass = text.Split(new char[]{' ',';', '-','_','@','>','<','.'});
           





            Console.WriteLine("Количество слов: " + textMass.Length);
            System.IO.File.WriteAllText(@"C:\Users\student\Desktop\WriteText.txt", "Количество слов:" + textMass.Length);

            Console.WriteLine("minimum lenght word = "+ MinimumWordInText(textMass));
            Console.WriteLine("maximum lenght word = " + MaximumWordInText(textMass));

            string[] mintext = new string[textMass.Length];
            string minwords = "";
            string maxwords = "";


            for (int i = 0; i < textMass.Length; i++)
            {
                if (textMass[i].Length==MinimumWordInText(textMass))
                {
                    
                    minwords += textMass[i];
                }
                
            }
            Console.WriteLine("Counter minwords = "+minwords.Length);


            for (int i = 0; i < textMass.Length; i++)
            {
                if (textMass[i].Length == MaximumWordInText(textMass))
                {

                    maxwords += textMass[i]+" ";
                }

            }
            string[] maxWords = maxwords.Split(new char[] {' ' });

            Console.WriteLine("Counter maxwords = " + (maxWords.Length-1));
            Console.WriteLine("minwords = " + minwords + "\r\n" + "maxwords = " + maxwords);



            Console.WriteLine("Кол-во слов в тексте = " + (textMass.Length));
          

            //Console.WriteLine("Количество буквы " + Counter(text, "а"));
            //double count = Counter(text, "а");
            //double all = text.Length;

            //Console.WriteLine("Процентное соотношение буквы ко всем символам = " + ProcentSootnochenie(all, count));
            //Console.WriteLine();


           
            //System.IO.File.WriteAllText(@"C:\Users\student\Desktop\WriteText.txt", text + "\r\n" +
            //    "\r\n" + "Количество слов:" + textMass.Length + "\r\n"
            //    + "Процентное соотношение буквы ко всем символам = " +
            //    +ProcentSootnochenie(all, count) + "\r\n"
            //    + "Кол-во символов в тексте = " + text.Length + "\r\n" + "\r\n" +
            //    text.ToLower() + text.ToUpper());

        }

        static int MinimumWordInText(string[] textMass)
        {
            int minimum = textMass.Length;
            for (int i = 0; i < textMass.Length; i++)
            {
                if (minimum>textMass[i].Length)
                {
                    if (textMass[i].Trim()!="")
                    minimum = textMass[i].Length;
                }
                
            }
            return minimum;


        }
        static int MaximumWordInText(string[] textMass)
        {
            int maximum = 1;
            for (int i = 0; i < textMass.Length; i++)
            {
                if (maximum < textMass[i].Length)
                {
                    maximum = textMass[i].Length;
                }

            }
            return maximum;
        }

        
        


        static int Counter(string b, string a)
        {
            int count = 0;


            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == a[0])
                {
                    count++;
                }

            }
            return count;



        }

        static double ProcentSootnochenie(double all, double count)
        {
            return (count * 100) / all;

        }



    }
    
        
    
}
