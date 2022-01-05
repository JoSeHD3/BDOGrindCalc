using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp
{
    internal class ListaSpotow
    {
        public List<Spot> arrListaSpotow = new List<Spot>();

        public ListaSpotow() => CreateListOfAllSpots();
        public ListaItemow listaItemow = new ListaItemow();

        public void CreateListOfAllSpots()
        {
            CreateStarsEndSpot();
            CreatePollyForestSpot();
            CreatePilaKuSpot();
        }

        public void clearListOfItems()
        {
            foreach(Item o in listaItemow.listOfAllItems)
            {
                o.Quantity = 0;
            }
        }

        private void CreateStarsEndSpot()
        {
            List<Item> items = new List<Item>();
            items.Add(listaItemow.listOfAllItems[0]);
            items.Add(listaItemow.listOfAllItems[3]);
            listaItemow.AddCommonItemsToList(items);
            Spot spot = new Spot("Star's End", items);
            arrListaSpotow.Add(spot);
        }

        private void CreatePollyForestSpot()
        {
            List<Item> items = new List<Item>();
            items.Add(listaItemow.listOfAllItems[4]);
            items.Add(listaItemow.listOfAllItems[5]);
            listaItemow.AddCommonItemsToList(items);
            Spot spot = new Spot("Polly Forest", items);
            arrListaSpotow.Add(spot);
        }

        private void CreatePilaKuSpot()
        {
            List<Item> items = new List<Item>();
            items.Add(listaItemow.listOfAllItems[6]);
            listaItemow.AddCommonItemsToList(items);
            items.Add(listaItemow.listOfAllItems[7]);
            Spot spot = new Spot("Pila Ku Jail", items);
            arrListaSpotow.Add(spot);
        }

    }
}
