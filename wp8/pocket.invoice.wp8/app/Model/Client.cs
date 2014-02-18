using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Cell { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
    }
}
