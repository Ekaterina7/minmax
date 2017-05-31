using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workwithpapka
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] dirs = Directory.GetFileSystemEntries(@"C:\Users\student\Desktop\papka1");
          
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
            Console.WriteLine();
            string[] file1 = Directory.GetFiles(dirs[0]);
            string[] file2 = Directory.GetFiles(dirs[1]);
            foreach (var item in file1)
            {
                Console.WriteLine(File.ReadAllText(item));
                string text = File.ReadAllText(item);
                Console.WriteLine("Количество символов = {0}", text.Length);
                string[] textmas = text.Split(' ', '.', ';', '-');
                Console.WriteLine("Количество слов = {0}",textmas.Length);

                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (var item in file2)
            {
                Console.WriteLine(File.ReadAllText(item));
                string text = File.ReadAllText(item);
                Console.WriteLine("Количество символов = {0}", text.Length);
                string[] textmas = text.Split(';');
                Console.WriteLine("Количество слов = {0}", textmas.Length);
                Console.WriteLine();
            }


        }
    }
}
