using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using app.Model;

namespace app.ViewModel
{
    public class ClientViewModel : INotifyPropertyChanged
    {
        private int _id;
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _contact;
        public string Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                if (value != _contact)
                {
                    _contact = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value != _email)
                {
                    _email = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private string _telephone;
        public string Telephone
        {
            get
            {
                return _telephone;
            }
            set
            {
                if (value != _telephone)
                {
                    _telephone = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private string _cell;
        public string Cell
        {
            get
            {
                return _cell;
            }
            set
            {
                if (value != _cell)
                {
                    _cell = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _billingAddress;
        public string BillingAddress
        {
            get
            {
                return _billingAddress;
            }
            set
            {
                if (value != _billingAddress)
                {
                    _billingAddress = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _shippingAddress;
        public string ShippingAddress
        {
            get
            {
                return _shippingAddress;
            }
            set
            {
                if (value != _shippingAddress)
                {
                    _shippingAddress = value;
                    NotifyPropertyChanged();
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
