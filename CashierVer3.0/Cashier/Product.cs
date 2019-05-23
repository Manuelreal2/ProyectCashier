using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cashier
{
    [Serializable()]
    public class Product : ISerializable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }
        public int Prdavailable { get; set; }


        public Product() { }

        public Product(
            string name = "No name",
            double price = 0,
            int id = 0,
            int prdavailable = 0)
        {
            Name = name;
            Price = price;
            Id = id;
            Prdavailable = prdavailable;
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("Name", Name);
            info.AddValue("Price", Price);
            info.AddValue("Id", Id);
            info.AddValue("Prdavailable", Prdavailable);
        }

        // The deserialize function (Removes Object Data from File)
        public Product(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            Name = (string)info.GetValue("Name", typeof(string));
            Price = (double)info.GetValue("Price", typeof(double));
            Id = (int)info.GetValue("Id", typeof(int));
            Prdavailable = (int)info.GetValue("Prdavailable", typeof(int));
        }
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

