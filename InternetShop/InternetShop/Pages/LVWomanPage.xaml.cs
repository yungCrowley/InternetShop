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
    /// Логика взаимодействия для LVWomanPage.xaml
    /// </summary>
    public partial class LVWomanPage : Page
    {
        List<OrderProduct> orderProducts = new List<OrderProduct>();
        Product contextProduct = new Product();
        public LVWomanPage()
        {
            InitializeComponent();
            DataContext = orderProducts;
            CBWomanClothType.ItemsSource = App.DB.Subcategories.ToList();
            Refresh();
        }

        void Refresh()
        {
            DGBucket.ItemsSource = orderProducts.ToList();
            var filtred = App.DB.Product.Where(n => n.CategoryID == 2).ToList();
            var filtredType = CBWomanClothType.SelectedItem as Subcategories;
            if (filtredType != null)
            {
                filtred = filtred.Where(n => n.SubcategoryID == filtredType.ID).ToList();
            }
            LVWoman.ItemsSource = filtred;

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
            else
            {
                MessageBox.Show("Заказ успешно оформлен!");
            }
            App.DB.OrderProduct.AddRange(orderProducts);
            App.DB.SaveChanges();
            
        }

        private void TextBlock_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Refresh();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CBWomanClothType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var deleteProduct = LVWoman.SelectedItem as Product;
            if(deleteProduct == null)
            {
                MessageBox.Show("Выберите продукт, который хотите удалить!");
                return;
            }
            App.DB.Product.Remove(deleteProduct);
            App.DB.SaveChanges();
            Refresh();

        }
    }
}
