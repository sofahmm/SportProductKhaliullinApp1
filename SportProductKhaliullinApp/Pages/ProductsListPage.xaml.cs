using SportProductKhaliullinApp.Models;
using SportProductKhaliullinApp.Windows;
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

namespace SportProductKhaliullinApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductsListPage.xaml
    /// </summary>
    public partial class ProductsListPage : Page
    {
        public static List<Products> products { get; set; }
        public ProductsListPage()
        {
            InitializeComponent();
            products = new List<Products>(DbConnection.sportProductDbEntities.Products.ToList());
            this.DataContext = this;
        }

        private void MinusShtukaBtn_Click(object sender, RoutedEventArgs e)
        {
            var t = sender as TextBox;
           
        }

        private void PlusShtukaBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProductsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void KorzinaBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateOrderWindow createOrderWindow = new CreateOrderWindow();
            createOrderWindow.Show();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
