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
using InternetShop.Pages;
using System.IO;
using Microsoft.Win32;

namespace InternetShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        Product contextProduct;
        public AddProductPage( Product product)
        {
            InitializeComponent();
            contextProduct = product;
            DataContext = contextProduct;
            CBManufacturer.ItemsSource = App.DB.Manufacturer.ToList();
            CBCategory.ItemsSource = App.DB.Category.ToList();
            CBSubCategory.ItemsSource = App.DB.Subcategories.ToList();

        }

       

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(contextProduct.Name))
            {
                MessageBox.Show("Введите название продукта!");
                return;
                    
            }

            if (string.IsNullOrWhiteSpace(contextProduct.Description))
            {
                MessageBox.Show("Добавьте описание продукта!");
                return;
            }

            if (contextProduct.Price == 0)
            {
                MessageBox.Show("Введите цену продукта!");
                return;
            }

            if (contextProduct.Manufacturer == null)
            {
                MessageBox.Show("Выберите бренд!");
                return;

            }
            if (contextProduct.Category == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }
            if (contextProduct.Subcategories == null)
            {
                MessageBox.Show("Выберите подкатегорию");
                return;
            }
            App.DB.Product.Add(contextProduct);
            App.DB.SaveChanges();
            MessageBox.Show("Продукция успешно добавлена!");
            
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        void Refresh()
        {
            var filtred = App.DB.Product.ToList();
        }
        private void ChangeImageBtn_Click(object sender, RoutedEventArgs e)
        {
            var product = (sender as Button).DataContext as Product;
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                product.Image = File.ReadAllBytes(dialog.FileName);
                App.DB.SaveChanges();
                Refresh();
            }
        }
    }
}
