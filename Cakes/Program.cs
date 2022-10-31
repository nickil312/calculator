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
        static void Main()
        {
            
            int n;
            Console.WriteLine("Введите количество тортов,которые хотите купить");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                CakeDesign.Menu(position);
                var OrderObject = CakeDesign.CakeList[CakeDesign.CakeList.Count - 1];
                string ourOrder = $"Заказ от {DateTime.Now}\n" +
                    $"\tЗаказ: {OrderObject.shape},{OrderObject.size}\n" +
                    $"\tЦена: {OrderObject.price}\n";
                    
                File.AppendAllText("/Users/Nickill/Desktop/gg.txt", ourOrder);
                
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