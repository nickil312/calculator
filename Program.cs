namespace Practicheskai_4

{
    public class Programm
    {
        public static int position = 1;
        public static int xposition = 0;
        public static DateTime selectedDate = DateTime.Now;

        static void Main()
        {
            Soul gg1 = new Soul()
            {
                name = "НЕТ ПАР",
                description = "Сиди дома",
                SoulDay = new DateTime(2022, 10, 19).Day,
            };
            Soul gg2 = new Soul()
            {
                name = "Прийти на пары на нежку",
                description = "С 1 по 4 пару",
                SoulDay = new DateTime(2022, 10, 20).Day,
            };
            Soul gg3 = new Soul()
            {
                name = "Прийти на пары на нахим",
                description = "С 3 по 5 пару",
                SoulDay = new DateTime(2022, 10, 21).Day,
            };
            Soul gg4 = new Soul()
            {
                name = "Прийти на пары в дистанте",
                description = "С 2 по 4 пару",
                SoulDay = new DateTime(2022, 10, 22).Day,
            };
            Soul gg5 = new Soul()
            {
                name = "Сделать практические (оч много)",
                description = "Сделать 1 и 2",
                SoulDay = new DateTime(2022, 10, 23).Day,
            };
            Soul gg6 = new Soul()
            {
                name = "Сделать практические по питону",
                description = "Доделать 1 и сделать 2",
                SoulDay = new DateTime(2022, 10, 24).Day,
            };
            Soul gg7 = new Soul()
            {
                name = "gg",
                description = "Сделать 1 и 2",
                SoulDay = new DateTime(2022, 10, 14).Day,
            };
            Soul.souls.Add(gg1);
            Soul.souls.Add(gg2);
            Soul.souls.Add(gg3);
            Soul.souls.Add(gg4);
            Soul.souls.Add(gg5);
            Soul.souls.Add(gg6);
            Soul.souls.Add(gg7);
            // нач текст без стрелки 

            ConsoleKeyInfo key = Console.ReadKey();
            // считывает нажания


            while (key.Key != ConsoleKey.Escape)
            {

                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;

                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    xposition++;

                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    xposition--;

                }
                if (position < 1)
                {
                    position = 1;
                }
                if (position > 6)
                {
                    position = 1;
                }
                Console.Clear();
                Console.SetCursorPosition(2, 0);
                Console.WriteLine($"Выбрана дата: " + selectedDate.AddDays(xposition).Day + "." + selectedDate.AddDays(xposition).Month);
                Console.SetCursorPosition(0, position);
                Console.WriteLine($"->");
                autput(key, selectedDate);
                key = Console.ReadKey();

            }


        }

        public static void autput(ConsoleKeyInfo upanddown, DateTime selectedDate)
        {
            selectedDate = selectedDate.AddDays(xposition);
            if (upanddown.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Нажмите вправо для просмотра 1 записи ");

                foreach (Soul item in Soul.souls)
                {

                    if (item.SoulDay == selectedDate.Day)
                    {
                        Console.WriteLine("=================>");
                        Console.WriteLine(item.description);

                    }

                    //selectedDate = selectedDate.AddDays(-1);
                    //if (item.SoulDay == selectedDate)
                    //{
                    //    Console.WriteLine("  " + item.name);

                    //}
                }
            }
            if (upanddown.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(2, 1);

                int o = 1;
                foreach (Soul item in Soul.souls)
                {
                    if (item.SoulDay == selectedDate.Day)
                    {
                        Console.WriteLine(" " + o + "." + item.name);
                        o++;
                    }
                }
            }


        }


    }
}


