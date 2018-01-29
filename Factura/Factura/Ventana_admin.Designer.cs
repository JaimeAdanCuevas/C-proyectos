namespace Factura
{
    partial class Ventana_admin
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsAdmin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodAdmin = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(336, 208);
            this.btnSalir.Size = new System.Drawing.Size(136, 32);
            this.btnSalir.TabIndex = 1;
            // 
            // btnCerrar_sesion
            // 
            this.btnCerrar_sesion.Location = new System.Drawing.Point(336, 168);
            this.btnCerrar_sesion.Size = new System.Drawing.Size(136, 31);
            // 
            // btnContenedor_pri
            // 
            this.btnContenedor_pri.Location = new System.Drawing.Point(336, 48);
            this.btnContenedor_pri.Size = new System.Drawing.Size(136, 31);
            this.btnContenedor_pri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin:";
            // 
            // lblAdmin
            // 
            this.lblAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdmin.Location = new System.Drawing.Point(120, 40);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(112, 24);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario:";
            // 
            // lblUsAdmin
            // 
            this.lblUsAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsAdmin.Location = new System.Drawing.Point(120, 96);
            this.lblUsAdmin.Name = "lblUsAdmin";
            this.lblUsAdmin.Size = new System.Drawing.Size(112, 24);
            this.lblUsAdmin.TabIndex = 3;
            this.lblUsAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Codigo:";
            // 
            // lblCodAdmin
            // 
            this.lblCodAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodAdmin.Location = new System.Drawing.Point(120, 152);
            this.lblCodAdmin.Name = "lblCodAdmin";
            this.lblCodAdmin.Size = new System.Drawing.Size(112, 24);
            this.lblCodAdmin.TabIndex = 5;
            this.lblCodAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Administrar Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cambiar Contrasena";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Ventana_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCodAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUsAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.label1);
            this.Name = "Ventana_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana_admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana_admin_FormClosed);
            this.Load += new System.EventHandler(this.Ventana_admin_Load);
            this.Controls.SetChildIndex(this.btnContenedor_pri, 0);
            this.Controls.SetChildIndex(this.btnCerrar_sesion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblAdmin, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblUsAdmin, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblCodAdmin, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCodAdmin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}