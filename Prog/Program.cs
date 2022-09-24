using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                float gg1;
                float gg2;
                Console.WriteLine("Введите номер операции");
                int act = int.Parse(Console.ReadLine());
                if (act == 9)
                {
                    Console.WriteLine("Работа калькулятора закончена");
                    Thread.Sleep(5000);
                    done = true;
                    
                }
                switch (act)
                {
                    case 1:
                        Console.WriteLine("Введите 1 число");
                        gg1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        gg2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Сложение 1 числа и 2 числа = {gg1 + gg2}");
                        break;
                    case 2:
                        Console.WriteLine("Введите 1 число");
                        gg1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        gg2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Вычитание 1 числа из 2 числа = {gg1 + gg2}");
                        break;
                    case 3:
                        Console.WriteLine("Введите 1 число");
                        gg1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        gg2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Умножение 2 чисел = {gg1 * gg2}");
                        break;
                    case 4:
                        Console.WriteLine("Введите 1 число");
                        gg1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        gg2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Деление 1 числа на 2 число = {gg1 / gg2}");
                        break;
                    case 5:
                        Console.WriteLine("Введите 1 число");
                        gg1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        gg2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Возведение 1 числа в степень = {Math.Pow(gg1, gg2)}");
                        break;
                    case 6:
                        Console.WriteLine("Введите 1 число");
                        gg1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        gg2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($" 1 число ставим в кв. корень = {Math.Sqrt(gg1)}");
                        break;
                    case 7:
                        Console.WriteLine("Введите 1 число");
                        gg1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        gg2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Находим 1% от 1 числа = {gg1 / 100}");
                        break;
                    case 8:
                        Console.WriteLine("Введите 1 число");
                        gg1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        gg2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Находим факториал числа");
                        int an = 1;
                        float n = gg1;
                        for (int i = 1; i <= n; i++)
                            an *= i;
                        Console.WriteLine($"Результат {an}"); break;
                        break;
                }

            }



        }
    }
}
