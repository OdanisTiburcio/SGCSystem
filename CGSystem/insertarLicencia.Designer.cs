namespace CGSystem
{
    partial class insertarLicencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertarLicencia));
            this.lblExpirado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlicencia = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExpirado
            // 
            this.lblExpirado.AutoSize = true;
            this.lblExpirado.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirado.ForeColor = System.Drawing.Color.Red;
            this.lblExpirado.Location = new System.Drawing.Point(123, 10);
            this.lblExpirado.Name = "lblExpirado";
            this.lblExpirado.Size = new System.Drawing.Size(324, 33);
            this.lblExpirado.TabIndex = 0;
            this.lblExpirado.Text = "Su Prueba de 30 días ha Vencido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese su Número de Licencia Para Activar el Producto";
            // 
            // txtlicencia
            // 
            this.txtlicencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlicencia.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlicencia.Location = new System.Drawing.Point(77, 79);
            this.txtlicencia.Name = "txtlicencia";
            this.txtlicencia.Size = new System.Drawing.Size(415, 29);
            this.txtlicencia.TabIndex = 0;
            this.txtlicencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnaceptar
            // 
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Location = new System.Drawing.Point(129, 120);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(115, 36);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Location = new System.Drawing.Point(332, 120);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(115, 36);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // insertarLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 168);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtlicencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblExpirado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(588, 207);
            this.MinimumSize = new System.Drawing.Size(588, 207);
            this.Name = "insertarLicencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licencia";
            this.Load += new System.EventHandler(this.insertarLicencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpirado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlicencia;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
    }
}