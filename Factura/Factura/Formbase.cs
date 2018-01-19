using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Formbase : Form
    {
        public Formbase()
        {
            InitializeComponent();
        }

        Login login = new Login();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea salir? " , "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
