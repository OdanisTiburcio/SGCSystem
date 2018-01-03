namespace CGSystem
{
    partial class SeleccionarNumeroDeFactura
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.tbnumfactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnguardar.Location = new System.Drawing.Point(33, 60);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(158, 60);
            this.btnguardar.TabIndex = 130;
            this.btnguardar.Text = "Aceptar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // tbnumfactura
            // 
            this.tbnumfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnumfactura.Location = new System.Drawing.Point(184, 23);
            this.tbnumfactura.Name = "tbnumfactura";
            this.tbnumfactura.Size = new System.Drawing.Size(182, 22);
            this.tbnumfactura.TabIndex = 129;
            this.tbnumfactura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbnumfactura_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 50);
            this.label1.TabIndex = 131;
            this.label1.Text = "No. de Factura:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(208, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 60);
            this.button1.TabIndex = 132;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeleccionarNumeroDeFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 133);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.tbnumfactura);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 171);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(417, 171);
            this.Name = "SeleccionarNumeroDeFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionarNumeroDeFactura";
            this.Load += new System.EventHandler(this.SeleccionarNumeroDeFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox tbnumfactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}