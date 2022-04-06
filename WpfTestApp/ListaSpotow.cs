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
            CreateAakmanTemple();
            CreateAbandonedMonastery();
            CreateAltarImpHabitat();
            CreateAshForest();
            CreateBashimBase();
            CreateBasiliskDen();
            CreateBiraghiDen();
            CreateBloodWolfSetlement();
            CreateBloodyMonastery();
            CreateCadryRuins();
            CreateCastleRuins();
            CreateCentaurusHerd();
            CreateCrescentShrine();
            CreateCryptOfRestingThoughts();
            CreateDesertNagaTemple();
            CreateFadusHabitat();
            CreateGahazBanditsLair();
            CreateGyfinRhasiaTemple();
            CreateHystriaRuins();
            CreateKratugaAncientRuins();
            CreateManshaumForest();
            CreateMarieCave();
            CreateMirumokRuins();
            CreateNavarnSteppe();
            CreateOllunsValley();
            CreateOrcCamp();
            CreatePadixIsland();
            CreatePilaKuSpot();
            CreatePollyForestSpot();
            CreateProttyCave();
            CreateRoudSulfurMine();
            CreateSherekhanNecropolis();
            CreateShultzGuard();
            CreateStarsEndSpot();
            CreateSwampFoganHabitat();
            CreateSwampNagaHabitat();
            CreateSycraiaAbyssalRuins();
            CreateThornwoodForest();
            CreateTitiumValley();
            CreateToothFairyForest();
            CreateTshiraRuins();
            CreateTunkuta();
            CreateUpperSycraiaAbyssalRuins();
            CreateWaragonNest();
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
            items.Add(listaItemow.listOfAllItems[8]);
            items.Add(listaItemow.listOfAllItems[9]);
            items.Add(listaItemow.listOfAllItems[12]);
            items.Add(listaItemow.listOfAllItems[5]);
            CreateSpot("Star's End", items);
        }

        private void CreatePollyForestSpot()
        {
            List<Item> items = new List<Item>();
            items.Add(listaItemow.listOfAllItems[4]);
            items.Add(listaItemow.listOfAllItems[5]);
            items.Add(listaItemow.listOfAllItems[13]);
            items.Add(listaItemow.listOfAllItems[14]);
            items.Add(listaItemow.listOfAllItems[15]);
            items.Add(listaItemow.listOfAllItems[16]);
            items.Add(listaItemow.listOfAllItems[17]);
            items.Add(listaItemow.listOfAllItems[18]);
            items.Add(listaItemow.listOfAllItems[19]);
            items.Add(listaItemow.listOfAllItems[20]);
            CreateSpot("Polly Forest", items);
        }

        private void CreatePilaKuSpot()
        {
            List<Item> items = new List<Item>();
            items.Add(listaItemow.listOfAllItems[6]);
            items.Add(listaItemow.listOfAllItems[7]);
            items.Add(listaItemow.listOfAllItems[23]);
            items.Add(listaItemow.listOfAllItems[24]);
            items.Add(listaItemow.listOfAllItems[25]);
            items.Add(listaItemow.listOfAllItems[26]);
            items.Add(listaItemow.listOfAllItems[27]);
            items.Add(listaItemow.listOfAllItems[28]);
            items.Add(listaItemow.listOfAllItems[29]);
            items.Add(listaItemow.listOfAllItems[30]);
            items.Add(listaItemow.listOfAllItems[31]);
            CreateSpot("Pila ku Jail", items);
        }

        private void CreateOrcCamp()
        {
            List<Item> items = new List<Item>();
            items.Add(listaItemow.listOfAllItems[32]);
            items.Add(listaItemow.listOfAllItems[33]);
            items.Add(listaItemow.listOfAllItems[34]);
            items.Add(listaItemow.listOfAllItems[35]);
            items.Add(listaItemow.listOfAllItems[36]);
            items.Add(listaItemow.listOfAllItems[37]);
            items.Add(listaItemow.listOfAllItems[38]);
            items.Add(listaItemow.listOfAllItems[39]);
            items.Add(listaItemow.listOfAllItems[40]);
            CreateSpot("Orc Camp", items);
        }

        private void CreateSwampFoganHabitat()
        {
            List<Item> items = new List<Item>();
            items.Add(listaItemow.listOfAllItems[41]);
            items.Add(listaItemow.listOfAllItems[42]);
            items.Add(listaItemow.listOfAllItems[43]);
            items.Add(listaItemow.listOfAllItems[33]);
            items.Add(listaItemow.listOfAllItems[44]);
            items.Add(listaItemow.listOfAllItems[45]);
            items.Add(listaItemow.listOfAllItems[46]);
            items.Add(listaItemow.listOfAllItems[47]);
            items.Add(listaItemow.listOfAllItems[48]);
            items.Add(listaItemow.listOfAllItems[49]);
            items.Add(listaItemow.listOfAllItems[50]);
            items.Add(listaItemow.listOfAllItems[51]);
            items.Add(listaItemow.listOfAllItems[52]);
            items.Add(listaItemow.listOfAllItems[53]);
            items.Add(listaItemow.listOfAllItems[40]);
            CreateSpot("Swamp Fogan Habitat", items);
        }

        private void CreateSwampNagaHabitat()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Swamp Naga Habitat", items);
        }
        private void CreateCryptOfRestingThoughts()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Crypt of Resting Thoughts", items);
        }

        private void CreateBiraghiDen()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Biraghi Den", items);
        }

        private void CreateAshForest()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Ash Forest", items);
        }

        private void CreateSycraiaAbyssalRuins()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Sycraia Abyssal Ruins", items);
        }

        private void CreateHystriaRuins()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Hystria Ruins", items);
        }

        private void CreateAakmanTemple()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Aakman Temple", items);
        }

        private void CreateKratugaAncientRuins()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Kratuga Ancient Ruins", items);
        }

        private void CreateBloodyMonastery()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Bloody Monastery", items);
        }

        private void CreateThornwoodForest()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Thornwood Forest", items);
        }
        private void CreateGahazBanditsLair()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Gahaz Bandit's Lair", items);
        }

        private void CreateCentaurusHerd()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Centaurus Herd", items);
        }

        private void CreateCadryRuins()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Cadry Ruins", items);
        }

        private void CreateCrescentShrine()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Crescent Shrine", items);
        }

        private void CreateBashimBase()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Bashim Base", items);
        }

        private void CreateDesertNagaTemple()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Desert Naga Temple", items);
        }

        private void CreateCastleRuins()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Castle Ruins", items);
        }

        private void CreateAltarImpHabitat()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Altar Imp Habitat", items);
        }

        private void CreateAbandonedMonastery()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Abandoned Monastery", items);
        }

        private void CreateTunkuta()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Tunkuta", items);
        }

        private void CreatePadixIsland()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Padix Island", items);
        }

        private void CreateTitiumValley()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Titium Valley", items);
        }

        private void CreateOllunsValley()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Ollun's Valley", items);
        }

        private void CreateMirumokRuins()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Mirumok Ruins", items);
        }

        private void CreateGyfinRhasiaTemple()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Gyfin Rhasia Temple", items);
        }

        private void CreateBasiliskDen()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Basilisk Den", items);
        }

        private void CreateWaragonNest()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Waragon Nest", items);
        }

        private void CreateBloodWolfSetlement()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Blood Wolf Setlement", items);
        }

        private void CreateSherekhanNecropolis()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Sherekhan Necropolis", items);
        }

        private void CreateToothFairyForest()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Tooth Fairy Forest", items);
        }

        private void CreateTshiraRuins()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Tshira Ruins", items);
        }

        private void CreateManshaumForest()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Manshaum Forest", items);
        }

        private void CreateRoudSulfurMine()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Roud Sulfur Mine", items);
        }

        private void CreateUpperSycraiaAbyssalRuins()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Upper Sycraia Abyssal Ruins", items);
        }

        private void CreateShultzGuard()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Shultz Guard", items);
        }

        private void CreateProttyCave()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Protty Cave", items);
        }

        private void CreateFadusHabitat()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Fadus Habitat", items);
        }

        private void CreateNavarnSteppe()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Navarn Steppe", items);
        }

        private void CreateMarieCave()
        {
            List<Item> items = new List<Item>();
            CreateSpot("Marie Cave", items);
        }

        private void CreateSpot(string name, List<Item> items)
        {
            listaItemow.AddCommonItemsToList(items);
            Spot spot = new Spot(name, items);
            arrListaSpotow.Add(spot);
        }
    }
}