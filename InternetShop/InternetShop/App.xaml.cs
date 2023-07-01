using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using InternetShop.models;

namespace InternetShop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static StarShopEntities DB = new StarShopEntities();
        public static Buyer LoggedBuyer;
        public static Stuff LoggedStuff;
    }


}
