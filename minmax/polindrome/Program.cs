using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\\Users\student\Desktop\катя.txt");
            string[] textMass = text.Split(new char[] { ' ', ';', '-', '_', '@', '>', '<', '.' });




            for (int i = 0; i < textMass.Length; i++)
            {
                int countpluking = 0;
                string start = "";
                string end = "";
                string endnaoborot = "";
                countpluking = (int)Math.Ceiling((double)textMass[i].Length / 2);
                if (textMass[i].Length>1)
                if ((textMass[i].Trim() != ""))
                {
                    start = textMass[i].Remove(countpluking);
                    if (textMass[i].Length % 2 == 0)
                    {
                        end = textMass[i].Remove(0, countpluking);
                    }
                    else end = textMass[i].Remove(0, countpluking - 1);

                    while (end.Length != 0)
                    {
                        endnaoborot += end.Remove(0, end.Length - 1);
                        end = end.Remove(end.Length - 1);
                    }
                }
                if (start==endnaoborot)
                {
                    Console.WriteLine(textMass[i]);
                }


                

            }
        }








    }
}

