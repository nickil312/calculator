using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Practicheskai_4

{
    public class Programm
    {
        public static int position = 1;
        public static int xposition = 0;
        public static DateTime selectedDate = DateTime.Now;
        
        static void Main()
        {
            Soul gg1 = new Soul()
            {
                name = "НЕТ ПАР",
                description = "Сиди дома",
                SoulDay = new DateTime(2022, 10, 19),
            };
            Soul gg2 = new Soul()
            {
                name = "Прийти на пары на нежку",
                description = "С 1 по 4 пару",
                SoulDay = new DateTime(2022, 10, 20),
            };
            Soul gg3 = new Soul()
            {
                name = "Прийти на пары на нахим",
                description = "С 3 по 5 пару",
                SoulDay = new DateTime(2022, 10, 21),
            };
            Soul gg4 = new Soul()
            {
                name = "Прийти на пары в дистанте",
                description = "С 2 по 4 пару",
                SoulDay = new DateTime(2022, 10, 12),
            };
            Soul gg5 = new Soul()
            {
                name = "Сделать практические (оч много)",
                description = "Сделать 1 и 2",
                SoulDay = new DateTime(2022, 10, 14),
            };
            Soul gg6 = new Soul()
            {
                name = "Сделать практические по питону",
                description = "Доделать 1 и сделать 2",
                SoulDay = new DateTime(2022, 10, 14),
            };
            Soul gg7 = new Soul()
            {
                name = "gg",
                description = "Сделать 1 и 2",
                SoulDay = new DateTime(2022, 10, 14),
            };
            Soul.souls.Add(gg1);
            Soul.souls.Add(gg2);
            Soul.souls.Add(gg3);
            Soul.souls.Add(gg4);
            Soul.souls.Add(gg5);
            Soul.souls.Add(gg6);
            Soul.souls.Add(gg7);
            // нач текст без стрелки 

            ConsoleKeyInfo key = Console.ReadKey();
            //считывается кнопка (стрелка вниз/вверх)
            ConsoleKeyInfo a = Console.ReadKey();
            //считывается кнопка (esc для заканчивания программы)
          
            while (a.Key != ConsoleKey.Escape)
            {

                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;

                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                if (position < 1)
                {
                    position = 1;
                }
                if (position > 6)
                {
                    position = 1;
                }
                Console.Clear();
                Console.SetCursorPosition(2, 0);
                Console.WriteLine("Выбрана дата");
                Console.WriteLine("  1: Прийти на пары");
                Console.WriteLine("  2: Сделать практические");
                Console.WriteLine("  3: Купить продукты");
                Console.SetCursorPosition(0, position);
                Console.WriteLine($"{position}>");
                key = Console.ReadKey();
                ConsoleKeyInfo upanddown = Console.ReadKey();
                if (position == 1 && upanddown.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    
                    foreach (Soul item in Soul.souls)
                    {
                        Console.WriteLine("Нажмите вправо для просмотра 1 записи ");
                        
                        ConsoleKeyInfo rightbutton = Console.ReadKey();
                        if (rightbutton.Key == ConsoleKey.RightArrow)
                        {
                            selectedDate = selectedDate.AddDays(+1);
                            if (item.SoulDay == selectedDate)
                            {
                            Console.WriteLine("  " + item.name);

                            }
                            

                        }
                        
                        else if (rightbutton.Key == ConsoleKey.LeftArrow)
                        {
                            
                            selectedDate = selectedDate.AddDays(-1);
                            if (item.SoulDay == selectedDate)
                            {
                                Console.WriteLine("  " + item.name);

                            }
                        }


                    }
                }
                
                
            }





        }
    }
}


