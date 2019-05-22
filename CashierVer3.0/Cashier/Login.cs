using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string nombre = "Angel";
        public string password = "123";
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == nombre && textBox2.Text == password)
            {

                Form login = new MainView();
                login.Visible = true;
                Visible = false;
            }
            else
            {
                Login a = new Login();
                a.Visible = true;
                Visible = false;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
