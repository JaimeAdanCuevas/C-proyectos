using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ventana_login
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txt_id.Focus();

            if (File.Exists("Login.txt"))
            {

            }
            else
            {
                TextWriter inicio;

                inicio = new StreamWriter("Login.txt");
                inicio.WriteLine("Usuario \t contrasena" + "\n");
                inicio.Close();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_contra.Text) || string.IsNullOrEmpty(txt_id.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                btn_iniciar.Enabled = false;

                return;

            }
            else
            {
                StreamWriter escribir = File.AppendText("Login.txt");

                escribir.WriteLine(txt_id.Text + "\t\t" + txt_contra.Text);

                escribir.Close();

                txt_id.Clear();
                txt_contra.Clear();

                MessageBox.Show("Usuario guardado con exito en la base de datos");
                
            }
            
        }

        private void txt_contra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text) == false)
            {
                btn_iniciar.Enabled = true;
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_contra.Text) == false)
            {
                btn_iniciar.Enabled = true;
            }
        }
    }
}
