using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace app.ViewModel
{
    public class ClientCollectionViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<ClientViewModel> Items { get; private set; }

        public ClientCollectionViewModel()
        {
            this.Items = new ObservableCollection<ClientViewModel>();
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ClientViewModel() { ID = 0, Name = "Client One" });
            this.Items.Add(new ClientViewModel() { ID = 1, Name = "Client Two" });
            this.Items.Add(new ClientViewModel() { ID = 2, Name = "Client Three" });
            this.Items.Add(new ClientViewModel() { ID = 3, Name = "Client Four" });

            this.IsDataLoaded = true;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
