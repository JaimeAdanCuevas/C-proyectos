namespace Factura
{
    partial class MantenimientoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_cli = new MiLibreria.errorTxtBox();
            this.txtnomcli = new MiLibreria.errorTxtBox();
            this.txtapelclie = new MiLibreria.errorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 80);
            this.button1.Size = new System.Drawing.Size(120, 31);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 120);
            this.button2.Size = new System.Drawing.Size(120, 31);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 160);
            this.button3.Size = new System.Drawing.Size(120, 32);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(448, 200);
            this.button4.Size = new System.Drawing.Size(120, 32);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "APELLIDO:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "NOMBRE :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID CLIENTE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_id_cli
            // 
            this.txt_id_cli.Location = new System.Drawing.Point(200, 88);
            this.txt_id_cli.Name = "txt_id_cli";
            this.txt_id_cli.Size = new System.Drawing.Size(120, 20);
            this.txt_id_cli.solo_Numeros = true;
            this.txt_id_cli.TabIndex = 20;
            this.txt_id_cli.Validar = true;
            this.txt_id_cli.TextChanged += new System.EventHandler(this.txt_id_cli_TextChanged);
            // 
            // txtnomcli
            // 
            this.txtnomcli.Location = new System.Drawing.Point(200, 144);
            this.txtnomcli.Name = "txtnomcli";
            this.txtnomcli.Size = new System.Drawing.Size(120, 20);
            this.txtnomcli.solo_Numeros = false;
            this.txtnomcli.TabIndex = 21;
            this.txtnomcli.Validar = true;
            this.txtnomcli.TextChanged += new System.EventHandler(this.txtnomcli_TextChanged);
            // 
            // txtapelclie
            // 
            this.txtapelclie.Location = new System.Drawing.Point(200, 200);
            this.txtapelclie.Name = "txtapelclie";
            this.txtapelclie.Size = new System.Drawing.Size(120, 20);
            this.txtapelclie.solo_Numeros = false;
            this.txtapelclie.TabIndex = 22;
            this.txtapelclie.Validar = true;
            this.txtapelclie.TextChanged += new System.EventHandler(this.txtapelclie_TextChanged);
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 355);
            this.Controls.Add(this.txtapelclie);
            this.Controls.Add(this.txtnomcli);
            this.Controls.Add(this.txt_id_cli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoCliente";
            this.Text = "MantenimientoCliente";
            this.Shown += new System.EventHandler(this.MantenimientoCliente_Shown);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnCerrar_sesion, 0);
            this.Controls.SetChildIndex(this.btnContenedor_pri, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_id_cli, 0);
            this.Controls.SetChildIndex(this.txtnomcli, 0);
            this.Controls.SetChildIndex(this.txtapelclie, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MiLibreria.errorTxtBox txt_id_cli;
        private MiLibreria.errorTxtBox txtnomcli;
        private MiLibreria.errorTxtBox txtapelclie;
    }
}