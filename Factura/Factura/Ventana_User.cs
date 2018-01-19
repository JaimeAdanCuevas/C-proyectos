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
    public partial class Ventana_User : Formbase
    {
        public Ventana_User()
        {
            InitializeComponent();
        }

        private Login login = new Login();

        private void Ventana_User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ventana_User_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where id_usuario=" + Login.Codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);

            try
            {

                lblCodUs.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
                lblNomUs.Text = DS.Tables[0].Rows[0]["account"].ToString();
                lblUs.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

                string url = DS.Tables[0].Rows[0]["foto"].ToString();

                pictureBox1.Image = Image.FromFile(url);

            }
            catch (Exception error)
            {

                MessageBox.Show("Error " + error.Message);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
