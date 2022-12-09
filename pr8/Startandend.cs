using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using Newtonsoft.Json;

namespace pr8
{
	public class Startandend
	{
        public string name;
        public float csim;
        public float csis;
        static public string Ck_name;
        static public float Ck_csim;
        static public float Ck_csis;
        public static float timesec = 5;
        static public List<Startandend> DreamBoard = new List<Startandend>();
        public Startandend()
        {
        }
        public Startandend(string name, float csim, float csis)
        {
            this.name = name;
            this.csim = csim;
            this.csis = csis;
            
        }

        public static string Start()
		{
            List<Startandend> b = new List<Startandend>();
            Console.WriteLine("Таблица рекордов");
            string Pepperoni__json = File.ReadAllText($"/Users/Nickill/Desktop/файлы для с/resuljson.json");
            DreamBoard = JsonConvert.DeserializeObject<List<Startandend>>(Pepperoni__json);
            foreach (var item in DreamBoard)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.csim);
                Console.WriteLine(item.csis);
            }
            Console.WriteLine("Нажмите F1,чтобы ввести имя (Имя в формате string и без пробелов) и начать тест на скоропечатание или Escape для выхода из программы");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.F1)
            {
                Console.WriteLine("Введите свое имя");
                var b2 = Console.ReadLine();
                Ck_name = b2;
            
            }return Ck_name;
            if(key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        
        
        public static void gettingandgivinginfo()
        {
            if (Doublefunction.x2 == 353 && Doublefunction.Flag == 60)
            {
                //int Scim = (((Doublefunction.y*5)+Doublefunction.x)/Doublefunction.Flag);

                float Scim = 353;
                float Scis = (353 / 60);
                Startandend.Ck_csis = Scis;
                Startandend.Ck_csim = Scim;
            }
            if(Doublefunction.x2 < 353 && Doublefunction.Flag == 60)
            {
                float Scim2 = (Doublefunction.x2);
                float Scis2 = (Doublefunction.x2 / 60);
                Startandend.Ck_csis = Scis2;
                Startandend.Ck_csim = Scim2;
            }
            if(Doublefunction.x2 == 353 && Doublefunction.lowtime < 60)
            {
                float Scim3 = ((((Doublefunction.Flag-Doublefunction.x2)*100)/60)*353);
                float Scis3 = (Doublefunction.x2 / Doublefunction.lowtime);
                Startandend.Ck_csis = Scis3;
                Startandend.Ck_csim = Scim3;
            }
            //var OrderObject = Startandend.DreamBoard[Startandend.DreamBoard.Count - 1];
            //string ourOrder = ($"{Startandend.Ck_name},{Startandend.Ck_csim},{Startandend.Ck_csis}");
            //File.AppendAllText("/Users/Nickill/Desktop/gg.txt", ourOrder);
            Startandend Greg = new Startandend();
            Greg.name = Ck_name;
            Greg.csim = Ck_csim;
            Greg.csis = Ck_csis;
            DreamBoard.Add(Greg); 
            string pizza_json = JsonConvert.SerializeObject(Startandend.DreamBoard);
            File.AppendAllText($"/Users/Nickill/Desktop/файлы для с/resuljson.json", pizza_json);


        }
    }
}

