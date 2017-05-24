using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_mas
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\string.txt");
            string[] textmas = text.Split(';');
            for (int i = 0; i < textmas.Length; i++)
            {
                Console.WriteLine(textmas[i]);
            }
            Console.WriteLine();
            //string[] tmp = new string[1];
            //tmp[0] = textmas[i];
            //textmas[i] = textmas[i + 1];
            //textmas[i + 1] = tmp[0];

            for (int i = 0; i < textmas.Length-1; i++)
            {
                string a = textmas[i];
                string b = textmas[i + 1];
                if (a.Length==b.Length)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[j]>b[j])
                        {
                            string[] tmp = new string[1];
                            tmp[0] = textmas[i];
                            textmas[i] = textmas[i + 1];
                            textmas[i + 1] = tmp[0];
                        }
                    }

                }
                else if (a.Length>b.Length)
                {
                    for (int J = 0; J < b.Length; J++)
                    {
                        if (a[J]>b[J])
                        {
                            string[] tmp = new string[1];
                            tmp[0] = textmas[i];
                            textmas[i] = textmas[i + 1];
                            textmas[i + 1] = tmp[0];
                            break;
                        }
                    }
                }
                else
                {
                    for (int J = 0; J < a.Length; J++)
                    {
                        if (a[J] > b[J])
                        {
                            string[] tmp = new string[1];
                            tmp[0] = textmas[i];
                            textmas[i] = textmas[i + 1];
                            textmas[i + 1] = tmp[0];
                            break;
                        }
                    }
                }
            }

                
            
            for (int i = 0; i < textmas.Length; i++)
            {
                Console.WriteLine(textmas[i]);
            }
            Console.WriteLine();



        }
       





    }
}
