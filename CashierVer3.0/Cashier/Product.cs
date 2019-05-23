using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cashier
{
    public class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }
        public int Prdavailable { get; set; }


        public Product() { }

        public Product(
            int id,
            string name,
            double price, 
            int prdavailable )
        {
            Id = id;
            Name = name;
            Price = price;
            Prdavailable = prdavailable;
        }


        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    // Assign key value pair for your data
        //    info.AddValue("Name", Name);
        //    info.AddValue("Price", Price);
        //    info.AddValue("Id", Id);
        //    info.AddValue("Prdavailable", Prdavailable);
        //}

        //// The deserialize function (Removes Object Data from File)
        //public Product(SerializationInfo info, StreamingContext ctxt)
        //{
        //    //Get the values from info and assign them to the properties
        //    Name = (string)info.GetValue("Name", typeof(string));
        //    Price = (double)info.GetValue("Price", typeof(double));
        //    Id = (int)info.GetValue("Id", typeof(int));
        //    Prdavailable = (int)info.GetValue("Prdavailable", typeof(int));
        //}
    }
}
