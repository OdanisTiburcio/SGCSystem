namespace CGSystem
{
    partial class MantenimientoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtipousuario = new System.Windows.Forms.ComboBox();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnresetear = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtipousuario);
            this.groupBox1.Controls.Add(this.txtidempleado);
            this.groupBox1.Controls.Add(this.txtcontraseña);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtempleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnseleccionar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 18F);
            this.groupBox1.Location = new System.Drawing.Point(12, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 184);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Usuario";
            // 
            // cbtipousuario
            // 
            this.cbtipousuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipousuario.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtipousuario.FormattingEnabled = true;
            this.cbtipousuario.Items.AddRange(new object[] {
            "EMPLEADO",
            "ADMINISTRADOR"});
            this.cbtipousuario.Location = new System.Drawing.Point(116, 136);
            this.cbtipousuario.Name = "cbtipousuario";
            this.cbtipousuario.Size = new System.Drawing.Size(143, 26);
            this.cbtipousuario.TabIndex = 2;
            // 
            // txtidempleado
            // 
            this.txtidempleado.BackColor = System.Drawing.Color.White;
            this.txtidempleado.Enabled = false;
            this.txtidempleado.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.txtidempleado.Location = new System.Drawing.Point(273, 32);
            this.txtidempleado.MaxLength = 10;
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.ReadOnly = true;
            this.txtidempleado.Size = new System.Drawing.Size(46, 29);
            this.txtidempleado.TabIndex = 87;
            this.txtidempleado.Text = "0";
            this.txtidempleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.Color.White;
            this.txtcontraseña.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(111, 101);
            this.txtcontraseña.MaxLength = 10;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(148, 29);
            this.txtcontraseña.TabIndex = 1;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.White;
            this.txtusuario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(99, 66);
            this.txtusuario.MaxLength = 10;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(172, 29);
            this.txtusuario.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 86;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 86;
            this.label3.Text = "Contraseña";
            // 
            // txtempleado
            // 
            this.txtempleado.BackColor = System.Drawing.Color.White;
            this.txtempleado.Enabled = false;
            this.txtempleado.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempleado.Location = new System.Drawing.Point(98, 32);
            this.txtempleado.MaxLength = 10;
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.ReadOnly = true;
            this.txtempleado.Size = new System.Drawing.Size(172, 29);
            this.txtempleado.TabIndex = 88;
            this.txtempleado.Text = "Seleccione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 86;
            this.label2.Text = "Usuario";
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnseleccionar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionar.Location = new System.Drawing.Point(322, 28);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(136, 38);
            this.btnseleccionar.TabIndex = 3;
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = false;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 86;
            this.label1.Text = "Empleado";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Black;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(277, 72);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(181, 99);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "CREAR";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Cornsilk;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(183, 219);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(116, 38);
            this.btnnuevo.TabIndex = 88;
            this.btnnuevo.Text = "Nuevo (+)";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnresetear
            // 
            this.btnresetear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnresetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetear.Location = new System.Drawing.Point(305, 219);
            this.btnresetear.Name = "btnresetear";
            this.btnresetear.Size = new System.Drawing.Size(165, 38);
            this.btnresetear.TabIndex = 90;
            this.btnresetear.Text = "Resetear Cuenta";
            this.btnresetear.UseVisualStyleBackColor = false;
            this.btnresetear.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(102, 6);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(308, 32);
            this.lbltitulo.TabIndex = 91;
            this.lbltitulo.Text = "Mantenimiento de Usuarios";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Tipo Cuenta";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 120;
            // 
            // nomb
            // 
            this.nomb.HeaderText = "Contraseña";
            this.nomb.Name = "nomb";
            this.nomb.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Usuario";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AllowUserToAddRows = false;
            this.dgvusuarios.AllowUserToDeleteRows = false;
            this.dgvusuarios.AllowUserToResizeColumns = false;
            this.dgvusuarios.AllowUserToResizeRows = false;
            this.dgvusuarios.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nomb,
            this.carrera,
            this.telefono});
            this.dgvusuarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvusuarios.Location = new System.Drawing.Point(12, 46);
            this.dgvusuarios.MultiSelect = false;
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.ReadOnly = true;
            this.dgvusuarios.RowHeadersVisible = false;
            this.dgvusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvusuarios.Size = new System.Drawing.Size(473, 167);
            this.dgvusuarios.TabIndex = 87;
            this.dgvusuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvequipos_CellDoubleClick);
            // 
            // carrera
            // 
            this.carrera.HeaderText = "Empleado";
            this.carrera.Name = "carrera";
            this.carrera.ReadOnly = true;
            this.carrera.Width = 150;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(12, 219);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(165, 38);
            this.btneliminar.TabIndex = 89;
            this.btneliminar.Text = "Eliminar Cuenta";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // MantenimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnresetear);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.dgvusuarios);
            this.Controls.Add(this.btneliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(514, 515);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(514, 515);
            this.Name = "MantenimientoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.MantenimientoUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbtipousuario;
        private System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnresetear;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomb;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.Button btneliminar;
    }
}