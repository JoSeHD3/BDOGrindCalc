using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp
{
    internal class Item
    {
        private int quantity;
        public long price;
        private string name;

        public int Quantity { get => quantity; set => quantity = (int) value; }
        public string Name { get => name; set => name = value; }  

        public Item(long price, string name)
        {
            this.price = price;
            this.name = name;
            this.Quantity = 0;
        }

        public Item(string name)
        {
            this.name = name;
            this.price = 0;
            this.Quantity = 0;
        }

        public Item(long price, string name, int quantity)
        {
            this.price = price;
            this.Quantity = quantity;
            this.name = name;
        }

        override
        public string ToString()
        {
            return name + ", " + Quantity;
        }

    }
}