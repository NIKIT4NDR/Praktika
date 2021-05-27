using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovtsovPrakt10
{
    class Program
    {
        static void Main(string[] args)
        {
        a:
            string vvod = Convert.ToString(Console.ReadLine());
            int S = 0;
            for (int i = 0; i < vvod.Length; i++)
            {
                if (vvod[i] != 'M' || vvod[i] != 'D' || vvod[i] != 'C' || vvod[i] != 'L' || vvod[i] != 'X' || vvod[i] != 'V' || vvod[i] != 'I')
                {
                    Console.WriteLine("Вы ввели недопустимый символ!");
                    break;
                }
                if (vvod[i] == 'M')
                {
                    S += 1000;
                }
                if (vvod[i] == 'D')
                {
                    S += 500;
                }
                if (vvod[i] == 'C')
                {
                    S += 100;
                }
                if (vvod[i] == 'L')
                {
                    S += 50;
                }
                if (vvod[i] == 'X')
                {
                    S += 10;
                }
                if (vvod[i] == 'V')
                {
                    S += 5;
                }
                if (vvod[i] == 'I')
                {
                    S += 1;
                }
            }
            if (S > 0)
            {
                Console.WriteLine(S);
            }
            Console.ReadLine();
            goto a;
        }
    }
}
