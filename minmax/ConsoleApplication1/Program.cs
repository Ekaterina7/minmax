using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        public struct Person
        {
            public string name;
            public string surname;
            public string gender;
            public string language;
            public DateTime birthday;

            public Person(string name, string surname, string gender, string language, DateTime birthday)
            {
                this.name = name;
                this.surname = surname;
                this.gender = gender;
                this.language = language;
                this.birthday = birthday;
            }
        }
        static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();
            
            string[] text = File.ReadAllLines(@"C:\Users\Екатерина\Desktop\катя.txt");


            for (int i = 0; i < text.Count(); i++)
            {

                Person tmp = new Person(text[i].Split(';').ElementAt(0), 
                                        text[i].Split(';').ElementAt(1), 
                                        text[i].Split(';').ElementAt(2),
                                        text[i].Split(';').ElementAt(3), 
                                        Convert.ToDateTime(text[i].Split(';').ElementAt(4)));
                listOfPersons.Add(tmp);

            }

            DateTime max = DateTime.MinValue;
            int temp = 0;
            for(int i=0; i<listOfPersons.Count; i++)
            {
                if (listOfPersons[i].birthday > max)
                {
                    max = listOfPersons[i].birthday;
                    temp = i;
                }

            }

            Console.WriteLine("Самый младший: " + listOfPersons[temp].name + " " + listOfPersons[temp].surname);

            DateTime min = DateTime.MaxValue;
            temp = 0;
            for(int i=0; i<listOfPersons.Count;i++)
            {
                if (listOfPersons[i].birthday < min)
                {
                    min = listOfPersons[i].birthday;
                    temp = i;
                }
            }
            Console.WriteLine("Самый старший: " + listOfPersons[temp].name + " " + listOfPersons[temp].surname);
        }
    }
}
