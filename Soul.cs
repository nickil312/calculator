using System;
namespace Practicheskai_4
{
    public class Soul
    {


        //int gg1 = 1;
        static DateTime dateTime1 = new DateTime(2022, 10, 8);
        static DateTime dateTime2 = new DateTime(2022, 9, 4);
        static DateTime dateTime3 = new DateTime(2022, 10, 5);
        // даты которые будут выписываться
        static List<string> text = new List<string>() { "Прийти на пары на нахим", "-----------------------", "Описание: С 1 по 4 пару" };
        static List<string> text2 = new List<string>() {  "Прийти на пары на нежку", "----------------------", "Описание: С 2 по 3 пару "};

        
        //    public static void get1()
        //    {
        //        Console.WriteLine("ghbd");
        //    }
        //    public void get2()
        //    {
        //        int a = 1;
        //        int b = 3;
        //        int c = b + a;
        //        Console.WriteLine(c);
        //    }
        public static void hey(ConsoleKeyInfo presskey)

        {
            if (Programm.position == 1 && presskey.Key == ConsoleKey.Enter)
            {
                
                
                if (Programm.xposition == 0)
                {
                    Console.Clear();
                    foreach (string text1 in text)
                    {
                        Console.WriteLine(text1);
                    }
                    Console.WriteLine(dateTime1);
                    ConsoleKeyInfo presskey2 = Console.ReadKey();
                    if (presskey2.Key == ConsoleKey.RightArrow)
                    {
                        Programm.xposition++;
                        hey(presskey2);
                    }
                    
                }
                

                if (Programm.xposition == 1)
                {
                    Console.Clear();
                    foreach (string text0 in text2)
                    {
                        Console.WriteLine(text0);
                    }
                    Console.WriteLine(dateTime2);
                    ConsoleKeyInfo presskey3 = Console.ReadKey();
                    if (presskey3.Key == ConsoleKey.RightArrow)
                    {
                        Programm.xposition++;
                        hey(presskey3);
                    }

                    else if (presskey3.Key == ConsoleKey.LeftArrow)
                    {
                        Programm.xposition--;
                        hey(presskey3);
                    }
                }
                

                if (Programm.xposition == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Прийти на пары на дистанте");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Описание: С 4 по 5 пару");
                    Console.WriteLine(dateTime3);
                }
                ConsoleKeyInfo presskey4 = Console.ReadKey();
                if (presskey4.Key == ConsoleKey.LeftArrow)
                {
                    Programm.xposition--;
                    hey(presskey4);
                }
            }
            
            if (Programm.position == 2 && presskey.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("gg wp");

            }

            if (Programm.position == 3)
            {
                
            }
        }
        
    }
}

