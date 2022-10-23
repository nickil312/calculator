using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pr2
{

    internal class Program
    {


        static void Main()
        {
            static void guessthenumber()
            {
                Random randomnumber = new Random();
                int value = randomnumber.Next(0, 100);
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
            static void tablicha()
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
                                Console.Write(q[m, n] + "  /|/ ");
                            }
                            else
                            {
                                Console.Write(q[m, n] + " /|/ ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;
                    
                }
            }
            static void numberdelitel()
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
                
            }
            static void startprogramm()
            {
                Console.WriteLine(" Введите номер программы\n " +
                    "1.Игра 'Угадай число'\n " +
                    "2.Таблица умножения\n " +
                    "3.Вывод делителей числа\n " +
                    "4.Для выхода из программы введите 4");
                
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("Вы выбрали игру угадай число");
                    guessthenumber();
                }
                if (a == 2)
                {
                    Console.WriteLine("Вы выбрали таблицу умножения");
                    tablicha();
                }
                if (a == 3)
                {
                    Console.WriteLine("Вы выбрали программу по определителю делителей числа");
                    numberdelitel();
                }
                if (a == 4)
                {
                    Console.WriteLine("Вы вышли");
                    Environment.Exit(0); 
                }
                else
                {
                    Console.WriteLine("Введите числа из списка(1-4)");
                    Thread.Sleep(500);
                    Console.Clear();
                    startprogramm();
                }
            }
            startprogramm();
        }
    }
}
