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
using FirmaFakturka.Faktury;
using FirmaFakturka.Model;

namespace FirmaFakturka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        public void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FirmaContext ctx = new FirmaContext();
            //ChinookEntities ent = new ChinookEntities();
            this.testGrid.ItemsSource = ctx.Clients.ToList();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var createInvoice = new CreateInvoice();
            createInvoice.Show();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
