using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LovtsovPrakt4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { "s", 5, 3, "E", "b", "S", 101, 1488, "ITDOG", 322, "qm2", "m3q", "MM", "e", 22 };
            ArrayList LIST = new ArrayList();
            string h = "";
            foreach (var i in list)
            {
                Type t = i.GetType();
                if (t.Equals(typeof(int)) == false)
                {
                    h += i + " ";
                }
            }
            Console.WriteLine(h);
            Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (Char.IsUpper(list[i].ToString().ToCharArray()[0]))
                {
                    LIST.Add(list[i]);
                }
            }
            foreach (var i in LIST)
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadLine();
        }
    }
}
