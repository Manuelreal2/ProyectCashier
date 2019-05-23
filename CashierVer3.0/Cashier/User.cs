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
    public class User : ISerializable
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Usertype { get; set; }

        public User() { }

        public User(int id = 101,
            string fullname = "No name",
            string username = "No uname",
            string password = "No password",
            int usertype = 0)
        {
            Id = id;
            Fullname = fullname;
            Username = username;
            Password = password;
            Usertype = usertype;
        }

        public override string ToString()
        {
            return string.Format("{0} weighs {1} lbs and is {2} inches tall",
                Fullname, Username, Id);
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("Id", Id);
            info.AddValue("Fullname", Fullname);
            info.AddValue("Username", Username);
            info.AddValue("Password", Password);
            info.AddValue("Usertype", Usertype);
        }

        // The deserialize function (Removes Object Data from File)
        public User(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            Id = (int)info.GetValue("Id", typeof(int));
            Fullname = (string)info.GetValue("Fullname", typeof(string));
            Username = (string)info.GetValue("Username", typeof(string));
            Password = (string)info.GetValue("Password", typeof(string));
            Usertype = (int)info.GetValue("Usertype", typeof(int));
        }
    }
}
