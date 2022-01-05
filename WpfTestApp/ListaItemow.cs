using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp
{
    internal class ListaItemow
    {
        public List<Item> listOfAllItems = new List<Item>();
        public ListaItemow() => LoadAllItems();
        public void LoadAllItems()
        {
            listOfAllItems.Add(new Item(15500, "Sanguine Crystal of Despair", true));               //0
            listOfAllItems.Add(new Item(150000, "Black Stone (Armor)", false));                     //1
            listOfAllItems.Add(new Item(150000, "Black Stone (Weapon)", false));                    //2
            listOfAllItems.Add(new Item(18370000, "Clear Blackstar Crystal", false));               //3
            listOfAllItems.Add(new Item(1955, "Mushroom Hypha", true));                             //4
            listOfAllItems.Add(new Item(2500000, "Pure Forest Breath", false));                     //5
            listOfAllItems.Add(new Item(16400, "Warder's Token Piece", true));                      //6
            listOfAllItems.Add(new Item(3300000, "Scroll Written in Ancient Language", false));     //7
        }

        public void AddCommonItemsToList(List<Item> items)
        {
            items.Add(listOfAllItems[1]);
            items.Add(listOfAllItems[2]);
        }

    }
}
