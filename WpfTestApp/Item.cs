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
        private long price;
        private string name;
        private bool isTrash = false;

        public int Quantity { get => quantity; set => quantity = (int) value; }
        public string Name { get => name; set => name = value; }  
        public long Price { get => price;}
        public bool IsTrash { get => isTrash; }

        public Item(long price, string name, bool isTrash)
        {
            this.price = price;
            this.name = name;
            this.Quantity = 0;
            this.isTrash = isTrash;
        }

        public Item(string name)
        {
            this.name = name;
            this.price = 0;
            this.Quantity = 0;
        }

        public Item(long price, string name, int quantity, bool isTrash)
        {
            this.price = price;
            this.Quantity = quantity;
            this.name = name;
            this.isTrash = isTrash;
        }

        override
        public string ToString()
        {
            return name + ", " + Quantity;
        }

    }
}