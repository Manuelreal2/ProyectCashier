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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView1.Columns["OPCION"].Index)
                return;

            dataGridView1.Rows.RemoveAt(e.RowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new object[] {"","","","","","Eliminar"});
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AñadirUsuario b = new AñadirUsuario();
            b.Visible = true;
            Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarUsuario c = new EliminarUsuario();
            c.Visible = true;
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AñadirProducto q = new AñadirProducto();
            q.Visible = true;
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EliminarProducto w = new EliminarProducto();
            w.Visible = true;
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
