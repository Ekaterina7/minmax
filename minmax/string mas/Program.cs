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
            string[] textmas = File.ReadAllLines(@"C:\Users\Екатерина\Desktop\алфавит.txt");
           
            for (int i = 0; i < textmas.Length; i++)
            {
                Console.WriteLine(textmas[i]);
            }
            Console.WriteLine();
            int count = 0;
            while (count < 3)
            {
                for (int i = 0; i < textmas.Length - 1; i++)
                {
                    string a = textmas[i];
                    string b = textmas[i + 1];
                    if (a.Length == b.Length)
                    {
                        for (int j = 0; j < a.Length; j++)
                        {
                            if (a[j] > b[j])
                            {
                                string tmp = "";
                                tmp = textmas[i];
                                textmas[i] = textmas[i + 1];
                                textmas[i + 1] = tmp;
                            }
                            else if (a[j] < b[j])
                            {
                                textmas[i + 1] = textmas[i + 1];
                                textmas[i] = textmas[i];
                                break;
                            }
                            else
                                continue;
                        }

                    }
                    else if (a.Length > b.Length)
                    {
                        for (int J = 0; J < b.Length; J++)
                        {
                            if (a[J] > b[J])
                            {
                                string tmp = "";
                                tmp = textmas[i];
                                textmas[i] = textmas[i + 1];
                                textmas[i + 1] = tmp;
                                break;
                            }
                            else if (a[J] < b[J])
                            {
                                textmas[i + 1] = textmas[i + 1];
                                textmas[i] = textmas[i];
                                break;
                            }
                            else
                                continue;
                        }
                    }
                    else
                    {
                        for (int J = 0; J < a.Length; J++)
                        {
                            if (a[J] > b[J])
                            {
                                string tmp = "";
                                tmp = textmas[i];
                                textmas[i] = textmas[i + 1];
                                textmas[i + 1] = tmp;
                                break;
                            }
                            else if (a[J] < b[J])
                            {


                                textmas[i + 1] = textmas[i + 1];
                                textmas[i] = textmas[i];
                                break;
                            }
                            else
                                continue;
                        }
                    }
                }
                count++;
            }
                
            
            for (int i = 0; i < textmas.Length; i++)
            {
                Console.WriteLine(textmas[i]);
            }
            Console.WriteLine();



        }
       





    }
}
