using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfTestApp
{
    internal class Item
    {
        private int quantity;
        private long price;
        private string name;
        private bool isTrash = false;
        private BitmapImage iconPath;

        public int Quantity { get => quantity; set => quantity = (int) value; }
        public string Name { get => name; set => name = value; }  
        public long Price { get => price;}
        public bool IsTrash { get => isTrash; }
        public BitmapImage IconPath { get => iconPath; set => iconPath = value; }

        public Item(long price, string name, bool isTrash, BitmapImage iconPath)
        {
            this.price = price;
            this.name = name;
            this.Quantity = 0;
            this.isTrash = isTrash;
            this.iconPath = iconPath;
        }

        public Item(string name, BitmapImage iconPath)
        {
            this.name = name;
            this.price = 0;
            this.Quantity = 0;
            this.iconPath = iconPath;
        }

        public Item(long price, string name, int quantity, bool isTrash, BitmapImage iconPath)
        {
            this.price = price;
            this.Quantity = quantity;
            this.name = name;
            this.isTrash = isTrash;
            this.iconPath = iconPath;
        }

        override
        public string ToString()
        {
            return name + ", " + Quantity;
        }

    }
}