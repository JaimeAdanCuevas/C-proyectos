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
    public partial class MantenimientoProducto : Mantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }

        public override bool Guardar()
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {

                try
                {
                    string cmd = string.Format("EXEC ActualizaArticulos '{0}', '{1}', '{2}'",
                        txtidpro.Text.Trim(), txtdescrip.Text.Trim(), txtprecio.Text.Trim());

                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Se ha guardado correctamente!!");

                    return true;
                }

                catch (Exception error)
                {
                    MessageBox.Show("ha ocurrido un error" + error.Message);
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public override void Eliminar()
        {

            try
            {
              if (MessageBox.Show("Esta seguro que desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string cmd = string.Format("EXEC EliminarArticulos '{0}'", txtidpro.Text.Trim());

                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Eliminado con exito!!");
                }

                txtidpro.Clear();
            }
            catch (Exception error)
            {

                MessageBox.Show("ha ocurrido un error" + error.Message);
            }
        }

        private void MantenimientoProducto_Shown(object sender, EventArgs e)
        {
            txtidpro.Focus();
        }

        private void txtidpro_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtdescrip_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
