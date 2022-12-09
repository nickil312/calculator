using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

namespace pr8
{
	public class Doublefunction
	{
        public static int Flag = 0;
        public static int Timer = 10;
        public static int x = 0;
        //значение по оси x
        public static int x2 = 0;

        public static int i = 0;
        //буквы в тексте для окрашивания
        public static int y = 1;
        //для следующих строк
        public static int enter = 0;
        //для переносов с разных строк разной длины
        public static int thread_stop = 0;
        public static int lowtime = 0;
        public static void Firstcheck()
		{
            
            
            const string text = ("Привет, тут пишется текст, который настолько интеремен для написания," +
					"что использует практически одни и те же буквы, а теперь будет текст на все буквы, кроме ж "+
                    "съешь ещё этих мягких французских булок, да выпей чаю, вот и как раз это и был наш текст," +
					"ну что успел написать или нет?? я думаю да так, как текст вроде как маленький и я задолбал запятыми, да ?");
            char[] numbertext = text.ToCharArray();
            ConsoleKeyInfo checkkey;
            do
            {
                Console.Clear();
                Console.WriteLine(text);
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("Время для прочтения текста, чтобы начать тестирование нажмите Enter");
                Console.WriteLine("Вам будет дано 60 секудн для написания текста");
                checkkey = Console.ReadKey();
            } while (checkkey.Key != ConsoleKey.Enter);
            Thread writing = new Thread(Turnonmythreads);
                writing.Start();
            
            Thread timer = new Thread(_ =>
            {
                //Stopwatch stopwatch = Stopwatch.StartNew();
                //while (stopwatch != 60)
                //{
                //Console.SetCursorPosition(7, 15);
                //Console.WriteLine("                                      ");
                //Console.SetCursorPosition(7, 15);
                //Console.WriteLine(stopwatch.ElapsedMilliseconds/1000);
                //if (y == 1 && x == 4)
                //{
                //    stopwatch.Stop();
                //    Console.SetCursorPosition(7, 15);
                //    Console.WriteLine("Таймер дед");
                //}
                //}
                
                while(Flag != 60)
                {

                    Thread.Sleep(1000);
                    Flag += 1;
                    Console.SetCursorPosition(5,7);
                    Console.WriteLine("   ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    
                    Console.SetCursorPosition(0, 8);
                    Console.WriteLine("   ");
                    
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine($"{Flag} ");
                    Console.SetCursorPosition(8, 7);
                    Console.WriteLine("- столько секунд прошло!");
                }
                Startandend.gettingandgivinginfo();

            });
            timer.Start();
            
        }
        public static void Turnonmythreads()
        {
            const string text = ("Привет, тут пишется текст, который настолько интеремен для написания," +
                    "что использует практически одни и те же буквы, а теперь будет текст на все буквы, кроме ж " +
                    "съешь ещё этих мягких французских булок, да выпей чаю, вот и как раз это и был наш текст," +
                    "ну что успел написать или нет?? я думаю да так, как текст вроде как маленький и я задолбал запятыми, да ?");
            char[] numbertext = text.ToCharArray();
            
            while (thread_stop != 1)
            {
                ConsoleKeyInfo j;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(x, y);
                Console.WriteLine(text);






                while (Flag != 60)
                {
                    j = Console.ReadKey(true);
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("   ");
                    if (j.KeyChar == numbertext[i])
                    {
                        Console.SetCursorPosition(x, y);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(j.KeyChar);
                        x++;
                        x2++;
                        if (x == 117)
                        {
                            y += 1;
                            x = 0;
                            enter = 2;
                        }
                        i++;
                        if (y == 5 && x == 4)
                        {
                            lowtime = Flag;
                            Flag = 60;
                        } 

                    }
                    //Console.WriteLine(text);
                    else
                    {
                        Console.SetCursorPosition(x, 0);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(j.KeyChar);
                    }
                }
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("   ");
                Console.SetCursorPosition(5, 8);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Таймер закончился!");
                thread_stop += 1;
            }
            Thread.Sleep(3000);
        }

    }
}

