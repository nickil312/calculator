using System;
using System.Diagnostics;

namespace pr7
{
    public class Arrows_1
    {
        public static int min1,max1;
        static string diskname = "";
        static int fn;
        static string files2;
        public Arrows_1(int upbor,int downbor)
        {
            min1 = upbor;
            max1 = downbor;
        }
        public static void MovingArrows()
            //Getbackmydirsandfiles files//)
        {

            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    Programm.position++;
                    Console.SetCursorPosition(0, Programm.position - 1);
                    Console.WriteLine("   ");
                    fn += 1;
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    Programm.position--;
                    Console.SetCursorPosition(0, Programm.position + 1);
                    Console.WriteLine("   ");
                    fn -= 1;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    //if (Programm.position > 50)
                    //{
                    //    for (int i = 1; i < 10; i++)
                    //    {

                    //    int b = 0;
                    //    Console.SetCursorPosition(0, b);
                    //    Console.Clear();
                    //    b += 50;
                    //    }
                    //}
                    Console.Clear();
                    MyDisk.miniinfoanoutdisk = 3;
                    MyDisk.nameofdisk = 3;
                    MyDisk.numberofdisk = 1;
                    Programm.position = 3;
                    //Programm.myf1key = false;
                    Programm.Main();
                }
                if (key.Key == ConsoleKey.F1)
                {
                    fn = Programm.position;
                    fn -= MyDisk.underpapka;
                    fn -= 1;
                    
                    Console.WriteLine($"{fn}");
                    Console.WriteLine($"{MyDisk.underpapka}");
                    //Getbackmydirsandfiles bb = MyDisk.Underdiskinfo(Getbackmydirsandfiles.files[Programm.position - fn].ToString());
                    Process.Start(new ProcessStartInfo{FileName = Getbackmydirsandfiles.files[fn].ToString() , UseShellExecute = true});
                    fn = Programm.position;
                   
                }
                if (Programm.position < min1)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("   ");
                    Programm.position = max1;
                    fn = max1;
                }
                if (Programm.position > max1)
                {
                    Console.SetCursorPosition(0, max1);
                    Console.WriteLine("   ");
                    Programm.position = min1;
                    fn = min1;
                }
                //if (Programm.position == 3 && key.Key == ConsoleKey.Enter)
                //{
                //    diskname = "/";

                //}

                Console.SetCursorPosition(0, Programm.position);
                Console.WriteLine($"-{Programm.position}");
                key = Console.ReadKey();
            }
        }
    }
}

