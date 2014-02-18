using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using app.ViewModel;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace app
{
    public partial class Clients : PhoneApplicationPage
    {
        public Clients()
        {
            InitializeComponent();
            DataContext = App.ClientCollectionViewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ClientCollectionViewModel.IsDataLoaded)
            {
                App.ClientCollectionViewModel.LoadData();
            }
        }

        private void MainLongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If selected item is null (no selection) do nothing
            if (MainLongListSelector.SelectedItem == null)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?selectedItem=" + (MainLongListSelector.SelectedItem as ClientViewModel).ID, UriKind.Relative));

            // Reset selected item to null (no selection)
            MainLongListSelector.SelectedItem = null;
        }
    }
}