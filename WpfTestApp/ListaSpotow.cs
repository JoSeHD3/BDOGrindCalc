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

        public void CreateListOfAllSpots()
        {
            CreateStarsEndSpot();
            CreatePollyForestSpot();
            CreatePilaKuSpot();
        }

        private void CreateStarsEndSpot()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(15500, "Sanguine Crystal of Despair", true));
            items.Add(new Item("Black Stone (Armor)"));
            items.Add(new Item("Black Stone (Weapon)"));
            items.Add(new Item(18370000, "Clear Blackstar Crystal", false));
            Spot spot = new Spot("Star's End", items);
            arrListaSpotow.Add(spot);
        }

        private void CreatePollyForestSpot()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(1955, "Mushroom Hypha", true));
            items.Add(new Item("Black Stone (Armor)"));
            items.Add(new Item("Black Stone (Weapon)"));
            items.Add(new Item(2500000, "Pure Forest Breath", false));
            Spot spot = new Spot("Polly Forest", items);
            arrListaSpotow.Add(spot);
        }

        private void CreatePilaKuSpot()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(16400, "Warder's Token Piece", true));
            items.Add(new Item("Black Stone (Armor)"));
            items.Add(new Item("Black Stone (Weapon)"));
            items.Add(new Item(3300000, "Scroll Written in Ancient Language", false));
            Spot spot = new Spot("Pila Ku Jail", items);
            arrListaSpotow.Add(spot);
        }

    }
}
