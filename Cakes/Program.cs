﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Cakes

{
    public class Programm
    {
        public static int position = 1;
        public static int secondposition = 1;
        
        static void Main()
        {
            File.Create("/Users/Nickill/Desktop/gg.txt");
            int n;
            Console.WriteLine("Введите количество тортов,которые хотите купить");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                CakeDesign.Menu(position);
                //File.AppendAllText("/Users/Nickill/Desktop/gg.txt",CakeDesign.Ck_shape);
                
                //сдесь должно быть выписываение списка закказов
                Console.Clear();
                
                Console.WriteLine($"Сумма заказа {CakeDesign.Ck_price}");
                Console.WriteLine("Хотите зааказть еще один тортик?\n" +
                    "1:ДА\n" +
                    "2:НЕТ\n");
                
                int lastcheck;
                lastcheck = int.Parse(Console.ReadLine());
                if (lastcheck == 1)
                {
                    n++;
                }
                else
                {
                    Console.WriteLine("Торт(ы) заказан(ы)\n" +
                        "Проверьте чек");
                }
            }
        }
    }
}