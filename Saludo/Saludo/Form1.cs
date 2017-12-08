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
        private Label etsal;
        private Button btnsal;
        private ToolTip des;

        public Form1()
        {
            InitializeComponent();
            etsal = new Label();
            {
                etsal.Name = "Saludo";
                etsal.Text = "etiqueta";
                etsal.TextAlign = ContentAlignment.TopCenter;
                etsal.Font = new Font("Microsoft Sans Serif",14, FontStyle.Regular);
                etsal.Location = new Point(30, 10);
                etsal.Size = new Size(187, 35);
                etsal.TabIndex = 1;
                Controls.Add(etsal);
             }
            btnsal = new Button();
            {
                des = new ToolTip();
                btnsal.Text = "Pincha&me";
                btnsal.Name = "boton";
                btnsal.TabIndex = 0;
                btnsal.Location = new Point(40, 200);
                des.SetToolTip(btnsal, "Cambia el color de una etiqueta");
                this.btnsal.Click += new System.EventHandler(this.btnsal_Click);
                Controls.Add(btnsal);
            }
        }

        private void btnsal_Click(object sender, EventArgs e)
        {
            etsal.Text = "Eres listo0";
            etsal.ForeColor = Color.Red;
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
