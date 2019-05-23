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
    public partial class AñadirUsuario : Form
    {
        public AñadirUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainView a = new MainView();
            a.Visible = true;
            Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean validate = true;
            try
            {
                User u = new User(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, int.Parse(textBox5.Text));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"{ex.GetType().Name}: Tipo de dato Invalido o Valores Vacios");
                validate = false;
            }
            finally
            {
                if(validate == true)
                {
                    System.Windows.Forms.MessageBox.Show("El usuario se añadio con exito");
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }
    }
}
