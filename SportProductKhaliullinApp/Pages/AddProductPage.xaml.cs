using Microsoft.Win32;
using SportProductKhaliullinApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace SportProductKhaliullinApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        public static Products products = new Products();
        public static List<Categories> categories { get; set; }
        public AddProductPage()
        {
            InitializeComponent();
            categories = new List<Categories>(DbConnection.sportProductDbEntities.Categories.ToList());
            this.DataContext = this;
        }

        private void AddImageBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
            };
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                products.ImageUrl= File.ReadAllBytes(openFileDialog.FileName);
                ProductImg.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            products.Name = NameTb.Text;
            products.Description = DescriptionTb.Text;  
            products.Price = Convert.ToDecimal(PriceTb.Text);
            products.Stock = Convert.ToInt32(StockTb.Text);
            products.CategoryID = (CategoryCmb.SelectedItem as Categories).CategoryID;
            DbConnection.sportProductDbEntities.Products.Add(products);
            DbConnection.sportProductDbEntities.SaveChanges();
            MessageBox.Show($"Товар {NameTb.Text} добавлен успешно");
            NavigationService.Navigate(new ProductsListPage());
        }
    }
}
