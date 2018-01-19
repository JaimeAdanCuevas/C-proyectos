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
    public partial class Ventana_admin : Formbase
    {
        public Ventana_admin()
        {
            InitializeComponent();
        }

        private Login login = new Login();

        private void Ventana_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ventana_admin_Load(object sender, EventArgs e)
        {

            try
            {
                string cmd = "Select * from Usuarios where id_usuario=" + Login.Codigo;

                DataSet DS = Utilidades.Ejecutar(cmd);

                lblAdmin.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
                lblUsAdmin.Text = DS.Tables[0].Rows[0]["account"].ToString();
                lblCodAdmin.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

                string url = DS.Tables[0].Rows[0]["foto"].ToString();

                pictureBox1.Image = Image.FromFile(url);
            }
            catch (Exception error)
            {

                MessageBox.Show("error : " + error.Message);
            }    

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
