using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp
{
    internal class Spot
    {
        public List<Item> arrListaItemow = new List<Item>();
        public string name;

        public Spot(string nazwa, List<Item> arrListaItemow)
        {
            this.name = nazwa;
            this.arrListaItemow = arrListaItemow;
        }

        override
        public string ToString()
        {
            return name;
        }
    }
}