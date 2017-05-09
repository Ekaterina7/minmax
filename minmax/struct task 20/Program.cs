using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_task_20
{
    class Program
    {
        struct Students
        {
            public string username;
            public string group;
            public string birthday;
            public int phyzic;
            public int math;
            public int informatika;

        }
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\\Users\Екатерина\Desktop\структуры20.txt");
            List<Students> listOfstudents = new List<Students>();
            for (int i = 0; i < text.Count(); i++)
            {
                Students tmp = new Students();
                tmp.username = text[i].Split(';').ElementAt(0);
                tmp.group = text[i].Split(';').ElementAt(1);
                tmp.birthday = text[i].Split(';').ElementAt(2);
                tmp.phyzic = Convert.ToInt32(text[i].Split(';').ElementAt(3));
                tmp.math = Convert.ToInt32(text[i].Split(';').ElementAt(4));
                tmp.informatika = Convert.ToInt32(text[i].Split(';').ElementAt(5));
                listOfstudents.Add(tmp);
            }
            int mathcount = 0;
            for (int i = 0; i < listOfstudents.Count; i++)
            {
                if (listOfstudents[i].math==95)
                {
                    mathcount++;
                    Console.WriteLine(listOfstudents[i].username + " " + listOfstudents[i].group + " " + listOfstudents[i].birthday);
                    
                }
            }
            Console.WriteLine(mathcount);
        }
    }
}
