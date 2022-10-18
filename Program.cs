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
        // переменные для считывания количества сдвигов по x и y
        static void Main()
        {
            
            //Soul gg = new Soul();
            //gg.get2();
            //Soul.get1();
            
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Выбрана дата");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("  1: Прийти на пары");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("  2: Сделать практические");
            Console.WriteLine("  3: Купить продукты");
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
                    position = 6;
                }
                // цикл для сдвига стрелочки
                Console.Clear();
                Console.SetCursorPosition(2, 0);
                Console.WriteLine("Выбрана дата");
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("  1: Прийти на пары");
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("  2: Сделать практические");
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("  3: Купить продукты");
                Console.SetCursorPosition(0, position);
                Console.WriteLine($"{position}>");
                key = Console.ReadKey();
                //Считывание стрелочки и ее предвижение по нему
                Soul.hey(key);
                //вызов класса
            }





        }
    }
}


