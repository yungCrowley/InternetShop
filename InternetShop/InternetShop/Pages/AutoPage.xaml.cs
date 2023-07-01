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
    /// Логика взаимодействия для AutoPage.xaml
    /// </summary>
    public partial class AutoPage : Page
    {
        public AutoPage()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            var login = TBPhone.Text;
            var password = PBPassword.Password;
            var buyer = App.DB.Buyer.FirstOrDefault(u => u.Phone == login);
            buyer = App.DB.Buyer.FirstOrDefault(g => g.Password == password);
            var stuff = App.DB.Stuff.FirstOrDefault(u => u.Phone == login);
            stuff = App.DB.Stuff.FirstOrDefault(g => g.Password == password);
            if(stuff == null && buyer == null)
            {
               MessageBox.Show("Неправильный номер телефона или пароль!");
               return;
            }
            else
            {
                if (buyer != null)
                {
                    NavigationService.Navigate(new MainPage());
                    App.LoggedBuyer = buyer;
                }
                if (stuff != null)
                {
                    NavigationService.Navigate(new MainPage());
                    App.LoggedStuff = stuff;
                }
            }

            

            
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage(new Buyer()));
        }  
    }
}
