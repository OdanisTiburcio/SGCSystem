namespace CGSystem
{
    partial class SeleccionarPosicion
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
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.rdbid = new System.Windows.Forms.RadioButton();
            this.rdbnombre = new System.Windows.Forms.RadioButton();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dgvlistadepartamentos = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmostrartodo = new System.Windows.Forms.Button();
            this.btnseleccionardepto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbbuscar
            // 
            this.tbbuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.tbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbuscar.Location = new System.Drawing.Point(128, 11);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(198, 29);
            this.tbbuscar.TabIndex = 82;
            this.tbbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbbuscar_KeyUp);
            // 
            // rdbid
            // 
            this.rdbid.AutoSize = true;
            this.rdbid.Location = new System.Drawing.Point(72, 15);
            this.rdbid.Name = "rdbid";
            this.rdbid.Size = new System.Drawing.Size(58, 17);
            this.rdbid.TabIndex = 86;
            this.rdbid.Text = "Código";
            this.rdbid.UseVisualStyleBackColor = true;
            // 
            // rdbnombre
            // 
            this.rdbnombre.AutoSize = true;
            this.rdbnombre.Checked = true;
            this.rdbnombre.Location = new System.Drawing.Point(12, 15);
            this.rdbnombre.Name = "rdbnombre";
            this.rdbnombre.Size = new System.Drawing.Size(62, 17);
            this.rdbnombre.TabIndex = 87;
            this.rdbnombre.TabStop = true;
            this.rdbnombre.Text = "Nombre";
            this.rdbnombre.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnbuscar.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(332, 6);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(129, 38);
            this.btnbuscar.TabIndex = 83;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar.Location = new System.Drawing.Point(467, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(109, 39);
            this.btnagregar.TabIndex = 85;
            this.btnagregar.Text = "Agregar (+)";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dgvlistadepartamentos
            // 
            this.dgvlistadepartamentos.AllowUserToAddRows = false;
            this.dgvlistadepartamentos.AllowUserToDeleteRows = false;
            this.dgvlistadepartamentos.AllowUserToResizeColumns = false;
            this.dgvlistadepartamentos.AllowUserToResizeRows = false;
            this.dgvlistadepartamentos.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvlistadepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistadepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.Nombre});
            this.dgvlistadepartamentos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvlistadepartamentos.Location = new System.Drawing.Point(12, 47);
            this.dgvlistadepartamentos.MultiSelect = false;
            this.dgvlistadepartamentos.Name = "dgvlistadepartamentos";
            this.dgvlistadepartamentos.ReadOnly = true;
            this.dgvlistadepartamentos.RowHeadersVisible = false;
            this.dgvlistadepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistadepartamentos.Size = new System.Drawing.Size(564, 319);
            this.dgvlistadepartamentos.TabIndex = 84;
            this.dgvlistadepartamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistadepartamentos_CellDoubleClick);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Código";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Descripción";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 500;
            // 
            // btnmostrartodo
            // 
            this.btnmostrartodo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnmostrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrartodo.Location = new System.Drawing.Point(329, 370);
            this.btnmostrartodo.Name = "btnmostrartodo";
            this.btnmostrartodo.Size = new System.Drawing.Size(220, 46);
            this.btnmostrartodo.TabIndex = 89;
            this.btnmostrartodo.Text = "Mostrar Todo";
            this.btnmostrartodo.UseVisualStyleBackColor = false;
            // 
            // btnseleccionardepto
            // 
            this.btnseleccionardepto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnseleccionardepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionardepto.Location = new System.Drawing.Point(32, 370);
            this.btnseleccionardepto.Name = "btnseleccionardepto";
            this.btnseleccionardepto.Size = new System.Drawing.Size(220, 46);
            this.btnseleccionardepto.TabIndex = 88;
            this.btnseleccionardepto.Text = "Seleccionar";
            this.btnseleccionardepto.UseVisualStyleBackColor = false;
            this.btnseleccionardepto.Click += new System.EventHandler(this.btnseleccionardepto_Click);
            // 
            // SeleccionarPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 426);
            this.Controls.Add(this.tbbuscar);
            this.Controls.Add(this.rdbid);
            this.Controls.Add(this.rdbnombre);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvlistadepartamentos);
            this.Controls.Add(this.btnmostrartodo);
            this.Controls.Add(this.btnseleccionardepto);
            this.Name = "SeleccionarPosicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionarPosicion";
            this.Load += new System.EventHandler(this.SeleccionarPosicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbbuscar;
        public System.Windows.Forms.RadioButton rdbid;
        private System.Windows.Forms.RadioButton rdbnombre;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvlistadepartamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnmostrartodo;
        private System.Windows.Forms.Button btnseleccionardepto;
    }
}