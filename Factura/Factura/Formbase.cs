﻿using System;
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
    public partial class Formbase : Form
    {
        public Formbase()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea salir? " , "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCerrar_sesion_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea cerrar sesion?", "cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Login login = new Login();

                this.Hide();
                login.Show();
            } 
        }

        public virtual void Eliminar()
        {

        } 

        public virtual void Nuevo()
        {

        }

        public virtual void Consultar()
        {

        }

        public virtual Boolean Guardar()
        {
            return false;
        }

        private void btnContenedor_pri_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContenedorPrincipal c = new ContenedorPrincipal();
            c.Show();
        }
    }
}
