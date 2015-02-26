using FirmaFakturka.Model;
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
using System.Windows.Shapes;

namespace FirmaFakturka.Faktury
{
    /// <summary>
    /// Interaction logic for CreateInvoice.xaml
    /// </summary>
    public partial class CreateInvoice : Window
    {
        public CreateInvoice()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var previewInvoice = new ReviewInvoice();
            previewInvoice.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var addClientFromList = new AddClientFromList();
            FirmaContext ctx = new FirmaContext();

            addClientFromList.ListOfClients.ItemsSource = ctx.Clients.ToList();
            addClientFromList.Show();
        }
    }
}
