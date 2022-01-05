using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfTestApp
{
    internal class ListaItemow
    {
        public List<Item> listOfAllItems = new List<Item>();
        public ListaItemow() => LoadAllItems();
        public void LoadAllItems()
        {
            listOfAllItems.Add(new Item(15500, "Sanguine Crystal of Despair", true, CreateImage("../items/SanguineCrystalOfDespair.png")));                    //0
            listOfAllItems.Add(new Item(150000, "Black Stone (Armor)", false, CreateImage("../items/BlackStoneArmor.png")));                                   //1
            listOfAllItems.Add(new Item(150000, "Black Stone (Weapon)", false, CreateImage("../items/BlackStoneWeapon.png")));                                 //2
            listOfAllItems.Add(new Item(18370000, "Clear Blackstar Crystal", false, CreateImage("../items/ClearBlackstarCrystal.png")));                       //3
            listOfAllItems.Add(new Item(1955, "Mushroom Hypha", true, CreateImage("../items/MushroomHypha.png")));                                             //4
            listOfAllItems.Add(new Item(2500000, "Pure Forest Breath", false, CreateImage("../items/PureForestBreath.png")));                                  //5
            listOfAllItems.Add(new Item(16400, "Warder's Token Piece", true, CreateImage("../items/WardersTokenPiece.png")));                                  //6
            listOfAllItems.Add(new Item(3300000, "Scroll Written in Ancient Language", false, CreateImage("../items/ScrollWrittenInAncientLanguage.png")));    //7
        }

        public void AddCommonItemsToList(List<Item> items)
        {
            items.Add(listOfAllItems[1]);
            items.Add(listOfAllItems[2]);
        }
        
        private BitmapImage CreateImage(string path)
        {
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.UriSource = new Uri(path, UriKind.Relative);
            src.CacheOption = BitmapCacheOption.OnLoad;
            src.EndInit();

            return src;
        }

    }
}
