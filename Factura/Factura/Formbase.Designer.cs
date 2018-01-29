namespace Factura
{
    partial class Formbase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formbase));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrar_sesion = new System.Windows.Forms.Button();
            this.btnContenedor_pri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(48, 256);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCerrar_sesion
            // 
            this.btnCerrar_sesion.Location = new System.Drawing.Point(24, 256);
            this.btnCerrar_sesion.Name = "btnCerrar_sesion";
            this.btnCerrar_sesion.Size = new System.Drawing.Size(83, 23);
            this.btnCerrar_sesion.TabIndex = 1;
            this.btnCerrar_sesion.Text = "Cerrar Sesion";
            this.btnCerrar_sesion.UseVisualStyleBackColor = true;
            this.btnCerrar_sesion.Click += new System.EventHandler(this.btnCerrar_sesion_Click);
            // 
            // btnContenedor_pri
            // 
            this.btnContenedor_pri.Location = new System.Drawing.Point(32, 256);
            this.btnContenedor_pri.Name = "btnContenedor_pri";
            this.btnContenedor_pri.Size = new System.Drawing.Size(75, 23);
            this.btnContenedor_pri.TabIndex = 2;
            this.btnContenedor_pri.Text = "Contendor Principal";
            this.btnContenedor_pri.UseVisualStyleBackColor = true;
            this.btnContenedor_pri.Click += new System.EventHandler(this.btnContenedor_pri_Click);
            // 
            // Formbase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(337, 319);
            this.Controls.Add(this.btnContenedor_pri);
            this.Controls.Add(this.btnCerrar_sesion);
            this.Controls.Add(this.btnSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formbase";
            this.Text = "La toscana";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnCerrar_sesion;
        public System.Windows.Forms.Button btnContenedor_pri;
    }
}