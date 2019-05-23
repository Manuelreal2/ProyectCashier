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
            Application.Run(new Login());

            //User u = new User(1, "admin", "root", "12345", 0);
            //Storage s = new Storage();
            //s.userList.Add(u);
        }
    }

    //public class Storage
    //{
    //    public List<User> userList;
    //    public List<Product> productList;
    //}
}
