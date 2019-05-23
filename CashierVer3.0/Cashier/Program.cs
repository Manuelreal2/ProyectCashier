using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

namespace Cashier
{


    static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());

            //User u = new User(1, "admin", "root", "12345", 0);
            //Database s = new Database();
            //s.userList.Add(u);
            // Aqui hago los usuarios
            List<User> theUsers = new List<User>
            {
                new User(101, "Manuel Angel Real Castro", "Manuel101", "123456", 1),
                new User(102, "Angel Jaziell Garcia Fernandez", "Angell02", "654321", 0)
            };

            using (Stream fs = new FileStream(@"C:\Users\lolpo\Documents\Users.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<User>));
                serializer2.Serialize(fs, theUsers);
            }

            XmlSerializer serializer3 = new XmlSerializer(typeof(List<User>));

            using (FileStream fs2 = File.OpenRead(@"C:\Users\lolpo\Documents\Users.xml"))
            {
                theUsers = (List<User>)serializer3.Deserialize(fs2);
            }
            ////////////////////Aqui hago la lista de productos
            List<Product> theProducts = new List<Product>
            {
                new Product("Desodorante", 51.1, 1, 55),
                new Product("Leche", 55, 2, 15),
                new Product("Audifonos", 120, 3, 40),
                new Product("Cereal", 48, 4, 30),
                new Product("jenga", 250, 5, 10),
            };

            using (Stream fs = new FileStream(@"C:\Users\lolpo\Documents\Products.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer4 = new XmlSerializer(typeof(List<Product>));
                serializer4.Serialize(fs, theUsers);
            }

            // Delete list data
            theProducts = null;

            // Read data from XML
            XmlSerializer serializer5 = new XmlSerializer(typeof(List<Product>));

            using (FileStream fs2 = File.OpenRead(@"C:\Users\lolpo\Documents\Products.xml"))
            {
                theProducts = (List<Product>)serializer5.Deserialize(fs2);
            }
        }
    }
}
