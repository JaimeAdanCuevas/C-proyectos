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
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private void MantenimientoCliente_Shown(object sender, EventArgs e)
        {
            txt_id_cli.Focus();
        }

        public override bool Guardar()
        {
            if(Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizaClientes '{0}', '{1}', '{2}'",
                        txt_id_cli.Text.Trim(), txtnomcli.Text.Trim(), txtapelclie.Text.Trim());


                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Usuario guardado con exito en la base de datos");

                    txtapelclie.Clear();
                    txtnomcli.Clear();
                    txt_id_cli.Clear();

                    return true;
                }
                catch (Exception e)
                {

                    MessageBox.Show("Ha habido un error en la actualizacion: " + e.Message);

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
                if(MessageBox.Show("Estas seguro que deseas borrar el cliente", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string cmd = string.Format("EXEC EliminarClientes '{0}'", txt_id_cli.Text.Trim());

                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Se ha borrado correctamente!!!");
                }

                txt_id_cli.Clear();
        
            }
            catch (Exception error)
            {

                MessageBox.Show("Sucedio un problema: " + error.Message);
            }
        }

        private void txt_id_cli_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtnomcli_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtapelclie_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
