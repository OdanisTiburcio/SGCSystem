namespace CGSystem
{
    partial class SeleccionarServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarServicio));
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.rdbid = new System.Windows.Forms.RadioButton();
            this.rdbnombre = new System.Windows.Forms.RadioButton();
            this.btnmostrartodo = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dgvListaServicios = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldobruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // tbbuscar
            // 
            this.tbbuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.tbbuscar.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbuscar.Location = new System.Drawing.Point(220, 15);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(184, 30);
            this.tbbuscar.TabIndex = 0;
            this.tbbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbbuscar_KeyPress);
            this.tbbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbbuscar_KeyUp);
            // 
            // rdbid
            // 
            this.rdbid.AutoSize = true;
            this.rdbid.Checked = true;
            this.rdbid.Location = new System.Drawing.Point(180, 23);
            this.rdbid.Name = "rdbid";
            this.rdbid.Size = new System.Drawing.Size(34, 17);
            this.rdbid.TabIndex = 54;
            this.rdbid.TabStop = true;
            this.rdbid.Text = "Id";
            this.rdbid.UseVisualStyleBackColor = true;
            // 
            // rdbnombre
            // 
            this.rdbnombre.AutoSize = true;
            this.rdbnombre.Location = new System.Drawing.Point(121, 23);
            this.rdbnombre.Name = "rdbnombre";
            this.rdbnombre.Size = new System.Drawing.Size(62, 17);
            this.rdbnombre.TabIndex = 55;
            this.rdbnombre.Text = "Nombre";
            this.rdbnombre.UseVisualStyleBackColor = true;
            // 
            // btnmostrartodo
            // 
            this.btnmostrartodo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnmostrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrartodo.Location = new System.Drawing.Point(410, 380);
            this.btnmostrartodo.Name = "btnmostrartodo";
            this.btnmostrartodo.Size = new System.Drawing.Size(220, 46);
            this.btnmostrartodo.TabIndex = 4;
            this.btnmostrartodo.Text = "Mostrar Todo";
            this.btnmostrartodo.UseVisualStyleBackColor = false;
            this.btnmostrartodo.Click += new System.EventHandler(this.btnmostrartodo_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.Location = new System.Drawing.Point(67, 380);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(220, 46);
            this.btnimprimir.TabIndex = 3;
            this.btnimprimir.Text = "Seleccionar";
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnbuscar.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(410, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(129, 38);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar.Enabled = false;
            this.btnagregar.Location = new System.Drawing.Point(545, 12);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(147, 39);
            this.btnagregar.TabIndex = 48;
            this.btnagregar.Text = "Agregar Servicio (+)";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dgvListaServicios
            // 
            this.dgvListaServicios.AllowUserToAddRows = false;
            this.dgvListaServicios.AllowUserToDeleteRows = false;
            this.dgvListaServicios.AllowUserToResizeColumns = false;
            this.dgvListaServicios.AllowUserToResizeRows = false;
            this.dgvListaServicios.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvListaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.Nombre,
            this.sueldobruto,
            this.cargo});
            this.dgvListaServicios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvListaServicios.Location = new System.Drawing.Point(12, 55);
            this.dgvListaServicios.MultiSelect = false;
            this.dgvListaServicios.Name = "dgvListaServicios";
            this.dgvListaServicios.ReadOnly = true;
            this.dgvListaServicios.RowHeadersVisible = false;
            this.dgvListaServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaServicios.Size = new System.Drawing.Size(683, 319);
            this.dgvListaServicios.TabIndex = 2;
            this.dgvListaServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaServicios_CellContentClick);
            this.dgvListaServicios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaServicios_CellDoubleClick);
            this.dgvListaServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvListaServicios_KeyPress);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Código";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 85;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Descripción";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 350;
            // 
            // sueldobruto
            // 
            this.sueldobruto.HeaderText = "Precio";
            this.sueldobruto.Name = "sueldobruto";
            this.sueldobruto.ReadOnly = true;
            this.sueldobruto.Width = 150;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Días (+)";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Servicios";
            // 
            // SeleccionarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 436);
            this.Controls.Add(this.tbbuscar);
            this.Controls.Add(this.rdbid);
            this.Controls.Add(this.rdbnombre);
            this.Controls.Add(this.btnmostrartodo);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvListaServicios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionarServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Servicio";
            this.Load += new System.EventHandler(this.SeleccionarServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbbuscar;
        private System.Windows.Forms.RadioButton rdbid;
        private System.Windows.Forms.RadioButton rdbnombre;
        private System.Windows.Forms.Button btnmostrartodo;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvListaServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldobruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
    }
}