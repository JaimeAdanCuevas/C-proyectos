using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void nuevo(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form();
            f.SetBounds(400, 400, 400, 400);
            f.Show();
            f.Text = "Nuevo";
            f.Name = "Form3";
        }
    }
}
