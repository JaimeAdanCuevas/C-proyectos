using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace Factura
{
    public partial class consultarProductos : Consultas
    {
        public consultarProductos()
        {
            InitializeComponent();
        }

        private void consultarProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDataGV("Articulo").Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;

                    string cmd = "Select * from Articulo where Nom_pro like ('%" + textBox1.Text.Trim() + "%') ";

                    ds = Utilidades.Ejecutar(cmd);

                    dataGridView1.DataSource = ds.Tables[0];

                }
                catch (Exception error)
                {

                    MessageBox.Show("hubo un error " + error.Message);
                }
            }
        }

        private void consultarProductos_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
