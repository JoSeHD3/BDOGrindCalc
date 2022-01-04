using System;
using System.Collections.Generic;
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

namespace WpfTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListaSpotow listaSpotow = new ListaSpotow();

        public MainWindow()
        {
            InitializeComponent();
            icListaSpotow.ItemsSource = listaSpotow.arrListaSpotow;
        }

        private void icListaSpotow_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Spot takeover  = (Spot)btn.DataContext;
            if (takeover != null)
            {
                if (lbListaItemow.ItemsSource != null)
                {
                    lbListaItemow.ItemsSource = null;
                    lbListaItemow.ItemsSource = takeover.arrListaItemow;
                    
                }
                else
                {
                    lbListaItemow.ItemsSource = takeover.arrListaItemow;
                }
            }
        }

    }
}
