using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;

namespace pr7
{
    public class Programm
    {
        public static int position = 3;
        public static bool myf1key = true;
        public static int escapebutton = 0;
        public static void Main()
        {
            Console.Clear();
            Arrows_1 border1 = new Arrows_1(3, 9);
            DriveInfo[] drives = MyDisk.GettingInfoAboutDisk();
            //DirectoryInfo[] dirs = MyDisk.Underdiskinfo(path);
            while (myf1key == true)
            {

            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"-{Programm.position}");
            Arrows_1.MovingArrows();
            Getbackmydirsandfiles dirs = MyDisk.Underdiskinfo(drives[Programm.position-3].ToString());
            while (true)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine($"-{Programm.position}");
                    Arrows_1.MovingArrows();
                    dirs = MyDisk.Underdiskinfo(dirs.dirs[Programm.position - 3].ToString());

                }
            }
        }
    }
}

