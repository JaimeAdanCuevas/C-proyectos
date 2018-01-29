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
    public partial class Registrase : Mantenimiento
    {
        public Registrase()
        {
            InitializeComponent();
        }

        private void Registrase_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void Registrase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
