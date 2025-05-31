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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportProductKhaliullinApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isMenuExpanded = true;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new Pages.ProductsListPage());
        }
        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProductsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (isMenuExpanded)
            {
                var collapse = (Storyboard)this.Resources["CollapseMenu"];
                collapse.Begin();
            }
            else
            {
                var expand = (Storyboard)this.Resources["ExpandMenu"];
                expand.Begin();
            }

            isMenuExpanded = !isMenuExpanded;
        }
    }
}
