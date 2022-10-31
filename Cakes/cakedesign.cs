using System;
namespace Cakes
{
    public class CakeDesign
    {
        public int price = 0;
        public string shape = "";
        public string size = "";
        public string taste = "";
        public string amountoflevels = "";
        public string glaze = "";
        public string decor = "";
        static public int Ck_price = 0;
        static public string Ck_shape = "";
        static public string Ck_size = "";
        static public string Ck_taste = "";
        static public string Ck_amountoflevels = "";
        static public string Ck_glaze = "";
        static public string Ck_decor = "";

        static public List<CakeDesign> CakeList = new List<CakeDesign>();
        public CakeDesign()
        {
        }
        public CakeDesign(string shape, string size, int price, string taste, string amountoflevels, string decor,string glaze)
        {
            this.shape = shape;
            this.size = size;
            this.price = price;
            this.taste = taste;
            this.amountoflevels = amountoflevels;
            this.decor = decor;
            this.glaze = glaze;
        }


        public static void Menu(int position, int thirdposition, int fourthposition, int sixthposition, int seventhposition, int eightposition)
        {
            //сделать цикл вайл с условием или пост условие что позиция не равна 7 и не нажать ентер
            Console.Clear();
            Console.WriteLine("Настройте торт\n" +
                        "  1:Форма\n" +
                        "  2:Размер\n" +
                        "  3:Вкус\n" +
                        "  4:Количество\n" +
                        "  5:Глазурь\n" +
                        "  6:Декор\n" +
                        "  7:Выход из программы\n" +
                        $"Cумма заказа {Ck_price}");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("Ваш заказ : ");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine($"{position}>");
            ConsoleKeyInfo key = Console.ReadKey();
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

                if (position < 1)
                {
                    position = 1;
                }
                if (position > 7)
                {
                    position = 1;
                }
                if (position == 7 && key.Key == ConsoleKey.Enter)
                {
                    if (Ck_shape != "" && Ck_size != "" && Ck_taste != "")
                    {
                        CakeDesign.CakeList.Add(new CakeDesign(Ck_shape, Ck_size, Ck_price, Ck_taste, Ck_amountoflevels,Ck_glaze,Ck_decor));
                        return;

                    }
                    return;

                }
                Console.Clear();
                Console.WriteLine("Настройте торт\n" +
                            "  1:Форма\n" +
                            "  2:Размер\n" +
                            "  3:Вкус\n" +
                            "  4:Количество\n" +
                            "  5:Глазурь\n" +
                            "  6:Декор\n" +
                            "  7:Выход из программы\n" +
                            $"Сумма заказа {Ck_price}");
                Console.SetCursorPosition(0, position);
                Console.WriteLine($"{position}>");
                Console.SetCursorPosition(0, 9);
                Console.Write("Ваш заказ : ");
                if (Ck_shape != "" || Ck_size != "" || Ck_taste != "" || Ck_amountoflevels != "" || Ck_decor != "" || Ck_glaze != "")
                {

                    Console.Write($"{Ck_shape}, {Ck_size}, {Ck_taste},{Ck_amountoflevels},{Ck_glaze},{Ck_decor}");
                }


                SecondMenu(key, position, CakeDesign.Ck_price, thirdposition, fourthposition, sixthposition, seventhposition, eightposition);
                Console.Clear();
                Console.WriteLine("Настройте торт\n" +
                            "  1:Форма\n" +
                            "  2:Размер\n" +
                            "  3:Вкус\n" +
                            "  4:Количество\n" +
                            "  5:Глазурь\n" +
                            "  6:Декор\n" +
                            "  7:Выход из программы\n" +
                            $"Сумма заказа {Ck_price}");
                Console.SetCursorPosition(0, position);
                Console.WriteLine($"{position}>");
                Console.SetCursorPosition(0, 9);
                Console.Write("Ваш заказ : ");
                if (Ck_shape != "" || Ck_size != "" || Ck_taste != "" || Ck_amountoflevels != "" || Ck_decor != "" || Ck_glaze != "")
                {

                    Console.Write($"{Ck_shape}, {Ck_size}, {Ck_taste},{Ck_amountoflevels},{Ck_glaze},{Ck_decor}");
                }

                key = Console.ReadKey();

            }


        }
        static string SecondMenu(ConsoleKeyInfo key, int secondposition, int price, int thirdposition, int fourhtposition, int sixthposition, int seventhposition, int eightposition)
        {

            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter && secondposition == 1)
            {
                Console.Clear();
                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Вы выбрали формулу\n" +
                        "  1:Форма сердца - 400$\n" +
                        "  2:Форма круга - 300$\n" +
                        "  3:Форма квадрата - 500$");
                    Console.SetCursorPosition(0, secondposition);
                    Console.WriteLine($"{secondposition}>");
                    key = Console.ReadKey();
                    //ConsoleKeyInfo key = Console.ReadKey();
                    while (key.Key != ConsoleKey.Escape)
                    {

                        if (key.Key == ConsoleKey.DownArrow)
                        {
                            secondposition++;
                        }
                        else if (key.Key == ConsoleKey.UpArrow)
                        {
                            secondposition--;
                        }

                        if (secondposition < 1)
                        {
                            secondposition = 1;
                        }
                        if (secondposition == 1 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_shape = "Форма сердца";
                            Ck_price += 400;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана форма сердца\n" +
                                "Если хотите перейти в меню нажмите Esc\n" +
                                $"{Ck_shape}");

                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_shape;




                        }
                        if (secondposition == 2 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_shape = "Форма круга";
                            Ck_price += 300;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана форма круга\n" +
                                "Если хотите перейти в меню нажмите Esc\n" +
                                $"{Ck_shape}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_shape;

                        }
                        if (secondposition == 3 && key.Key == ConsoleKey.Enter)
                        {


                            Ck_shape = "Форма квадрата";
                            Ck_price += 500;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана форма квадрата\n" +
                                "Если хотите перейти в меню нажмите Esc\n" +
                                $"{Ck_shape}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_shape;
                        }
                        Console.Clear();

                        Console.WriteLine("Вы выбрали формулу\n" +
                        "  1:Форма сердца - 400$\n" +
                        "  2:Форма круга - 300$\n" +
                        "  3:Форма квадрата - 500$");
                        Console.SetCursorPosition(0, secondposition);
                        Console.WriteLine($"{secondposition}>");
                        key = Console.ReadKey();
                    }


                } while (key.Key != ConsoleKey.Escape);

            }

            if (key.Key == ConsoleKey.Enter && secondposition == 2)
            {
                Console.Clear();
                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Вы выбрали размер\n" +
                        "  1:Большой размер - 500$\n" +
                        "  2:Средний размер - 400$\n" +
                        "  3:Маленький размер - 300$");
                    Console.SetCursorPosition(0, thirdposition);
                    Console.WriteLine($"{thirdposition}>");
                    key = Console.ReadKey();
                    //ConsoleKeyInfo key = Console.ReadKey();
                    while (key.Key != ConsoleKey.Escape)
                    {

                        if (key.Key == ConsoleKey.DownArrow)
                        {
                            thirdposition++;
                        }
                        else if (key.Key == ConsoleKey.UpArrow)
                        {
                            thirdposition--;
                        }

                        if (thirdposition < 1)
                        {
                            thirdposition = 1;
                        }
                        if (thirdposition == 1 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_size = "Большой размер";

                            Ck_price += 500;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Был выбран большой размер\n" +
                                "Если хотите перейти в меню нажмите Esc\n" +
                                $"{Ck_size}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            // object присваеваетс значение
                            return Ck_size;



                        }
                        if (thirdposition == 2 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_size = "Средний размер";
                            Ck_price += 400;

                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Был выбран средний размер\n" +
                                "Если хотите перейти в меню нажмите Esc\n" +
                                $"{Ck_size}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_size;
                            // object присваеваетс значение

                        }
                        if (thirdposition == 3 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_price += 300;
                            Ck_size = "Маленький размер";
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Был выбран маленький размер\n" +
                                "Если хотите перейти в меню нажмите Esc\n" +
                                $"{Ck_size}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_size;

                            // object присваеваетс значение

                        }
                        Console.Clear();

                        Console.WriteLine("Вы выбрали размер\n" +
                        "  1:Большой размер - 500$\n" +
                        "  2:Средний размер - 400$\n" +
                        "  3:Маленький размер - 300$");
                        Console.SetCursorPosition(0, thirdposition);
                        Console.WriteLine($"{thirdposition}>");
                        key = Console.ReadKey();
                    }


                } while (key.Key != ConsoleKey.Escape);
            }

            if (key.Key == ConsoleKey.Enter && secondposition == 3)
            {
                Console.Clear();
                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Вы выбрали пункт вкусов\n" +
                            "  1:Малиновый вкус - 500$\n" +
                            "  2:Клубничный вкус - 400$\n" +
                            "  3:Ванильный вкус - 300$");
                    Console.SetCursorPosition(0, fourhtposition);
                    Console.WriteLine($"{fourhtposition}>");
                    key = Console.ReadKey();
                    //ConsoleKeyInfo key = Console.ReadKey();
                    while (key.Key != ConsoleKey.Escape)
                    {

                        if (key.Key == ConsoleKey.DownArrow)
                        {
                            fourhtposition++;
                        }
                        else if (key.Key == ConsoleKey.UpArrow)
                        {
                            fourhtposition--;
                        }

                        if (fourhtposition < 1)
                        {
                            fourhtposition = 1;
                        }
                        if (fourhtposition == 1 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_taste = "Малиновый";

                            Ck_price += 500;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Был выбран вкус\n" +
                                    "Если хотите перейти в меню нажмите Esc\n" +
                                    $"{Ck_taste}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            // object присваеваетс значение
                            return Ck_taste;



                        }
                        if (fourhtposition == 2 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_taste = "Клуничный";
                            Ck_price += 400;

                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Был выбран вкус\n" +
                                   "Если хотите перейти в меню нажмите Esc\n" +
                                    $"{Ck_taste}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_taste;
                            // object присваеваетс значение


                        }

                        if (fourhtposition == 3 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_price += 300;
                            Ck_taste = "Ванильный";
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Был выбран вкус\n" +
                                    "Если хотите перейти в меню нажмите Esc\n" +
                                    $"{Ck_taste}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_taste;

                            // object присваеваетс значение

                        }
                        Console.Clear();

                        Console.WriteLine("Вы выбрали пункт вкусов\n" +
                            "  1:Малиновый вкус - 500$\n" +
                            "  2:Клубничный вкус - 400$\n" +
                            "  3:Ванильный вкус - 300$");
                        Console.SetCursorPosition(0, fourhtposition);
                        Console.WriteLine($"{fourhtposition}>");
                        key = Console.ReadKey();
                    }


                } while (key.Key != ConsoleKey.Escape);
                // так же как и сверху сделать (думаю ) ток еще вызывать другой
                // метод для того чтобы отпределять позицию стрелки и в
                // зависимости от позиции к торту добавлялись характеристики
            }
            if (key.Key == ConsoleKey.Enter && secondposition == 4)
            {
                Console.Clear();
                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Вы выбрали пункт количество слоев\n" +
                                "  1:4 слоя - 500$\n" +
                                "  2:3 слоя - 400$\n" +
                                "  3:2 слоя - 300$");
                    Console.SetCursorPosition(0, sixthposition);
                    Console.WriteLine($"{sixthposition}>");
                    key = Console.ReadKey();
                    while (key.Key != ConsoleKey.Escape)
                    {
                        if (key.Key == ConsoleKey.DownArrow)
                        {
                            sixthposition++;
                        }
                        else if (key.Key == ConsoleKey.UpArrow)
                        {
                            sixthposition--;
                        }
                        if (sixthposition < 1)
                        {
                            sixthposition = 1;
                        }
                        if (sixthposition == 1 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_amountoflevels = "4 слоя";
                            Ck_price += 500;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Был выбран вкус\n" +
                                        "Если хотите перейти в меню нажмите Esc\n" +
                                        $"{Ck_amountoflevels}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            // object присваеваетс значение
                            return Ck_amountoflevels;
                        }
                        if (sixthposition == 2 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_amountoflevels = "3 слоя";
                            Ck_price += 400;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Был выбран вкус\n" +
                                       "Если хотите перейти в меню нажмите Esc\n" +
                                        $"{Ck_amountoflevels}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_amountoflevels;
                            // object присваеваетс значение


                        }

                        if (sixthposition == 3 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_price += 300;
                            Ck_amountoflevels = "2 слоя";
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Был выбран вкус\n" +
                                        "Если хотите перейти в меню нажмите Esc\n" +
                                        $"{Ck_amountoflevels}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_amountoflevels;

                            // object присваеваетс значение

                        }
                        Console.Clear();

                        Console.WriteLine("Вы выбрали пункт количество слоев\n" +
                                "  1:4 слоя - 500$\n" +
                                "  2:3 слоя - 400$\n" +
                                "  3:2 слоя - 300$");
                        Console.SetCursorPosition(0, sixthposition);
                        Console.WriteLine($"{sixthposition}>");
                        key = Console.ReadKey();
                    }
                } while (key.Key != ConsoleKey.Escape);
            }
            if (key.Key == ConsoleKey.Enter && secondposition == 5)
            {
                Console.Clear();
                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Вы выбрали пункт глазурь\n" +
                                "  1:Шоколадная глазурь - 500$\n" +
                                "  2:Молочная глазурь - 400$\n" +
                                "  3:Клубничная глазурь - 300$");
                    Console.SetCursorPosition(0, seventhposition);
                    Console.WriteLine($"{seventhposition}>");
                    key = Console.ReadKey();
                    //ConsoleKeyInfo key = Console.ReadKey();
                    while (key.Key != ConsoleKey.Escape)
                    {

                        if (key.Key == ConsoleKey.DownArrow)
                        {
                            seventhposition++;
                        }
                        else if (key.Key == ConsoleKey.UpArrow)
                        {
                            seventhposition--;
                        }
                        if (seventhposition < 1)
                        {
                            seventhposition = 1;
                        }
                        if (seventhposition == 1 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_glaze = "Шоколадная глазурь";

                            Ck_price += 500;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана глазурь\n" +
                                        "Если хотите перейти в меню нажмите Esc\n" +
                                        $"{Ck_glaze}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            // object присваеваетс значение
                            return Ck_glaze;



                        }
                        if (seventhposition == 2 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_glaze = "Молочная глазурь ";
                            Ck_price += 400;

                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана глазурь\n" +
                                        "Если хотите перейти в меню нажмите Esc\n" +
                                        $"{Ck_glaze}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_glaze;
                            // object присваеваетс значение


                        }

                        if (seventhposition == 3 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_price += 300;
                            Ck_glaze = "Клубничная глазурь";
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана глазурь\n" +
                                       "Если хотите перейти в меню нажмите Esc\n" +
                                       $"{Ck_glaze}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_glaze;

                            // object присваеваетс значение

                        }
                        Console.Clear();

                        Console.WriteLine("Вы выбрали пункт глазурь\n" +
                                "  1:Шоколадная глазурь - 500$\n" +
                                "  2:Молочная глазурь - 400$\n" +
                                "  3:Клубничная глазурь - 300$");
                        Console.SetCursorPosition(0, seventhposition);
                        Console.WriteLine($"{seventhposition}>");
                        key = Console.ReadKey();
                    }


                } while (key.Key != ConsoleKey.Escape);
            }
            if (key.Key == ConsoleKey.Enter && secondposition == 6)
            {
                Console.Clear();
                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Вы выбрали пункт декора\n" +
                                "  1:Декор с ягодами - 500$\n" +
                                "  2:Декор с печеньками - 400$\n" +
                                "  3:Декор с маленькой фигуркой - 300$");
                    Console.SetCursorPosition(0, eightposition);
                    Console.WriteLine($"{eightposition}>");
                    key = Console.ReadKey();
                    //ConsoleKeyInfo key = Console.ReadKey();
                    while (key.Key != ConsoleKey.Escape)
                    {

                        if (key.Key == ConsoleKey.DownArrow)
                        {
                            eightposition++;
                        }
                        else if (key.Key == ConsoleKey.UpArrow)
                        {
                            eightposition--;
                        }
                        if (eightposition < 1)
                        {
                            eightposition = 1;
                        }
                        if (eightposition == 1 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_decor = "Декор с ягодами";

                            Ck_price += 500;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана глазурь\n" +
                                        "Если хотите перейти в меню нажмите Esc\n" +
                                        $"{Ck_decor}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            // object присваеваетс значение
                            return Ck_decor;



                        }
                        if (eightposition == 2 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_decor = "Декор с печеньками";
                            Ck_price += 400;

                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана глазурь\n" +
                                        "Если хотите перейти в меню нажмите Esc\n" +
                                        $"{Ck_decor}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_decor;
                            // object присваеваетс значение


                        }

                        if (eightposition == 3 && key.Key == ConsoleKey.Enter)
                        {
                            Ck_price += 300;
                            Ck_decor = "Декор с маленькой фигуркой";
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана глазурь\n" +
                                       "Если хотите перейти в меню нажмите Esc\n" +
                                       $"{Ck_decor}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return Ck_decor;

                            // object присваеваетс значение

                        }
                        Console.Clear();
                        Console.WriteLine("Вы выбрали пункт декора\n" +
                                "  1:Декор с ягодами - 500$\n" +
                                "  2:Декор с печеньками - 400$\n" +
                                "  3:Декор с маленькой фигуркой - 300$");
                        Console.SetCursorPosition(0, eightposition);
                        Console.WriteLine($"{eightposition}>");
                        key = Console.ReadKey();
                    }


                } while (key.Key != ConsoleKey.Escape);

                //выписывать их и через другой метод (сверху написал)
                // а здесь я через разные иф я буду отпределять разные пункты меню и

            }
            return "";

        }
    }
}