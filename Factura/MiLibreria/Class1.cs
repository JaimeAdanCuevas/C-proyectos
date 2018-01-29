using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);

            DP.Fill(DS);
            con.Close();

            return DS;
        }

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider errorProvider)
        {
            Boolean HayErrores = false;

            foreach (Control Item in Objeto.Controls)
            {
                if(Item is errorTxtBox)
                {
                    errorTxtBox obj = (errorTxtBox)Item;

                    if (obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            errorProvider.SetError(obj, "No puede estar vacio");

                            HayErrores = true;
                        }
                    }
                    
                    if(obj.solo_Numeros == true)
                    {
                        int cont = 0, LetrasE = 0;

                        foreach(char letra in obj.Text.Trim())
                        {
                            if(char.IsLetter(obj.Text.Trim(), cont)){
                                LetrasE++;
                            }
                            cont ++;
                        }
                        if(LetrasE != 0)
                        {
                            HayErrores = true;

                            errorProvider.SetError(obj, "Solo numeros");
                        }
                    }

                }
            }

            return HayErrores;

        }

    }
}
