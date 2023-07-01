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
    /// Логика взаимодействия для AddLimitedProduct.xaml
    /// </summary>
    public partial class AddLimitedProduct : Page
    {
        Limited contextLimited;
        public AddLimitedProduct(Limited limited)
        {
            InitializeComponent();
            contextLimited = limited;
            DataContext = contextLimited;
            CBManufacturer.ItemsSource = App.DB.Manufacturer.ToList();

        }

        void Refresh()
        {
            var filtred = App.DB.Limited.ToList();
        }
        private void ChangeImageBtn_Click(object sender, RoutedEventArgs e)
        {
            var limited = (sender as Button).DataContext as Limited;
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                limited.Image = File.ReadAllBytes(dialog.FileName);
                App.DB.SaveChanges();
                Refresh();
            }

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contextLimited.Name))
            {
                MessageBox.Show("Введите название продукта!");
                return;

            }

            if (string.IsNullOrWhiteSpace(contextLimited.Discription))
            {
                MessageBox.Show("Добавьте описание продукта!");
                return;
            }

            if (contextLimited.Price == 0)
            {
                MessageBox.Show("Введите цену продукта!");
                return;
            }

            if (contextLimited.Manufacturer == null)
            {
                MessageBox.Show("Выберите бренд!");
                return;

            }
            App.DB.Limited.Add(contextLimited);
            App.DB.SaveChanges();
            MessageBox.Show("Продукция успешно добавлена!");
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
