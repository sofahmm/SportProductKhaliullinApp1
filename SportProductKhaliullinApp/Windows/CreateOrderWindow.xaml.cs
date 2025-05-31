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
    /// Логика взаимодействия для CreateOrderWindow.xaml
    /// </summary>
    public partial class CreateOrderWindow : Window
    {
        public List<Customers> customers { get; set; }
        public List<Manager> manager { get; set; }
        public CreateOrderWindow()
        {
            InitializeComponent();
            customers = new List<Customers>(DbConnection.sportProductDbEntities.Customers.ToList());
            manager = new List<Manager>(DbConnection.sportProductDbEntities.Manager.ToList());
            this.DataContext = this;
        }

        private void AddCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomerFr.NavigationService.Navigate(new Pages.CreateCustomerPage());
        }

        private void CreateOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();
            orders.CustomerID = (NamePCmb.SelectedItem as Customers).CustomerID;
            orders.OrderDate = OrderDateDp.SelectedDate;
            orders.ManagerID = (ManagerCmb.SelectedItem as Manager).ManagerID;
            orders.TotalAmount = Convert.ToInt32(TotalAmountTb.Text);
            DbConnection.sportProductDbEntities.Orders.Add(orders);
            DbConnection.sportProductDbEntities.SaveChanges();
            MessageBox.Show("Успешно!");
        }

        private void TudaBtn_Click(object sender, RoutedEventArgs e)
        {
            KorzinaWindow korzinaWindow = new KorzinaWindow();
            korzinaWindow.Show();
        }
    }
}
