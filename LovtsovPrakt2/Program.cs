﻿using System;

namespace LovtsovPrakt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите строку: ");
            string a = Console.ReadLine();
            int schet = 0;
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] == 'f')
                {
                    schet++;
                }
                if (schet == 2)
                {
                    Console.WriteLine($"Индекс= {i}");
                    break;
                }
            }
            if (schet == 1)
            {
                Console.WriteLine("-1");
            }
            if (schet == 0)
            {
                Console.WriteLine("-2");
            }

            {
                Console.WriteLine("Задание 2");
                Console.WriteLine("Введите слово: ");
                string s = Console.ReadLine();
                string pr = "";
                string[] rus = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "э", "ю", "я" };
                string[] eng = { "a", "b", "v", "g", "d", "e", "e", "zh", "z", "i", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "e", "yu", "ya" };
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < rus.Length; j++)
                    {
                        if (s.Substring(i, 1) == rus[j])
                        {
                            pr += eng[j];
                        }
                    }
                }
                Console.WriteLine(pr);
            }

            {
                Console.WriteLine("Задание 3");
                Console.WriteLine("Введите строку: ");
                string log2 = Console.ReadLine();
                string log22 = "";
                int first = 0;
                int last = 0;
                for (int i = 0; i < log2.Length; i++)
                {
                    if (log2[i] == 'h' || log2[i] == 'H')
                    {
                        first = i;
                        break;
                    }
                }
                for (int i = log2.Length - 1; i > 0; i--)
                {
                    if (log2[i] == 'h' || log2[i] == 'H')
                    {
                        last = i;
                        break;
                    }
                }
                for (int i = 0; i < log2.Length; i++)
                {
                    if (i == first || i == last)
                    {
                        log22 = log22 + log2[i];
                    }
                    else if (log2[i] == 'H')
                    {
                        log22 = log22 + "h";
                    }
                    else if (log2[i] == 'h')
                    {
                        log22 = log22 + "H";
                    }
                    else
                    {
                        log22 = log22 + log2[i];
                    }
                }
                Console.WriteLine("Измененная строка: " + log22);
            }

        }
    }
}
