namespace CGSystem
{
    partial class ListaDeEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeEmpleados));
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.rdbcedula = new System.Windows.Forms.RadioButton();
            this.rdbapellido = new System.Windows.Forms.RadioButton();
            this.rdbid = new System.Windows.Forms.RadioButton();
            this.rdbnombre = new System.Windows.Forms.RadioButton();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.datanomina = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldobruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahorros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datanomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbbuscar
            // 
            this.tbbuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.tbbuscar.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbuscar.Location = new System.Drawing.Point(277, 9);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(140, 30);
            this.tbbuscar.TabIndex = 33;
            this.tbbuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbbuscar_KeyDown);
            this.tbbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbbuscar_KeyUp);
            // 
            // rdbcedula
            // 
            this.rdbcedula.AutoSize = true;
            this.rdbcedula.Checked = true;
            this.rdbcedula.Location = new System.Drawing.Point(196, 48);
            this.rdbcedula.Name = "rdbcedula";
            this.rdbcedula.Size = new System.Drawing.Size(64, 17);
            this.rdbcedula.TabIndex = 39;
            this.rdbcedula.TabStop = true;
            this.rdbcedula.Text = "Todos...";
            this.rdbcedula.UseVisualStyleBackColor = true;
            // 
            // rdbapellido
            // 
            this.rdbapellido.AutoSize = true;
            this.rdbapellido.Location = new System.Drawing.Point(137, 48);
            this.rdbapellido.Name = "rdbapellido";
            this.rdbapellido.Size = new System.Drawing.Size(62, 17);
            this.rdbapellido.TabIndex = 40;
            this.rdbapellido.Text = "Apellido";
            this.rdbapellido.UseVisualStyleBackColor = true;
            // 
            // rdbid
            // 
            this.rdbid.AutoSize = true;
            this.rdbid.Location = new System.Drawing.Point(196, 27);
            this.rdbid.Name = "rdbid";
            this.rdbid.Size = new System.Drawing.Size(34, 17);
            this.rdbid.TabIndex = 41;
            this.rdbid.Text = "Id";
            this.rdbid.UseVisualStyleBackColor = true;
            // 
            // rdbnombre
            // 
            this.rdbnombre.AutoSize = true;
            this.rdbnombre.Location = new System.Drawing.Point(137, 27);
            this.rdbnombre.Name = "rdbnombre";
            this.rdbnombre.Size = new System.Drawing.Size(62, 17);
            this.rdbnombre.TabIndex = 42;
            this.rdbnombre.Text = "Nombre";
            this.rdbnombre.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnbuscar.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(277, 45);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(140, 38);
            this.btnbuscar.TabIndex = 34;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(433, 9);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(91, 74);
            this.btnagregar.TabIndex = 35;
            this.btnagregar.Text = "Agregar Empleado (+)";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // datanomina
            // 
            this.datanomina.AllowUserToAddRows = false;
            this.datanomina.AllowUserToDeleteRows = false;
            this.datanomina.AllowUserToResizeColumns = false;
            this.datanomina.AllowUserToResizeRows = false;
            this.datanomina.BackgroundColor = System.Drawing.Color.Azure;
            this.datanomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datanomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.Nombre,
            this.sueldobruto,
            this.cargo,
            this.ahorros,
            this.isr});
            this.datanomina.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datanomina.Location = new System.Drawing.Point(528, 262);
            this.datanomina.Name = "datanomina";
            this.datanomina.ReadOnly = true;
            this.datanomina.RowHeadersVisible = false;
            this.datanomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datanomina.Size = new System.Drawing.Size(170, 77);
            this.datanomina.TabIndex = 38;
            // 
            // cedula
            // 
            this.cedula.HeaderText = "ID";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 130;
            // 
            // sueldobruto
            // 
            this.sueldobruto.HeaderText = "Apellido";
            this.sueldobruto.Name = "sueldobruto";
            this.sueldobruto.ReadOnly = true;
            this.sueldobruto.Width = 150;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 120;
            // 
            // ahorros
            // 
            this.ahorros.HeaderText = "Departamento";
            this.ahorros.Name = "ahorros";
            this.ahorros.ReadOnly = true;
            this.ahorros.Width = 120;
            // 
            // isr
            // 
            this.isr.HeaderText = "Fecha Ing.";
            this.isr.Name = "isr";
            this.isr.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "Empleados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Buscar Por";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 302);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(550, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 85);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListaDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbbuscar);
            this.Controls.Add(this.rdbcedula);
            this.Controls.Add(this.rdbapellido);
            this.Controls.Add(this.rdbid);
            this.Controls.Add(this.rdbnombre);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.datanomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaDeEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Empleados";
            this.Load += new System.EventHandler(this.ListaDeEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datanomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbbuscar;
        private System.Windows.Forms.RadioButton rdbcedula;
        private System.Windows.Forms.RadioButton rdbapellido;
        private System.Windows.Forms.RadioButton rdbid;
        private System.Windows.Forms.RadioButton rdbnombre;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView datanomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldobruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ahorros;
        private System.Windows.Forms.DataGridViewTextBoxColumn isr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}