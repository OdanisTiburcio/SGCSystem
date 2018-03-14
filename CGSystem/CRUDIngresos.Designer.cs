namespace CGSystem
{
    partial class CRUDIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDIngresos));
            this.dgvdetalleingresos = new System.Windows.Forms.DataGridView();
            this.bntimprimiringreso = new System.Windows.Forms.Button();
            this.btbuscaringreso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpIngresohasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbseleccion = new System.Windows.Forms.TextBox();
            this.dtpIngresodesde = new System.Windows.Forms.DateTimePicker();
            this.rbfechadesdeingresos = new System.Windows.Forms.RadioButton();
            this.rbtodosingresos = new System.Windows.Forms.RadioButton();
            this.rbnumerofact = new System.Windows.Forms.RadioButton();
            this.rbcodigoingreso = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminaringreso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleingresos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdetalleingresos
            // 
            this.dgvdetalleingresos.AllowDrop = true;
            this.dgvdetalleingresos.AllowUserToAddRows = false;
            this.dgvdetalleingresos.AllowUserToDeleteRows = false;
            this.dgvdetalleingresos.AllowUserToOrderColumns = true;
            this.dgvdetalleingresos.AllowUserToResizeColumns = false;
            this.dgvdetalleingresos.AllowUserToResizeRows = false;
            this.dgvdetalleingresos.BackgroundColor = System.Drawing.Color.White;
            this.dgvdetalleingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalleingresos.Location = new System.Drawing.Point(12, 98);
            this.dgvdetalleingresos.MultiSelect = false;
            this.dgvdetalleingresos.Name = "dgvdetalleingresos";
            this.dgvdetalleingresos.ReadOnly = true;
            this.dgvdetalleingresos.RowHeadersVisible = false;
            this.dgvdetalleingresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalleingresos.Size = new System.Drawing.Size(515, 268);
            this.dgvdetalleingresos.TabIndex = 3;
            // 
            // bntimprimiringreso
            // 
            this.bntimprimiringreso.BackColor = System.Drawing.Color.Cornsilk;
            this.bntimprimiringreso.Enabled = false;
            this.bntimprimiringreso.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntimprimiringreso.Location = new System.Drawing.Point(442, 53);
            this.bntimprimiringreso.Name = "bntimprimiringreso";
            this.bntimprimiringreso.Size = new System.Drawing.Size(85, 40);
            this.bntimprimiringreso.TabIndex = 37;
            this.bntimprimiringreso.Text = "Imprimir";
            this.bntimprimiringreso.UseVisualStyleBackColor = false;
            this.bntimprimiringreso.Click += new System.EventHandler(this.bntimprimiringreso_Click);
            // 
            // btbuscaringreso
            // 
            this.btbuscaringreso.BackColor = System.Drawing.Color.Cornsilk;
            this.btbuscaringreso.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscaringreso.Location = new System.Drawing.Point(442, 8);
            this.btbuscaringreso.Name = "btbuscaringreso";
            this.btbuscaringreso.Size = new System.Drawing.Size(85, 40);
            this.btbuscaringreso.TabIndex = 34;
            this.btbuscaringreso.Text = "Buscar";
            this.btbuscaringreso.UseVisualStyleBackColor = false;
            this.btbuscaringreso.Click += new System.EventHandler(this.btbuscaringreso_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "y";
            // 
            // dtpIngresohasta
            // 
            this.dtpIngresohasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngresohasta.Location = new System.Drawing.Point(306, 49);
            this.dtpIngresohasta.Name = "dtpIngresohasta";
            this.dtpIngresohasta.Size = new System.Drawing.Size(84, 24);
            this.dtpIngresohasta.TabIndex = 40;
            this.dtpIngresohasta.Value = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            this.dtpIngresohasta.ValueChanged += new System.EventHandler(this.dtpIngresohasta_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbseleccion);
            this.groupBox1.Controls.Add(this.dtpIngresodesde);
            this.groupBox1.Controls.Add(this.rbfechadesdeingresos);
            this.groupBox1.Controls.Add(this.dtpIngresohasta);
            this.groupBox1.Controls.Add(this.rbtodosingresos);
            this.groupBox1.Controls.Add(this.rbnumerofact);
            this.groupBox1.Controls.Add(this.rbcodigoingreso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 79);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Ingresos";
            // 
            // tbseleccion
            // 
            this.tbseleccion.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbseleccion.Location = new System.Drawing.Point(362, 23);
            this.tbseleccion.Name = "tbseleccion";
            this.tbseleccion.Size = new System.Drawing.Size(53, 21);
            this.tbseleccion.TabIndex = 42;
            // 
            // dtpIngresodesde
            // 
            this.dtpIngresodesde.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngresodesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngresodesde.Location = new System.Drawing.Point(191, 49);
            this.dtpIngresodesde.Name = "dtpIngresodesde";
            this.dtpIngresodesde.Size = new System.Drawing.Size(84, 24);
            this.dtpIngresodesde.TabIndex = 41;
            this.dtpIngresodesde.Value = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            this.dtpIngresodesde.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rbfechadesdeingresos
            // 
            this.rbfechadesdeingresos.AutoSize = true;
            this.rbfechadesdeingresos.Location = new System.Drawing.Point(91, 50);
            this.rbfechadesdeingresos.Name = "rbfechadesdeingresos";
            this.rbfechadesdeingresos.Size = new System.Drawing.Size(100, 21);
            this.rbfechadesdeingresos.TabIndex = 4;
            this.rbfechadesdeingresos.TabStop = true;
            this.rbfechadesdeingresos.Text = "Fecha entre:";
            this.rbfechadesdeingresos.UseVisualStyleBackColor = true;
            // 
            // rbtodosingresos
            // 
            this.rbtodosingresos.AutoSize = true;
            this.rbtodosingresos.Checked = true;
            this.rbtodosingresos.Location = new System.Drawing.Point(91, 23);
            this.rbtodosingresos.Name = "rbtodosingresos";
            this.rbtodosingresos.Size = new System.Drawing.Size(65, 21);
            this.rbtodosingresos.TabIndex = 3;
            this.rbtodosingresos.TabStop = true;
            this.rbtodosingresos.Text = "Todo...";
            this.rbtodosingresos.UseVisualStyleBackColor = true;
            // 
            // rbnumerofact
            // 
            this.rbnumerofact.AutoSize = true;
            this.rbnumerofact.Location = new System.Drawing.Point(238, 23);
            this.rbnumerofact.Name = "rbnumerofact";
            this.rbnumerofact.Size = new System.Drawing.Size(126, 21);
            this.rbnumerofact.TabIndex = 3;
            this.rbnumerofact.TabStop = true;
            this.rbnumerofact.Text = "Número Factura";
            this.rbnumerofact.UseVisualStyleBackColor = true;
            // 
            // rbcodigoingreso
            // 
            this.rbcodigoingreso.AutoSize = true;
            this.rbcodigoingreso.Location = new System.Drawing.Point(165, 23);
            this.rbcodigoingreso.Name = "rbcodigoingreso";
            this.rbcodigoingreso.Size = new System.Drawing.Size(67, 21);
            this.rbcodigoingreso.TabIndex = 2;
            this.rbcodigoingreso.TabStop = true;
            this.rbcodigoingreso.Text = "Código";
            this.rbcodigoingreso.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por:";
            // 
            // btneliminaringreso
            // 
            this.btneliminaringreso.BackColor = System.Drawing.Color.Coral;
            this.btneliminaringreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminaringreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminaringreso.Location = new System.Drawing.Point(167, 371);
            this.btneliminaringreso.Name = "btneliminaringreso";
            this.btneliminaringreso.Size = new System.Drawing.Size(201, 35);
            this.btneliminaringreso.TabIndex = 42;
            this.btneliminaringreso.Text = "Eliminar Ingreso";
            this.btneliminaringreso.UseVisualStyleBackColor = false;
            this.btneliminaringreso.Click += new System.EventHandler(this.btneliminaringreso_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 29);
            this.button1.TabIndex = 43;
            this.button1.Text = "Hoy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CRUDIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 411);
            this.Controls.Add(this.btneliminaringreso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntimprimiringreso);
            this.Controls.Add(this.btbuscaringreso);
            this.Controls.Add(this.dgvdetalleingresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(552, 449);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(552, 449);
            this.Name = "CRUDIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Ingresos";
            this.Load += new System.EventHandler(this.CRUDIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleingresos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdetalleingresos;
        private System.Windows.Forms.Button bntimprimiringreso;
        public System.Windows.Forms.Button btbuscaringreso;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpIngresohasta;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dtpIngresodesde;
        private System.Windows.Forms.RadioButton rbfechadesdeingresos;
        private System.Windows.Forms.RadioButton rbnumerofact;
        private System.Windows.Forms.RadioButton rbcodigoingreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtodosingresos;
        private System.Windows.Forms.TextBox tbseleccion;
        private System.Windows.Forms.Button btneliminaringreso;
        public System.Windows.Forms.Button button1;
    }
}