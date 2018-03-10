namespace CGSystem
{
    partial class Posiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Posiciones));
            this.label2 = new System.Windows.Forms.Label();
            this.tbdescripposición = new System.Windows.Forms.TextBox();
            this.tbcodigoposicion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardarposicion = new System.Windows.Forms.Button();
            this.btnactualizarposicion = new System.Windows.Forms.Button();
            this.btneliminarposicion = new System.Windows.Forms.Button();
            this.btnimprimirposicion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "Descripción Posición:";
            // 
            // tbdescripposición
            // 
            this.tbdescripposición.Location = new System.Drawing.Point(167, 40);
            this.tbdescripposición.Name = "tbdescripposición";
            this.tbdescripposición.Size = new System.Drawing.Size(244, 20);
            this.tbdescripposición.TabIndex = 26;
            // 
            // tbcodigoposicion
            // 
            this.tbcodigoposicion.Location = new System.Drawing.Point(165, 6);
            this.tbcodigoposicion.Name = "tbcodigoposicion";
            this.tbcodigoposicion.Size = new System.Drawing.Size(83, 20);
            this.tbcodigoposicion.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código Posición:";
            // 
            // btnguardarposicion
            // 
            this.btnguardarposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarposicion.Location = new System.Drawing.Point(15, 78);
            this.btnguardarposicion.Name = "btnguardarposicion";
            this.btnguardarposicion.Size = new System.Drawing.Size(94, 51);
            this.btnguardarposicion.TabIndex = 28;
            this.btnguardarposicion.Text = "Guardar";
            this.btnguardarposicion.UseVisualStyleBackColor = true;
            this.btnguardarposicion.Click += new System.EventHandler(this.btnguardarposicion_Click);
            // 
            // btnactualizarposicion
            // 
            this.btnactualizarposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarposicion.Location = new System.Drawing.Point(115, 78);
            this.btnactualizarposicion.Name = "btnactualizarposicion";
            this.btnactualizarposicion.Size = new System.Drawing.Size(94, 51);
            this.btnactualizarposicion.TabIndex = 28;
            this.btnactualizarposicion.Text = "Actualizar";
            this.btnactualizarposicion.UseVisualStyleBackColor = true;
            this.btnactualizarposicion.Click += new System.EventHandler(this.btnactualizarposicion_Click);
            // 
            // btneliminarposicion
            // 
            this.btneliminarposicion.Enabled = false;
            this.btneliminarposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarposicion.Location = new System.Drawing.Point(215, 78);
            this.btneliminarposicion.Name = "btneliminarposicion";
            this.btneliminarposicion.Size = new System.Drawing.Size(94, 51);
            this.btneliminarposicion.TabIndex = 28;
            this.btneliminarposicion.Text = "Eliminar";
            this.btneliminarposicion.UseVisualStyleBackColor = true;
            this.btneliminarposicion.Click += new System.EventHandler(this.btneliminarposicion_Click);
            // 
            // btnimprimirposicion
            // 
            this.btnimprimirposicion.Enabled = false;
            this.btnimprimirposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimirposicion.Location = new System.Drawing.Point(315, 78);
            this.btnimprimirposicion.Name = "btnimprimirposicion";
            this.btnimprimirposicion.Size = new System.Drawing.Size(94, 51);
            this.btnimprimirposicion.TabIndex = 28;
            this.btnimprimirposicion.Text = "Imprimir";
            this.btnimprimirposicion.UseVisualStyleBackColor = true;
            // 
            // Posiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 142);
            this.Controls.Add(this.btnimprimirposicion);
            this.Controls.Add(this.btneliminarposicion);
            this.Controls.Add(this.btnactualizarposicion);
            this.Controls.Add(this.btnguardarposicion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbdescripposición);
            this.Controls.Add(this.tbcodigoposicion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Posiciones";
            this.Text = "Posiciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbdescripposición;
        public System.Windows.Forms.TextBox tbcodigoposicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardarposicion;
        private System.Windows.Forms.Button btnactualizarposicion;
        private System.Windows.Forms.Button btneliminarposicion;
        private System.Windows.Forms.Button btnimprimirposicion;
    }
}