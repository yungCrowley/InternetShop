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
    /// Логика взаимодействия для LVPage.xaml
    /// </summary>
    public partial class LVPage : Page
    {
        List<OrderProduct> orderProducts = new List<OrderProduct>();
        Product contextProduct = new Product();
        public LVPage()
        {
            InitializeComponent();
            DataContext = orderProducts;
            ManClothType.ItemsSource = App.DB.Subcategories.ToList();
            Refresh();
        }

        void Refresh()
        {         
            DGBucket.ItemsSource = orderProducts;

            var filtred = App.DB.Product.Where(n => n.CategoryID == 1).ToList();
            var filtredType = ManClothType.SelectedItem as Subcategories;

            if(filtredType != null)
            {
                filtred = filtred.Where(n => n.SubcategoryID == filtredType.ID).ToList();
            }
            LVMan.ItemsSource = filtred.ToList();

           if(App.LoggedStuff == null)
            {
                DeleteBtn.Visibility = Visibility.Collapsed;
            }
        }

        private void AddToBucket_Click(object sender, RoutedEventArgs e)
        {
            var price = (sender as Button).DataContext as Product;
            orderProducts.Add(new OrderProduct { Product = (sender as Button).DataContext as Product, Buyer = App.LoggedBuyer, Price = price.Price });
            Refresh();
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        { 
           if (orderProducts.Count == 0)
            {
              MessageBox.Show("Корзина пуста!");
              return;
            }
                App.DB.OrderProduct.AddRange(orderProducts);
           App.DB.SaveChanges();
            MessageBox.Show("Заказ успешно оформлен!");
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ManClothType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var deleteProduct = LVMan.SelectedItem as Product;
            if (deleteProduct == null)
            {
                MessageBox.Show("Выберите продукт, который хотите удалить! ");
                return;

            }
            App.DB.Product.Remove(deleteProduct);
            App.DB.SaveChanges();
            Refresh();
        }
    }
}
