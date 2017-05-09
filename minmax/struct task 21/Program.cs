using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_task_21
{
    class Program
    {
        struct Goods
        {
            public int count;
            public int price;
            public string year;
            public string producer;
        }
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\Екатерина\Desktop\структуры21.txt");
            List<Goods> listOfGoods = new List<Goods>();
            for (int i = 0; i < text.Count(); i++)
            {
                Goods tmp = new Goods();
                tmp.count = Convert.ToInt32(text[i].Split(';').ElementAt(0));
                tmp.price = Convert.ToInt32(text[i].Split(';').ElementAt(1));
                tmp.year = text[i].Split(';').ElementAt(2);
                tmp.producer = text[i].Split(';').ElementAt(3);
                listOfGoods.Add(tmp);

            }
            int max = listOfGoods[0].count;

            for (int i = 0; i < listOfGoods.Count; i++)
            {
                if (listOfGoods[i].count>max)
                {
                    max = listOfGoods[i].count;
                }
            }
            for (int i = 0; i < listOfGoods.Count; i++)
            {
                if (listOfGoods[i].count==max)
                {
                    Console.WriteLine(listOfGoods[i].count + " " + listOfGoods[i].price + " " + listOfGoods[i].year + " " + listOfGoods[i].producer);
                }
            }

        }
    }
}
