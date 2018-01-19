using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;

namespace Factura
{
    public partial class Login : Formbase
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string Codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * from Usuarios where account = '{0}' AND password = '{1}'"
                    , txtCuenta.Text.Trim(), txtContra.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == txtCuenta.Text.Trim() && contra == txtContra.Text.Trim()) 
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]))
                    {
                        Ventana_admin admin = new Ventana_admin();
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        Ventana_User user = new Ventana_User();
                        this.Hide();
                        user.Show();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Usuario o contrasena incorrecta...!");
                txtContra.Clear();
                txtCuenta.Clear();
                txtCuenta.Focus();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtCuenta.Focus();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
