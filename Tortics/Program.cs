using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortics
{
    internal class Program
    {

         
        static void Main()
        {
            var a = new Order(new Decor(), int.Parse(Console.ReadLine()), "Цветочки", "Красный", 3);
            Console.WriteLine($"Размер торта {a.Amount}\n Количество декора {a.Decor.Amount}");
            Console.ReadKey();
        }
    }
}
