using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saludo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bt_saludo_click(object sender, EventArgs e)
        {
            etSaludo.Text = "Hola mundo";
            etSaludo.BackColor = Color.Blue;
        }
    }
}
