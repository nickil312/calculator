using System;
using System.IO;

namespace pr7
{
    public class MyDisk
    {

        public static int miniinfoanoutdisk = 3;
        public static int nameofdisk = 3;
        public static int numberofdisk = 1;
        public static int underpapka = 3;
        public static int underfile = 1;
        public static int enterbutton = 0;
        public static int entertoplusway = 0;
        public string Name;
        //public int TotalSize;
        //public int TotalFreeSpace;
        //static public List<MyDisk> Diskinfo = new List<MyDisk>();
        //public MyDisk()
        //{
        //}
        //public MyDisk(string Name, int TotalSize, int TotalFreeSpace)
        //{
        //    this.Name = Name;
        //    //this.TotalSize = TotalSize;
        //    //this.TotalFreeSpace = TotalFreeSpace;
        //}
        public static DriveInfo[] GettingInfoAboutDisk()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Ваши диски:");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("___________________________________________________________________________________________");

            foreach (DriveInfo drive in drives)
            {
                Console.SetCursorPosition(3, nameofdisk);
                Console.WriteLine($"   {numberofdisk}. Название: {drive.Name}");
                //MyDisk drive.Name = new MyDisk();
                //if (drive.IsReady)
                //{
                Console.SetCursorPosition(44, miniinfoanoutdisk);
                Console.WriteLine($"   Объем диска: {drive.TotalSize / Convert.ToInt64(Math.Pow(2, 33))} ГБ ");
                Console.SetCursorPosition(64, miniinfoanoutdisk);
                Console.WriteLine($"   Свободное пространство: {drive.TotalFreeSpace / Convert.ToInt64(Math.Pow(2, 33))}");
                //}
                numberofdisk += 1;
                nameofdisk += 1;
                miniinfoanoutdisk += 1;
            }
            return drives;
            //nameofdisk -= 24;
            //Console.SetCursorPosition(0, nameofdisk);
            //Console.WriteLine($"-{Programm.position}");
            //return "";
        }
        public static Getbackmydirsandfiles Underdiskinfo(string path)
        {
            //if (entertoplusway >= 1)
            //{
            //    path += "/";
            //    path += 
            //}
            string dirName = path;
            Getbackmydirsandfiles gb = new Getbackmydirsandfiles();
            Console.Clear();
            var directory = new DirectoryInfo(path);
            Console.SetCursorPosition(3, 0);
            Console.WriteLine("Escape - выход в меню");
            Console.SetCursorPosition(30, 0);
            Console.WriteLine($"Ваши подкаталоги и файлы в диске:{path}");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("___________________________________________________________________________________________");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Подкаталоги:");
            Programm.position = 3;
            if (enterbutton >= 1)
            {
                underpapka = 3;
                Arrows_1.max1 = 9;
                underfile = 1;
            }
            DirectoryInfo[] dirs = directory.GetDirectories();
            gb.dirs = dirs;
            foreach (DirectoryInfo s in dirs)
            {
                Console.SetCursorPosition(3, underpapka);
                Console.WriteLine(s.FullName);
                underpapka += 1;
                Arrows_1.max1 += 1;
            }
            Console.WriteLine();
            Console.SetCursorPosition(3, underpapka);

            Console.WriteLine("Файлы:");
            underfile += underpapka;
            Arrows_1.max1 += 1;
            FileInfo[] files = directory.GetFiles();
            Getbackmydirsandfiles.files = files;
            foreach (FileInfo s in files)
            {
                Console.SetCursorPosition(3, underfile);
                Console.WriteLine(s.FullName);
                underfile += 1;
                Arrows_1.max1 += 1;
            }
            Arrows_1.max1 -= 7;
            enterbutton += 1;
            return gb;

        }

        //public static void UnderpapkasInfos(string dirName, string path)
        //{
        //    Console.WriteLine(dirName);
        //    string dirpapkaandnextpapkas = dirName;
        //    dirpapkaandnextpapkas += "/";
        //    //dirpapkaandnextpapkas += ;

        //    Console.Clear();
        //    if (Directory.Exists(dirName))
        //    {
        //        Console.SetCursorPosition(3, 0);
        //        Console.WriteLine("Подкаталоги:");
        //        string[] dirs = Directory.GetDirectories(dirName);
        //        foreach (string s in dirs)
        //        {
        //            Console.SetCursorPosition(3, underpapka);
        //            Console.WriteLine(s);
        //            underpapka += 1;
        //        }
        //        Console.WriteLine();
        //        Console.SetCursorPosition(3, underpapka);

        //        Console.WriteLine("Файлы:");
        //        underfile += underpapka;
        //        string[] files = Directory.GetFiles(dirName);
        //        foreach (string s in files)
        //        {


        //            Console.SetCursorPosition(3, underfile);
        //            Console.WriteLine(s);
        //            underfile += 1;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("ti lox ");
        //    }
    //}
    }
}

