using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int cantAvailable { get; set; }

        public Product(int Id, string Name, double Price, int CantAvailable)
        {
            id = Id;
            name = Name;
            price = Price;
            cantAvailable = CantAvailable;
        }

        public Product()
        {

        }
    }
}
