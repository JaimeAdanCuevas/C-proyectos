namespace Factura
{
    partial class MantenimientoProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprecio = new MiLibreria.errorTxtBox();
            this.txtdescrip = new MiLibreria.errorTxtBox();
            this.txtidpro = new MiLibreria.errorTxtBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID PRODUCTO :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "DESCRIPCION :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "PRECIO :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(192, 192);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(120, 20);
            this.txtprecio.solo_Numeros = true;
            this.txtprecio.TabIndex = 16;
            this.txtprecio.Validar = true;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
            // 
            // txtdescrip
            // 
            this.txtdescrip.Location = new System.Drawing.Point(192, 136);
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(120, 20);
            this.txtdescrip.solo_Numeros = false;
            this.txtdescrip.TabIndex = 15;
            this.txtdescrip.Validar = true;
            this.txtdescrip.TextChanged += new System.EventHandler(this.txtdescrip_TextChanged);
            // 
            // txtidpro
            // 
            this.txtidpro.Location = new System.Drawing.Point(192, 80);
            this.txtidpro.Name = "txtidpro";
            this.txtidpro.Size = new System.Drawing.Size(120, 20);
            this.txtidpro.solo_Numeros = true;
            this.txtidpro.TabIndex = 14;
            this.txtidpro.Validar = true;
            this.txtidpro.TextChanged += new System.EventHandler(this.txtidpro_TextChanged);
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 355);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdescrip);
            this.Controls.Add(this.txtidpro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoProducto";
            this.Text = "MantenimientoProducto";
            this.Shown += new System.EventHandler(this.MantenimientoProducto_Shown);
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
            this.Controls.SetChildIndex(this.txtidpro, 0);
            this.Controls.SetChildIndex(this.txtdescrip, 0);
            this.Controls.SetChildIndex(this.txtprecio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MiLibreria.errorTxtBox txtidpro;
        private MiLibreria.errorTxtBox txtdescrip;
        private MiLibreria.errorTxtBox txtprecio;
    }
}