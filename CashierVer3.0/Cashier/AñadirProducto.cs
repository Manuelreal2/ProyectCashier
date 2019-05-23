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
    public partial class AñadirProducto : Form
    {
        public AñadirProducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainView a = new MainView();
            a.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean validate = true;
            try
            {
                Product p = new Product(int.Parse(textBox1.Text),textBox2.Text,double.Parse(textBox3.Text), int.Parse(textBox4.Text));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"{ex.GetType().Name}: Tipo de dato Invalido o Valores Vacios");
                validate = false;
            }
            finally
            {
                if (validate == true)
                {
                    System.Windows.Forms.MessageBox.Show("El usuario se añadio con exito");
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }
    }
}
