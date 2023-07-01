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
using InternetShop.models;

namespace InternetShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для LimitedPage.xaml
    /// </summary>
    public partial class LimitedPage : Page
    {
        List<OrderProduct> orderProducts = new List<OrderProduct>();
        Limited contextLimited = new Limited();

        public LimitedPage()
        {
            InitializeComponent();
            DataContext = orderProducts;
        }
        void Refresh()
        {
            DGBucket.ItemsSource = orderProducts;
            LVLimited.ItemsSource = App.DB.Limited.ToList();

            if(App.LoggedStuff == null)
            {
                DeleteBtn.Visibility = Visibility.Collapsed;
            }
            if(App.LoggedStuff == null)
            {
                AddLimited.Visibility = Visibility.Collapsed;

            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var deleteLimited = LVLimited.SelectedItem as Limited;
            if (deleteLimited == null)
            {
                MessageBox.Show("Выберите продукт, который хотите удалить! ");
                return;

            }
            App.DB.Limited.Remove(deleteLimited);
            App.DB.SaveChanges();
            Refresh();

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if(orderProducts.Count == 0)
            {
                MessageBox.Show("Корзина пуста!");
                return;
            }
            App.DB.OrderProduct.AddRange(orderProducts);
            App.DB.SaveChanges();
        }

        private void AddToBucket_Click(object sender, RoutedEventArgs e)
        {
            var price = (sender as Button).DataContext as Limited;
            
        }

        private void AddLimited_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddLimitedProduct(new Limited()));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
