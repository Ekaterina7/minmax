using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_task_10
{
    class Program
    {
        struct Book
        {
            public string autor;
            public int count;
            public int circulation;
            public int year;
        }
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\\Users\Екатерина\Desktop\структуры10.txt");
            List<Book> listOfBooks = new List<Book>();

            for (int i = 0; i < text.Count(); i++)
            {
                Book tmp = new Book();
                tmp.autor = text[i].Split(';').ElementAt(0);
                tmp.count = Convert.ToInt32(text[i].Split(';').ElementAt(1));
                tmp.circulation = Convert.ToInt32(text[i].Split(';').ElementAt(2));
                tmp.year = Convert.ToInt32(text[i].Split(';').ElementAt(3));
                listOfBooks.Add(tmp);
            }
            for (int i = 0; i < listOfBooks.Count; i++)
            {
                if (listOfBooks[i].count>=150)
                {
                    Console.WriteLine(listOfBooks[i].autor+" "+ listOfBooks[i].count + " "+listOfBooks[i].circulation + " "+ listOfBooks[i].year);
                }
                
            }


        }
    }
}
