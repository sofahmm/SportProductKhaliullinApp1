using SportProductKhaliullinApp.Models;
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

namespace SportProductKhaliullinApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для KorzinaWindow.xaml
    /// </summary>
    public partial class KorzinaWindow : Window
    {
        public List<Products> products { get; set; }
        public List<OrderItems> orders { get; set; }
        public KorzinaWindow()
        {
            InitializeComponent();
            products = new List<Products>(DbConnection.sportProductDbEntities.Products.ToList());
            orders = new List<OrderItems>(DbConnection.sportProductDbEntities.OrderItems.ToList());
            this.DataContext = this;

        }

        private void MinusShtukaBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PlusShtukaBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddProdBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderItems orderItems = new OrderItems();
            orderItems.ProductID = (NameProductCmb.SelectedItem as Products).ProductID;
            DbConnection.sportProductDbEntities.SaveChanges();
            OrderLv.ItemsSource = new List<OrderItems>(DbConnection.sportProductDbEntities.OrderItems.ToList());
        }
    }
}
