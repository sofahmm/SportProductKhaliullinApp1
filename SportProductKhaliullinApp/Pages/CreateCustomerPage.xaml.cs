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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportProductKhaliullinApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreateCustomerPage.xaml
    /// </summary>
    public partial class CreateCustomerPage : Page
    {
        public CreateCustomerPage()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Customers customer = new Customers();
            customer.FirstName = FirstnameTb.Text;
            customer.LastName = LastnameTb.Text;
            customer.Email = EmailTb.Text;
            customer.Address = AddresTb.Text;
            customer.Phone = PhoneNumberTb.Text;
            DbConnection.sportProductDbEntities.Customers.Add(customer);
            DbConnection.sportProductDbEntities.SaveChanges();
        }
    }
}
