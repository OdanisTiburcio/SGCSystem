namespace CGSystem
{
    partial class Ciudades
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbdescripciudad = new System.Windows.Forms.TextBox();
            this.tbcodigociudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardarciudad = new System.Windows.Forms.Button();
            this.btnactualizarciudad = new System.Windows.Forms.Button();
            this.btneliminarciudad = new System.Windows.Forms.Button();
            this.btnimprimirciudad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descripción Ciudad:";
            // 
            // tbdescripciudad
            // 
            this.tbdescripciudad.Location = new System.Drawing.Point(165, 44);
            this.tbdescripciudad.Name = "tbdescripciudad";
            this.tbdescripciudad.Size = new System.Drawing.Size(244, 20);
            this.tbdescripciudad.TabIndex = 22;
            // 
            // tbcodigociudad
            // 
            this.tbcodigociudad.Location = new System.Drawing.Point(165, 10);
            this.tbcodigociudad.Name = "tbcodigociudad";
            this.tbcodigociudad.Size = new System.Drawing.Size(83, 20);
            this.tbcodigociudad.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código Ciudad:";
            // 
            // btnguardarciudad
            // 
            this.btnguardarciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarciudad.Location = new System.Drawing.Point(15, 86);
            this.btnguardarciudad.Name = "btnguardarciudad";
            this.btnguardarciudad.Size = new System.Drawing.Size(94, 51);
            this.btnguardarciudad.TabIndex = 25;
            this.btnguardarciudad.Text = "Guardar";
            this.btnguardarciudad.UseVisualStyleBackColor = true;
            this.btnguardarciudad.Click += new System.EventHandler(this.btnguardarciudad_Click);
            // 
            // btnactualizarciudad
            // 
            this.btnactualizarciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarciudad.Location = new System.Drawing.Point(115, 86);
            this.btnactualizarciudad.Name = "btnactualizarciudad";
            this.btnactualizarciudad.Size = new System.Drawing.Size(94, 51);
            this.btnactualizarciudad.TabIndex = 25;
            this.btnactualizarciudad.Text = "Actualizar";
            this.btnactualizarciudad.UseVisualStyleBackColor = true;
            this.btnactualizarciudad.Click += new System.EventHandler(this.btnactualizarciudad_Click);
            // 
            // btneliminarciudad
            // 
            this.btneliminarciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarciudad.Location = new System.Drawing.Point(215, 86);
            this.btneliminarciudad.Name = "btneliminarciudad";
            this.btneliminarciudad.Size = new System.Drawing.Size(94, 51);
            this.btneliminarciudad.TabIndex = 25;
            this.btneliminarciudad.Text = "Eliminar";
            this.btneliminarciudad.UseVisualStyleBackColor = true;
            this.btneliminarciudad.Click += new System.EventHandler(this.btneliminarciudad_Click);
            // 
            // btnimprimirciudad
            // 
            this.btnimprimirciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimirciudad.Location = new System.Drawing.Point(315, 86);
            this.btnimprimirciudad.Name = "btnimprimirciudad";
            this.btnimprimirciudad.Size = new System.Drawing.Size(94, 51);
            this.btnimprimirciudad.TabIndex = 25;
            this.btnimprimirciudad.Text = "Imprimir";
            this.btnimprimirciudad.UseVisualStyleBackColor = true;
            // 
            // Ciudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 146);
            this.Controls.Add(this.btnimprimirciudad);
            this.Controls.Add(this.btneliminarciudad);
            this.Controls.Add(this.btnactualizarciudad);
            this.Controls.Add(this.btnguardarciudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbdescripciudad);
            this.Controls.Add(this.tbcodigociudad);
            this.Controls.Add(this.label1);
            this.Name = "Ciudades";
            this.Text = "Ciudades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbdescripciudad;
        public System.Windows.Forms.TextBox tbcodigociudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardarciudad;
        private System.Windows.Forms.Button btnactualizarciudad;
        private System.Windows.Forms.Button btneliminarciudad;
        private System.Windows.Forms.Button btnimprimirciudad;
    }
}