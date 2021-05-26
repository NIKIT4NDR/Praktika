using System;

namespace PraktLovtsovDolgodusheva1
{
    static class lib1
    {
        public static void stpow(string a,int b)
        {
            string str = "";
            for (int i = 0; i < b; i++)
            {
                str += a;
            }
            Console.WriteLine(str + "\n");
        }
        public static void rev(string reversed)
        {
            string str = "";
            for (int j = 1; j < reversed.Length +1 ; j++)
            {
                str += reversed[reversed.Length - j] ;
            }
            Console.WriteLine(str + "\n");
        }
        public static void remove(string removestr, string removestr1)
        {
            string str = removestr.Replace(removestr1,"");
            Console.WriteLine(str + "\n");
        }
        public static void leng(string strlong)
        {
            int ij = strlong.Length;
            Console.WriteLine(ij);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            {
                string a;
                int b;
                Console.WriteLine("Введите значение А и В:");
                a = Convert.ToString(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                lib1.stpow(a, b);
            }
            {
                string reversed;
                Console.WriteLine("Введите строку для реверсии:");
                reversed = Console.ReadLine();
                lib1.rev(reversed);
            }
            {
                string removestr;
                string removestr1;
                Console.WriteLine("Введите строку и символ:");
                removestr = Console.ReadLine();
                removestr1 = Console.ReadLine();
                lib1.remove(removestr, removestr1);
            }
            {
                string strlong;
                Console.WriteLine("Введите строку:");
                strlong = Console.ReadLine();
                lib1.leng(strlong);
            }

            Console.ReadLine();
        }
        
    }
}
