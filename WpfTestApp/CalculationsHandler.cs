using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp
{
    internal class CalculationsHandler
    {
        private long calculatedTotalSilver = 0;
        private string calculatedTotalSilverText;
        private long calculatedTrashSilver = 0;
        private string calculatedTrashSilverText;
        private long calculatedMarketSilver = 0;
        private string calculatedMarketSilverText;
        private long calculatedMarketSilverTaxed = 0;
        private string calculatedMarketSilverTaxedText;
        private long calculatedTotalSilverTaxed = 0;
        private string calculatedTotalSilverTaxedText;
        private long calculatedSilverPerHour = 0;
        private string calculatedSilverPerHourText;
        public CalculationsHandler(Spot currentSpot)
        {
            if (currentSpot != null)
            {
                foreach (Item i in currentSpot.arrListaItemow)
                {
                    calculatedTotalSilver += i.Price * i.Quantity;
                    if (i.IsTrash)
                        calculatedTrashSilver += i.Price * i.Quantity;
                    else
                        calculatedMarketSilver += i.Price * i.Quantity;
                }
                calculatedMarketSilverTaxed = (long)(calculatedMarketSilver * 0.845);
                calculatedTotalSilverTaxed = calculatedMarketSilverTaxed + calculatedTrashSilver;


                calculatedTotalSilverText = calculatedTotalSilver.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de"));
                calculatedMarketSilverText = calculatedMarketSilver.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de"));
                calculatedTrashSilverText = calculatedTrashSilver.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de"));
                calculatedMarketSilverTaxedText = calculatedMarketSilverTaxed.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de"));
                calculatedTotalSilverTaxedText = calculatedTotalSilverTaxed.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de"));
            }
        }

        public string CalculatedTotalSilverText { get => calculatedTotalSilverText; set => calculatedTotalSilverText = value; }
        public string CalculatedTrashSilverText { get => calculatedTrashSilverText; set => calculatedTrashSilverText = value; }
        public string CalculatedMarketSilverText { get => calculatedMarketSilverText; set => calculatedMarketSilverText = value; }
        public string CalculatedMarketSilverTaxedText { get => calculatedMarketSilverTaxedText; set => calculatedMarketSilverTaxedText = value; }
        public string CalculatedTotalSilverTaxedText { get => calculatedTotalSilverTaxedText; set => calculatedTotalSilverTaxedText = value; }
        public long CalculatedTotalSilverTaxed { get => calculatedTotalSilverTaxed; set => calculatedTotalSilverTaxed = value; }
        public long CalculatedSilverPerHour { get => calculatedSilverPerHour; set => calculatedSilverPerHour = value; }
        public string CalculatedSilverPerHourText { get => calculatedSilverPerHourText; set => calculatedSilverPerHourText = value; }
    }
}
