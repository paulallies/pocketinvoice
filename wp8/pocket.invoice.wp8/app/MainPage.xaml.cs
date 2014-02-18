using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using app.Resources;

namespace app
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void onClick_Invoices(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Invoices.xaml", UriKind.Relative));

        }

        private void onClick_Clients(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Clients.xaml", UriKind.Relative));
        }
    }
}