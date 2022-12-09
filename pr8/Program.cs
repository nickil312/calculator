using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;

namespace pr8
{
    public class Programm
    {
        public static void Main()
        {
            Console.WriteLine("Нажимите F1 для просмотра таблицы рекордов или Escape для выхоад");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.F1)
            {
                Startandend.Start();
                //Console.WriteLine(Startandend.Ck_name);
                Doublefunction.Firstcheck();
            }
            if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            
            
        }
    }

}