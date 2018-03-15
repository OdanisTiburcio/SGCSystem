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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvequipos = new System.Windows.Forms.DataGridView();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipos)).BeginInit();
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
            this.cbtipousuario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtipousuario.FormattingEnabled = true;
            this.cbtipousuario.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.cbtipousuario.Location = new System.Drawing.Point(116, 136);
            this.cbtipousuario.Name = "cbtipousuario";
            this.cbtipousuario.Size = new System.Drawing.Size(136, 30);
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
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cornsilk;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(183, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 38);
            this.button2.TabIndex = 88;
            this.button2.Text = "Nuevo (+)";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(305, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 38);
            this.button1.TabIndex = 90;
            this.button1.Text = "Resetear Cuenta";
            this.button1.UseVisualStyleBackColor = false;
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
            // dgvequipos
            // 
            this.dgvequipos.AllowUserToAddRows = false;
            this.dgvequipos.AllowUserToDeleteRows = false;
            this.dgvequipos.AllowUserToResizeColumns = false;
            this.dgvequipos.AllowUserToResizeRows = false;
            this.dgvequipos.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvequipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvequipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nomb,
            this.carrera,
            this.telefono});
            this.dgvequipos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvequipos.Location = new System.Drawing.Point(12, 46);
            this.dgvequipos.MultiSelect = false;
            this.dgvequipos.Name = "dgvequipos";
            this.dgvequipos.ReadOnly = true;
            this.dgvequipos.RowHeadersVisible = false;
            this.dgvequipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvequipos.Size = new System.Drawing.Size(473, 167);
            this.dgvequipos.TabIndex = 87;
            // 
            // carrera
            // 
            this.carrera.HeaderText = "Empleado";
            this.carrera.Name = "carrera";
            this.carrera.ReadOnly = true;
            this.carrera.Width = 150;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(12, 219);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(165, 38);
            this.btnbuscar.TabIndex = 89;
            this.btnbuscar.Text = "Eliminar Cuenta";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // MantenimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.dgvequipos);
            this.Controls.Add(this.btnbuscar);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipos)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomb;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridView dgvequipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.Button btnbuscar;
    }
}