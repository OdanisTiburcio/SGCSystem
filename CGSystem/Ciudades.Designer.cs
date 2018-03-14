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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ciudades));
            this.label2 = new System.Windows.Forms.Label();
            this.tbdescripciudad = new System.Windows.Forms.TextBox();
            this.tbcodigociudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminarciudad = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditarciudad = new System.Windows.Forms.Button();
            this.btnguardarciudad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descripción Ciudad:";
            // 
            // tbdescripciudad
            // 
            this.tbdescripciudad.Location = new System.Drawing.Point(165, 36);
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
            // btneliminarciudad
            // 
            this.btneliminarciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarciudad.Location = new System.Drawing.Point(320, 62);
            this.btneliminarciudad.Name = "btneliminarciudad";
            this.btneliminarciudad.Size = new System.Drawing.Size(92, 38);
            this.btneliminarciudad.TabIndex = 37;
            this.btneliminarciudad.Text = "Eliminar";
            this.btneliminarciudad.UseVisualStyleBackColor = true;
            this.btneliminarciudad.Click += new System.EventHandler(this.btneliminarciudad_Click_1);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(217, 62);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(92, 38);
            this.btnnuevo.TabIndex = 38;
            this.btnnuevo.Text = "Nuevo (+)";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneditarciudad
            // 
            this.btneditarciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditarciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditarciudad.Location = new System.Drawing.Point(114, 62);
            this.btneditarciudad.Name = "btneditarciudad";
            this.btneditarciudad.Size = new System.Drawing.Size(92, 38);
            this.btneditarciudad.TabIndex = 39;
            this.btneditarciudad.Text = "Editar";
            this.btneditarciudad.UseVisualStyleBackColor = true;
            this.btneditarciudad.Click += new System.EventHandler(this.btneditarciudad_Click);
            // 
            // btnguardarciudad
            // 
            this.btnguardarciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarciudad.Location = new System.Drawing.Point(11, 62);
            this.btnguardarciudad.Name = "btnguardarciudad";
            this.btnguardarciudad.Size = new System.Drawing.Size(92, 38);
            this.btnguardarciudad.TabIndex = 40;
            this.btnguardarciudad.Text = "Guardar";
            this.btnguardarciudad.UseVisualStyleBackColor = true;
            this.btnguardarciudad.Click += new System.EventHandler(this.btnguardarciudad_Click_1);
            // 
            // Ciudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 113);
            this.Controls.Add(this.btneliminarciudad);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btneditarciudad);
            this.Controls.Add(this.btnguardarciudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbdescripciudad);
            this.Controls.Add(this.tbcodigociudad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(436, 151);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(436, 151);
            this.Name = "Ciudades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciudades";
            this.Load += new System.EventHandler(this.Ciudades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbdescripciudad;
        public System.Windows.Forms.TextBox tbcodigociudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneliminarciudad;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditarciudad;
        private System.Windows.Forms.Button btnguardarciudad;
    }
}