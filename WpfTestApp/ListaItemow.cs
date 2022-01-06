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
            listOfAllItems.Add(new Item(15500, "Sanguine Crystal of Despair", true, CreateImage("../items/SanguineCrystalOfDespair.png")));                     //0
            listOfAllItems.Add(new Item(150000, "Black Stone (Armor)", false, CreateImage("../items/BlackStoneArmor.png")));                                    //1
            listOfAllItems.Add(new Item(150000, "Black Stone (Weapon)", false, CreateImage("../items/BlackStoneWeapon.png")));                                  //2
            listOfAllItems.Add(new Item(18370000, "Clear Blackstar Crystal", false, CreateImage("../items/ClearBlackstarCrystal.png")));                        //3
            listOfAllItems.Add(new Item(1955, "Mushroom Hypha", true, CreateImage("../items/MushroomHypha.png")));                                              //4
            listOfAllItems.Add(new Item(2500000, "Pure Forest Breath", false, CreateImage("../items/PureForestBreath.png")));                                   //5
            listOfAllItems.Add(new Item(16400, "Warder's Token Piece", true, CreateImage("../items/WardersTokenPiece.png")));                                   //6
            listOfAllItems.Add(new Item(3300000, "Scroll Written in Ancient Language", false, CreateImage("../items/ScrollWrittenInAncientLanguage.png")));     //7
            listOfAllItems.Add(new Item(6000000, "Black Magic Crystal - Precision", false, CreateImage("../items/BlackMagicCrystal_Precision.png")));           //8
            listOfAllItems.Add(new Item(319000000, "Black Distortion Earring", false, CreateImage("../items/BlackDistortionEarring.png")));                     //9
            listOfAllItems.Add(new Item("Ancient Spirit Dust", CreateImage("../items/AncientSpiritDust.png")));                                                 //10
            listOfAllItems.Add(new Item(2800000, "Caphras Stone", false, CreateImage("../items/CaphrasStone.png")));                                            //11
            listOfAllItems.Add(new Item(60000, "Trace of Origin", false, CreateImage("../items/TraceOfOrigin.png")));                                           //12
            listOfAllItems.Add(new Item(46700000, "Manos Craftsman's Clothes", false, CreateImage("../items/ManosCraftsmansClothes.png")));                     //13
            listOfAllItems.Add(new Item(900000, "Lemoria Armor", false, CreateImage("../items/LemoriaArmor.png")));                                             //14
            listOfAllItems.Add(new Item(900000, "Lemoria Shoes", false, CreateImage("../items/LemoriaShoes.png")));                                             //15
            listOfAllItems.Add(new Item(2700000, "Life Spirit Stone", false, CreateImage("../items/LifeSpiritStone.png")));                                     //16
            listOfAllItems.Add(new Item(680000, "Manshaum Voodoo Doll", false, CreateImage("../items/ManshaumVoodooDoll.png")));                                //17
            listOfAllItems.Add(new Item(60000, "Trace of Forest", false, CreateImage("../items/TraceOfForest.png")));                                           //18
            listOfAllItems.Add(new Item(50000, "Water Spirit Stone Fragment", true, CreateImage("../items/WaterSpiritStoneFragment.png")));                     //19
            listOfAllItems.Add(new Item(100000, "Dew of Tranquil Forest", true, CreateImage("../items/DewOfTranquilForest.png")));                              //20
            listOfAllItems.Add(new Item(51000, "Mass of Pure Magic", true, CreateImage("../items/MassOfPureMagic.png")));                                       //21
            listOfAllItems.Add(new Item(30000000, "Specter's Energy", true, CreateImage("../items/SpectersEnergy.png")));                                       //22
            listOfAllItems.Add(new Item(6000000, "Black Magic Crystal - Swiftness", false, CreateImage("../items/BlackMagicCrystal_Swiftness.png")));           //23
            listOfAllItems.Add(new Item(47000, "Trace of Violence", false, CreateImage("../items/TraceOfViolence.png")));                                       //24
            listOfAllItems.Add(new Item(9700000, "Sicil's Necklace", false, CreateImage("../items/SicilsNecklace.png")));                                       //25
            listOfAllItems.Add(new Item(10000, "Sicil's Shattered Necklace", false, CreateImage("../items/SicilsShatteredNecklace.png")));                      //26
            listOfAllItems.Add(new Item(4870000, "Black Spirit's Claw Piece", false, CreateImage("../items/BlackSpiritsClawPiece.png")));                       //27
            listOfAllItems.Add(new Item(810000, "Part for Explorer's Compass", false, CreateImage("../items/PartForExplorersCompass.png")));                    //28
            listOfAllItems.Add(new Item(50000, "Yona's Fragment", true, CreateImage("../items/YonasFragment.png")));                                            //29
            listOfAllItems.Add(new Item(540000, "Traveler's Map", false, CreateImage("../items/TravelersMap.png")));                                            //30
            listOfAllItems.Add(new Item("Map of Unknown Piece", CreateImage("../items/MapOfUnknownPiece.png")));                                                //31
        }

        public void AddCommonItemsToList(List<Item> items)
        {
            items.Add(listOfAllItems[1]);
            items.Add(listOfAllItems[2]);
            items.Add(listOfAllItems[10]);
            items.Add(listOfAllItems[11]);
            items.Add(listOfAllItems[21]);
            items.Add(listOfAllItems[22]);
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
