using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Prackticheskai_2
{

    internal class Program
    {

        //выбор функции пользователем
        static void Main()
        {
            Console.WriteLine("Введите приложение\n Игра 'Угадай число'\n Таблица умножения\n Вывод делителей числа");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Вы выбрали игру");
                    n();
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали таблицу умножения");
                    b();
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали вывод делителей числа");
                    hey();
                    break;

            }
            static void n()
            {
                //Создание объекта для генерации чисел
                Random rnd = new Random();

                //Получить случайное число (в диапазоне от 0 до 10)
                int value = rnd.Next(0, 100);
                int i = value;
                int a;
                do
                {
                    Console.WriteLine("Введите чиcло");
                    a = int.Parse(Console.ReadLine());
                    if (i != a)
                    {
                       
                        if (i > a)
                        {
                            Console.WriteLine("Больше");
                        }
                        if (i < a)
                        {
                            Console.WriteLine("Меньше");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Молодец, нашел");
                    }
                }
                while (a != value);


            }
            static void b()
            {
                Console.WriteLine("Таблица умножения: ");

                while (true)
                {
                    int[,] q = new int[9, 9]
                    {
                        {1,2,3,4,5,6,7,8,9},
                        {2,4,6,8,10,12,14,16,18},
                        {3,6,9,12,15,18,21,24,27},
                        {4,8,12,16,20,24,28,32,36},
                        {5,10,15,20,25,30,35,40,45},
                        {6,12,18,24,30,36,42,48,54},
                        {7,14,21,28,35,42,49,56,63},
                        {8,16,24,32,40,48,56,64,72},
                        {9,18,27,36,45,54,64,72,81}
                    };
                    for (int m = 0; m < q.GetLength(0); m++)
                    {
                        for (int n = 0; n < q.GetLength(1); n++)
                        {
                            if (q[m, n] < 10)
                            {
                                Console.Write(q[m, n] + "  | ");
                            }
                            else
                            {
                                Console.Write(q[m, n] + " | ");
                            }
                        }
                        Console.WriteLine();
                    }
                    Thread.Sleep(5000);
                    break;
                }
            }

            static void hey()
            {

                Console.WriteLine("Введите чиcло");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = a; i > 0; i--)
                {
                    {
                        if (a % i == 0)
                        {
                            Console.Write(a / i + " / ");
                        }
                    }
                }
                Thread.Sleep(5000);
            }
        }
    }
}