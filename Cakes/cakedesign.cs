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
        public CakeDesign(string shape,string size, int price)
        {
            this.shape = shape;
            this.size = size;
            this.price = price;
        }


        public static void Menu(int position)
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
                Console.WriteLine("Ваш заказ : ");
                foreach (CakeDesign dis in CakeList)
                {
                    Console.Write($"{dis.shape},{dis.size}");

                }
                

                SecondMenu(key, position,CakeDesign.Ck_price);
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
                Console.WriteLine("Ваш заказ : ");
                foreach (CakeDesign dis in CakeList)
                {
                    Console.Write($"{dis.shape},{dis.size}");
                }
                
                key = Console.ReadKey();

            }


        }
        static string SecondMenu(ConsoleKeyInfo key, int secondposition,int price)
        {
            // как вернуть занчение и выписать его в menu и еще почему красным светиться при стринге 

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
                            var shape = "Форма сердца - 400$";
                            Ck_price += 400;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана форма сердца\n" +
                                "Если хотите перейти в меню нажмите Esc\n" +
                                $"{shape}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            // object присваеваетс значение
                            return shape;
                            



                        }
                        if (secondposition == 2 && key.Key == ConsoleKey.Enter)
                        {
                            var shape = "Форма круга - 300$";
                            Ck_price += 300;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана форма круга\n" +
                                "Если хотите перейти в меню нажмите Esc\n" +
                                $"{shape}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return shape;
                            // object присваеваетс значение

                        }
                        if (secondposition == 3 && key.Key == ConsoleKey.Enter)
                        {
                            

                            var shape = "Форма квадрата - 500$";
                            Ck_price += 500;
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Была выбрана форма квадрата\n" +
                                "Если хотите перейти в меню нажмите Esc\n" +
                                $"{shape}");
                            Console.WriteLine($"Сумма заказа {Ck_price}");
                            Thread.Sleep(1500);
                            Console.Clear();
                            return shape;

                            // object присваеваетс значение

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
                                var size = "Большой размер - 500$";
                                
                                Ck_price += 500;
                                Console.SetCursorPosition(0, 4);
                                Console.WriteLine("Был выбран большой размер\n" +
                                    "Если хотите перейти в меню нажмите Esc\n" +
                                    $"{size}");
                                Console.WriteLine($"Сумма заказа {Ck_price}");
                                Thread.Sleep(1500);
                                Console.Clear();
                                // object присваеваетс значение
                                return size;



                            }
                            if (secondposition == 2 && key.Key == ConsoleKey.Enter)
                            {
                            var size = "Средний размер - 400$";
                            Ck_price += 400;
                                
                                Console.SetCursorPosition(0, 4);
                                Console.WriteLine("Был выбран средний размер\n" +
                                    "Если хотите перейти в меню нажмите Esc\n" +
                                    $"{size}");
                                Console.WriteLine($"Сумма заказа {Ck_price}");
                                Thread.Sleep(1500);
                                Console.Clear();
                                return size;
                                // object присваеваетс значение

                            }
                            if (secondposition == 3 && key.Key == ConsoleKey.Enter)
                            {
                                Ck_price += 300;
                                var size = "Маленький размер - 300$";
                                Console.SetCursorPosition(0, 4);
                                Console.WriteLine("Был выбран маленький размер\n" +
                                    "Если хотите перейти в меню нажмите Esc\n" +
                                    $"{size}");
                                Console.WriteLine($"Сумма заказа {Ck_price}");
                                Thread.Sleep(1500);
                                Console.Clear();
                                return size;

                                // object присваеваетс значение

                            }
                            Console.Clear();

                            Console.WriteLine("Вы выбрали размер\n" +
                            "  1:Большой размер - 500$\n" +
                            "  2:Средний размер - 400$\n" +
                            "  3:Маленький размер - 300$");
                            Console.SetCursorPosition(0, secondposition);
                            Console.WriteLine($"{secondposition}>");
                            key = Console.ReadKey();
                        }


                } while (key.Key != ConsoleKey.Escape);
                    //if (key.Key == ConsoleKey.Escape)
                    //{

                    //}
                    //else
                    //{
                    //    //foreach будет возможно

                    //}
                    // так же как и сверху сделать (думаю ) ток еще вызывать другой
                    // метод для того чтобы отпределять позицию стрелки и в
                    // зависимости от позиции к торту добавлялись характеристики
            
                
                // а здесь я через разные иф я буду отпределять разные пункты меню и
                //выписывать их и через другой метод (сверху написал)
            }
            return"";
        }
    }
}
