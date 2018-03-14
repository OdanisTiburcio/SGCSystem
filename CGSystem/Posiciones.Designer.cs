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
            this.btneliminarposi = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditarposi = new System.Windows.Forms.Button();
            this.btnguardarposi = new System.Windows.Forms.Button();
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
            this.tbcodigoposicion.Location = new System.Drawing.Point(167, 15);
            this.tbcodigoposicion.Name = "tbcodigoposicion";
            this.tbcodigoposicion.Size = new System.Drawing.Size(83, 20);
            this.tbcodigoposicion.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código Posición:";
            // 
            // btneliminarposi
            // 
            this.btneliminarposi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarposi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarposi.Location = new System.Drawing.Point(321, 68);
            this.btneliminarposi.Name = "btneliminarposi";
            this.btneliminarposi.Size = new System.Drawing.Size(92, 38);
            this.btneliminarposi.TabIndex = 33;
            this.btneliminarposi.Text = "Eliminar";
            this.btneliminarposi.UseVisualStyleBackColor = true;
            this.btneliminarposi.Click += new System.EventHandler(this.btneliminarposi_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(218, 68);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(92, 38);
            this.btnnuevo.TabIndex = 34;
            this.btnnuevo.Text = "Nuevo (+)";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneditarposi
            // 
            this.btneditarposi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditarposi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditarposi.Location = new System.Drawing.Point(115, 68);
            this.btneditarposi.Name = "btneditarposi";
            this.btneditarposi.Size = new System.Drawing.Size(92, 38);
            this.btneditarposi.TabIndex = 35;
            this.btneditarposi.Text = "Editar";
            this.btneditarposi.UseVisualStyleBackColor = true;
            this.btneditarposi.Click += new System.EventHandler(this.btneditarposi_Click);
            // 
            // btnguardarposi
            // 
            this.btnguardarposi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarposi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarposi.Location = new System.Drawing.Point(12, 68);
            this.btnguardarposi.Name = "btnguardarposi";
            this.btnguardarposi.Size = new System.Drawing.Size(92, 38);
            this.btnguardarposi.TabIndex = 36;
            this.btnguardarposi.Text = "Guardar";
            this.btnguardarposi.UseVisualStyleBackColor = true;
            this.btnguardarposi.Click += new System.EventHandler(this.btnguardarposi_Click);
            // 
            // Posiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 122);
            this.Controls.Add(this.btneliminarposi);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btneditarposi);
            this.Controls.Add(this.btnguardarposi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbdescripposición);
            this.Controls.Add(this.tbcodigoposicion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Posiciones";
            this.Text = "Posiciones";
            this.Load += new System.EventHandler(this.Posiciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbdescripposición;
        public System.Windows.Forms.TextBox tbcodigoposicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneliminarposi;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditarposi;
        private System.Windows.Forms.Button btnguardarposi;
    }
}