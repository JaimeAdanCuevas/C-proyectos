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
    public partial class Consultas : Formbase
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public DataSet LlenarDataGV(string tabla)
        {
            DataSet ds;

            string cmd = string.Format("Select * from " + tabla);

            ds = Utilidades.Ejecutar(cmd);


            return ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
