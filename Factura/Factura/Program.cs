using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (primeraInstancia)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
            else
            {
                MessageBox.Show("La aplicacion ya se esta ejecutando");
                Application.Exit();
            }
        
        }

        private static bool primeraInstancia
        {
            get
            {
                System.Threading.Mutex emut;
                string nombre_emut = "ApWinForms";
                bool nueva;
                emut = new System.Threading.Mutex(true, nombre_emut, out nueva);
                return nueva;
            }
        }
    }
}
