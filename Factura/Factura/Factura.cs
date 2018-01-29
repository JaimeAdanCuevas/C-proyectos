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
    public partial class Factura : Procesos
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            try
            {
                string cmd = "Select * from Usuarios where id_usuario=" + Login.Codigo;

                DataSet ds;

                ds = Utilidades.Ejecutar(cmd);

                lblAtiende.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();

            }
            catch (Exception error)
            {

                MessageBox.Show("error " + error.Message);
            }
        }

        private void errorTxtBox4_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void errorTxtBox6_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void errorTxtBox5_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void errorTxtBox7_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCodigo.Text) == false)
            {
                try
                {
                    string cmd = string.Format("select Nom_cli from Cliente where id_clientes= '{0}'",
                        lblCodigo.Text.Trim());

                    DataSet ds = Utilidades.Ejecutar(cmd);

                    lblCliente.Text = ds.Tables[0].Rows[0]["Nom_cli"].ToString().Trim();

                    txtCodigo.Focus();
                }
                catch (Exception error)
                {

                    MessageBox.Show("ha ocurrido un error " + error.Message);
                }
            }
        }

        public static int contadorFilas = 0;
        public static double total;

        private void btnColocar_Click(object sender, EventArgs e)
        {
            if(Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                bool Existe = false;
                int num_fila = 0;

                if(contadorFilas == 0)
                {
                    dataGridView1.Rows.Add(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);

                    double importe = Convert.ToDouble(dataGridView1.Rows[contadorFilas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFilas].Cells[3].Value);

                    dataGridView1.Rows[contadorFilas].Cells[4].Value = importe;

                    contadorFilas++;
                }
                else
                {
                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if(Fila.Cells[0].Value.ToString() == txtCodigo.Text)
                        {
                            Existe = true;
                            num_fila = Fila.Index;
                        }
                    }

                    if(Existe == true)
                    {
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);

                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);

                        double importe = Convert.ToDouble(dataGridView1.Rows[contadorFilas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFilas].Cells[3].Value);

                        dataGridView1.Rows[contadorFilas].Cells[4].Value = importe;

                        contadorFilas++;
                    }

                }
                total = 0;

                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);

                }
                lblTotal.Text = "$ " + total.ToString();
                txtCantidad.Clear();
                txtCodigo.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtCodigo.Focus();
            }
        }

        private void lblCodigo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void lblCliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(contadorFilas > 0)
            {
                total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lblTotal.Text = "$ " + total.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                contadorFilas --;

                txtCodigo.Focus();
            }
        }
    }
}
