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
using InternetShop.Pages;
using InternetShop.models;

namespace InternetShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        void Refresh()
        {
            if (App.LoggedStuff == null)
                AddBtn.Visibility = Visibility.Collapsed;
            
        }

        private void ManCloth_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LVPage());
        }

        private void WomanCloth_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LVWomanPage());
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProductPage(new Product()));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Номер телефона поддержки +7 (974) 920-94-68");
        }

        private void LimitedBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LimitedPage());
        }
    }
}
