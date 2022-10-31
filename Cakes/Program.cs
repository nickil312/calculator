using System;
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
        public static int thirdposition = 1;
        public static int fourthposition = 1;
        public static int sixthposition = 1;
        public static int seventhposition = 1;
        public static int eightposition = 1;
        static void Main()
        {
            Console.CursorVisible = false;
            int n;
            Console.WriteLine("Введите количество тортов,которые хотите купить");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                CakeDesign.Menu(position,thirdposition,fourthposition, sixthposition, seventhposition, eightposition);
                var OrderObject = CakeDesign.CakeList[CakeDesign.CakeList.Count - 1];
                string ourOrder = $"Заказ от {DateTime.Now}\n" +
                    $"\tЗаказ: {OrderObject.shape},{OrderObject.size},{OrderObject.taste},{OrderObject.amountoflevels},{OrderObject.glaze},{OrderObject.decor}\n" +
                    $"\tЦена: {OrderObject.price}\n";
                    
                File.AppendAllText("/Users/Nickill/Desktop/gg.txt", ourOrder);
                
                //сдесь должно быть выписываение списка закказов
                Console.Clear();
                
                Console.WriteLine($"Сумма заказа {CakeDesign.Ck_price}");
                Console.WriteLine("Хотите заказать еще один тортик?\n" +
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
                    Thread.Sleep(3000);
                    Console.WriteLine("Торт(ы) заказан(ы)\n" +
                        "Проверьте чек");
                }
            }
        }
    }
}