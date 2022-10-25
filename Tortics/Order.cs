using System;
namespace Tortics
{
    public class Order
    {
        //дефолт конструктор, пока не трогать
        public string Form = "";
        public int Size = 0;
        public string Taste = "";
        public int Amount = 1;
        public string Glaze = "";
        public Decor Decor;

        public Order(Decor decor, int amount, string view, string color, int size)
        {
            Decor = new Decor(amount, view, color, size);
        }
    }
}

