using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string symbol = "";
        string f = "";
        int win = 0;
        int countofclicks= 0;
        Random random = new Random();
        int[] array = new int[9];
        Button[] btn = new Button[9];
        public MainWindow()
        {
            InitializeComponent();
            btn[0] = button_1;
            btn[1] = button_2;
            btn[2] = button_3;
            btn[3] = button_4;
            btn[4] = button_5;
            btn[5] = button_6;
            btn[6] = button_7;
            btn[7] = button_8;
            btn[8] = button_9;
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if(symbol == "Крестики")
            {
                for (int i = 0; i< btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Content = "X";
                        //symbol = "Нолики";
                        btn[i].IsEnabled = false;
                        array[i] = 1;
                        maintext.Content = "Нолики ходят";
                        countofclicks += 1;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Content = "O";
                        //symbol = "Крестики";
                        btn[i].IsEnabled = false;
                        array[i] = 2;
                        maintext.Content = "Крестики ходят";
                        countofclicks += 1;
                        break;
                    }
                }
            }
            aboba();
            if(win != 1)
            {
                bot();
                aboba();
            }
            
            
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            countofclicks = 0;
            win = 0;
            for(int i=0;i<btn.Length;i++)
            {
                array[i] = 0;
                btn[i].Content = " ";
                
                btn[i].IsEnabled = true;
            }
            if (random.Next(1, 10) <= 5)
            { 
                if (f == "" || f == "cross")
                {
                    symbol = "Крестики";
                    maintext.Content = "Первыми ходят X";
                    f = "oval";
                }
                else
                {
                    symbol = "Нолики";
                    maintext.Content = "Первыми ходят O";
                    f = "cross";
                }
            }
            else
            {
                if (f == "" || f == "oval")
                {
                    symbol = "Нолики";
                    maintext.Content = "Первыми ходят O";
                    f = "cross";
                }
                else
                {
                    symbol = "Крестики";
                    maintext.Content = "Первыми ходят X";
                    f = "oval";
                }


            }
        }
        public void aboba()
        {
            if ((array[0] == 1 && array[1] == 1 && array[2] == 1)
               || (array[3] == 1 && array[4] == 1 && array[5] == 1)
               || (array[6] == 1 && array[7] == 1 && array[8] == 1)
               || (array[0] == 1 && array[3] == 1 && array[6] == 1)
               || (array[1] == 1 && array[4] == 1 && array[7] == 1)
               || (array[2] == 1 && array[5] == 1 && array[8] == 1)
               || (array[0] == 1 && array[4] == 1 && array[8] == 1)
               || (array[2] == 1 && array[4] == 1 && array[6] == 1)
               || (array[8] == 1 && array[4] == 1 && array[0] == 1)
               || (array[6] == 1 && array[4] == 1 && array[2] == 1))
            //0 1 2
            //3 4 5
            //6 7 8
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                start.IsEnabled = true;
                maintext.Content = "Выиграли крестики";
                win = 1;
            }
            if ((array[0] == 2 && array[1] == 2 && array[2] == 2)
                || (array[3] == 2 && array[4] == 2 && array[5] == 2)
                || (array[6] == 2 && array[7] == 2 && array[8] == 2)
                || (array[0] == 2 && array[3] == 2 && array[6] == 2)
                || (array[1] == 2 && array[4] == 2 && array[7] == 2)
                || (array[2] == 2 && array[5] == 2 && array[8] == 2)
                || (array[0] == 2 && array[4] == 2 && array[8] == 2)
                || (array[2] == 2 && array[4] == 2 && array[6] == 2)
                || (array[8] == 2 && array[4] == 2 && array[0] == 2)
                || (array[6] == 2 && array[4] == 2 && array[2] == 2))
            //0 1 2
            //3 4 5
            //6 7 8
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                start.IsEnabled = true;
                maintext.Content = "Выиграли Нолики";
                win = 1;
            }
            if (countofclicks == 9)
            {
                //__________________________-----------______-------________---------________
                if ((array[0] == 2 && array[4] == 2 && array[8] == 2)
                 || (array[2] == 2 && array[4] == 2 && array[6] == 2)
                 || (array[8] == 2 && array[4] == 2 && array[0] == 2)
                 || (array[6] == 2 && array[4] == 2 && array[2] == 2))
                {
                    //0 1 2
                    //3 4 5
                    //6 7 8
                    maintext.Content = "Выиграли Нолики";
                    win = 1;
                }
                else if ((array[0] == 1 && array[4] == 1 && array[8] == 1)
                 || (array[2] == 1 && array[4] == 1 && array[6] == 1)
                 || (array[8] == 1 && array[4] == 1 && array[0] == 1)
                 || (array[6] == 1 && array[4] == 1 && array[2] == 1))
                {
                    maintext.Content = "Выиграли Крестики";
                    win = 1;
                }
                else
                {

                    maintext.Content = "Ничья";
                    win = 1;
                }

            }
        }
        public void bot()
        {
            if (f == "oval")
            {
                //Круг тюк f показывает какой будет значек пользователя
                int b = random.Next(1, 10);
                /*while (btn[b].IsEnabled = true) { 
                    b = random.Next(1, 10);
                }*/
                btn[b].Content = "O";
                
                btn[b].IsEnabled = false;
                array[b] = 2;
                maintext.Content = "Крестики ходят";
                countofclicks += 1;
            }
            else if(f == "cross")
            {
                int c = random.Next(1, 10);
                /*while (btn[c].IsEnabled = true) { 
                    c = random.Next(1, 10);
                }*/
                btn[c].Content = "X";
                //symbol = "Нолики";
                btn[c].IsEnabled = false;
                array[c] = 1;
                maintext.Content = "Нолики ходят";
                countofclicks += 1;
            }
        }
    }
}
