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

namespace InternetShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        Buyer contextBuyer;
        public RegPage( Buyer buyer)
        {
            InitializeComponent();
            contextBuyer = buyer;
            DataContext = contextBuyer;
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contextBuyer.FIO))
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            if(contextBuyer.DateOfBirth == null)
            {
                MessageBox.Show("Выберите дату рождения!");
                return;
            }
            if (string.IsNullOrWhiteSpace(contextBuyer.Address))
            {
                MessageBox.Show("Введите адрес проживания!");
                return;
            }
            if (string.IsNullOrWhiteSpace(contextBuyer.Phone))
            {
                MessageBox.Show("Введите номер телефона");
                return;
            }
            App.DB.Buyer.Add(contextBuyer);
            App.DB.SaveChanges();
            MessageBox.Show("Успешно!");
            
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
