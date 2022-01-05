using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListaSpotow listaSpotow = new ListaSpotow();
        private Spot takeover;
        DispatcherTimer timer = new DispatcherTimer();
        Stopwatch stopwatch = new Stopwatch();
        private string currentTime = string.Empty;
        private double totalMinutes = 0;

        public MainWindow()
        {
            InitializeComponent();
            icListaSpotow.ItemsSource = listaSpotow.arrListaSpotow;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                TimeSpan ts = stopwatch.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                    ts.Hours, ts.Minutes, ts.Seconds);
                labTimer.Content = currentTime;
            }
        }

        private void btnStartStopwatch_Click(object sender, RoutedEventArgs e)
        {
            if (takeover != null)
            {
                stopwatch.Start();
                timer.Start();
            }
        }

        private void btnStopStopwatch_Click(object sender, RoutedEventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                totalMinutes = stopwatch.Elapsed.TotalMinutes;
            }
        }

        private void icListaSpotow_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button) sender;
            takeover  = (Spot) btn.DataContext;
            if (takeover != null)
            {
                lbListaItemow.ItemsSource = null;
                lbListaItemow.ItemsSource = takeover.arrListaItemow;
                stopwatch.Reset();
                listaSpotow.clearListOfItems();
                labTimer.Content = "00:00:00";
            }
            
        }

        private void btnCalculateData_Click(object sender, RoutedEventArgs e)
        {
            CalculationsHandler calculationsHandler = new CalculationsHandler(takeover);
            if(lbListaItemow.ItemsSource != null)
            {
                if (stopwatch.IsRunning)
                {
                    stopwatch.Stop();
                }

                calculationsHandler.CalculatedSilverPerHour = (long) (calculationsHandler.CalculatedTotalSilverTaxed / (totalMinutes / 60));
                calculationsHandler.CalculatedSilverPerHourText = calculationsHandler.CalculatedSilverPerHour.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de"));

                labInfoText.Visibility = Visibility.Visible;
                labCalculatedTotalSilverText.Content = "Total Silver: " + calculationsHandler.CalculatedTotalSilverText;
                labCalculatedTrashSilverText.Content = "Total Trash Silver: " + calculationsHandler.CalculatedTrashSilverText;
                labCalculatedMarketSilverText.Content = "Total Marketplace Silver: " + calculationsHandler.CalculatedMarketSilverText;
                labCalculatedMarketSilverTaxedText.Content = "Total Marketplace Silver After Tax: " + calculationsHandler.CalculatedMarketSilverTaxedText;
                labCalculatedTotalSilverTaxedText.Content = "Total Silver after Tax: " + calculationsHandler.CalculatedTotalSilverTaxedText;
                labCalculatedSilverPerHourText.Content = "Silver per hour: " + calculationsHandler.CalculatedSilverPerHourText;
            }
        }

    }
}
