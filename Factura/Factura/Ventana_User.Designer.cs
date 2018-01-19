namespace Factura
{
    partial class Ventana_User
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCodUs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomUs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(312, 200);
            this.btnSalir.Size = new System.Drawing.Size(136, 32);
            // 
            // btnCerrar_sesion
            // 
            this.btnCerrar_sesion.Location = new System.Drawing.Point(312, 160);
            this.btnCerrar_sesion.Size = new System.Drawing.Size(136, 32);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "Cambiar Contrasena";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Contendor Principal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCodUs
            // 
            this.lblCodUs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodUs.Location = new System.Drawing.Point(96, 143);
            this.lblCodUs.Name = "lblCodUs";
            this.lblCodUs.Size = new System.Drawing.Size(112, 24);
            this.lblCodUs.TabIndex = 17;
            this.lblCodUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Codigo:";
            // 
            // lblUs
            // 
            this.lblUs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUs.Location = new System.Drawing.Point(96, 87);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(112, 24);
            this.lblUs.TabIndex = 15;
            this.lblUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Usuario:";
            // 
            // lblNomUs
            // 
            this.lblNomUs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomUs.Location = new System.Drawing.Point(96, 31);
            this.lblNomUs.Name = "lblNomUs";
            this.lblNomUs.Size = new System.Drawing.Size(112, 24);
            this.lblNomUs.TabIndex = 13;
            this.lblNomUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Ventana_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCodUs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNomUs);
            this.Controls.Add(this.label1);
            this.Name = "Ventana_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana_User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana_User_FormClosed);
            this.Load += new System.EventHandler(this.Ventana_User_Load);
            this.Controls.SetChildIndex(this.btnCerrar_sesion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblNomUs, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblUs, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblCodUs, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCodUs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomUs;
        private System.Windows.Forms.Label label1;
    }
}