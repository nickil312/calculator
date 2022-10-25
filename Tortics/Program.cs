using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortics
{
    internal class Program
    {
        /// <summary>
        /// Более комфортный путь создания через конструктор
        /// </summary>
        /// <param name="amount">Количество деталек декора</param>
        /// <param name="view">Вид деталей</param>
        /// <param name="color">Цвет деталей</param>
        /// <param name="size">Введите размер деталек декора</param>
        /// <returns>Объект сразу с декором</returns>

        static Order OrderDecor(int amount = 0, string view = "", string color = "", int size = 0)
        {
            Console.WriteLine("Введите количество деталек декора: ");
            int.TryParse(Console.ReadLine(), out amount);
            Console.WriteLine("Введите размер деталек декора: ");
            int.TryParse(Console.ReadLine(), out size);
            Console.WriteLine("В виде чего будут детальки?");
            view = Console.ReadLine();
            Console.WriteLine("В какого цвета будут детальки?");
            color = Console.ReadLine();
            return new Order(new Decor(), amount, view, color, size);
        }
        
        static void Main()
        {
            var a = OrderDecor(12, size: 13);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Размер торта {a.Amount}" +
                $"\n Количество декора {a.Decor.Amount}" +
                $"\n Цвет декора{a.Decor.Color}" +
                $"\n Вид декора{a.Decor.View}" +
                $"\n Размер декора{a.Decor.Size}");
            Console.ReadKey();
        }
    }
}
