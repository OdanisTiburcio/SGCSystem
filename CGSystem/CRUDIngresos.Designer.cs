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
            this.dgvdetalleingresos = new System.Windows.Forms.DataGridView();
            this.bntimprimiringreso = new System.Windows.Forms.Button();
            this.btneliminaringreso = new System.Windows.Forms.Button();
            this.btnactualizaringreso = new System.Windows.Forms.Button();
            this.btbuscaringreso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpIngresohasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpIngresodesde = new System.Windows.Forms.DateTimePicker();
            this.rbfechadesdeingresos = new System.Windows.Forms.RadioButton();
            this.rbtodosingresos = new System.Windows.Forms.RadioButton();
            this.rbnumerofact = new System.Windows.Forms.RadioButton();
            this.rbcodigoingreso = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbseleccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleingresos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdetalleingresos
            // 
            this.dgvdetalleingresos.BackgroundColor = System.Drawing.Color.White;
            this.dgvdetalleingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalleingresos.Location = new System.Drawing.Point(12, 98);
            this.dgvdetalleingresos.Name = "dgvdetalleingresos";
            this.dgvdetalleingresos.Size = new System.Drawing.Size(515, 217);
            this.dgvdetalleingresos.TabIndex = 3;
            // 
            // bntimprimiringreso
            // 
            this.bntimprimiringreso.BackColor = System.Drawing.Color.Cornsilk;
            this.bntimprimiringreso.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntimprimiringreso.Location = new System.Drawing.Point(397, 321);
            this.bntimprimiringreso.Name = "bntimprimiringreso";
            this.bntimprimiringreso.Size = new System.Drawing.Size(124, 49);
            this.bntimprimiringreso.TabIndex = 37;
            this.bntimprimiringreso.Text = "Imprimir";
            this.bntimprimiringreso.UseVisualStyleBackColor = false;
            // 
            // btneliminaringreso
            // 
            this.btneliminaringreso.BackColor = System.Drawing.Color.Cornsilk;
            this.btneliminaringreso.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminaringreso.Location = new System.Drawing.Point(270, 321);
            this.btneliminaringreso.Name = "btneliminaringreso";
            this.btneliminaringreso.Size = new System.Drawing.Size(124, 49);
            this.btneliminaringreso.TabIndex = 36;
            this.btneliminaringreso.Text = "Eliminar";
            this.btneliminaringreso.UseVisualStyleBackColor = false;
            // 
            // btnactualizaringreso
            // 
            this.btnactualizaringreso.BackColor = System.Drawing.Color.Cornsilk;
            this.btnactualizaringreso.CausesValidation = false;
            this.btnactualizaringreso.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizaringreso.Location = new System.Drawing.Point(143, 321);
            this.btnactualizaringreso.Name = "btnactualizaringreso";
            this.btnactualizaringreso.Size = new System.Drawing.Size(124, 49);
            this.btnactualizaringreso.TabIndex = 35;
            this.btnactualizaringreso.Text = "Actualizar";
            this.btnactualizaringreso.UseVisualStyleBackColor = false;
            // 
            // btbuscaringreso
            // 
            this.btbuscaringreso.BackColor = System.Drawing.Color.Cornsilk;
            this.btbuscaringreso.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscaringreso.Location = new System.Drawing.Point(16, 321);
            this.btbuscaringreso.Name = "btbuscaringreso";
            this.btbuscaringreso.Size = new System.Drawing.Size(124, 49);
            this.btbuscaringreso.TabIndex = 34;
            this.btbuscaringreso.Text = "Buscar";
            this.btbuscaringreso.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hasta:";
            // 
            // dtpIngresohasta
            // 
            this.dtpIngresohasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngresohasta.Location = new System.Drawing.Point(367, 49);
            this.dtpIngresohasta.Name = "dtpIngresohasta";
            this.dtpIngresohasta.Size = new System.Drawing.Size(84, 24);
            this.dtpIngresohasta.TabIndex = 40;
            this.dtpIngresohasta.Value = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(514, 79);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Ingresos";
            // 
            // dtpIngresodesde
            // 
            this.dtpIngresodesde.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngresodesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngresodesde.Location = new System.Drawing.Point(227, 49);
            this.dtpIngresodesde.Name = "dtpIngresodesde";
            this.dtpIngresodesde.Size = new System.Drawing.Size(84, 24);
            this.dtpIngresodesde.TabIndex = 41;
            this.dtpIngresodesde.Value = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            this.dtpIngresodesde.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rbfechadesdeingresos
            // 
            this.rbfechadesdeingresos.AutoSize = true;
            this.rbfechadesdeingresos.Location = new System.Drawing.Point(127, 50);
            this.rbfechadesdeingresos.Name = "rbfechadesdeingresos";
            this.rbfechadesdeingresos.Size = new System.Drawing.Size(100, 21);
            this.rbfechadesdeingresos.TabIndex = 4;
            this.rbfechadesdeingresos.TabStop = true;
            this.rbfechadesdeingresos.Text = "Fecha desde:";
            this.rbfechadesdeingresos.UseVisualStyleBackColor = true;
            // 
            // rbtodosingresos
            // 
            this.rbtodosingresos.AutoSize = true;
            this.rbtodosingresos.Checked = true;
            this.rbtodosingresos.Location = new System.Drawing.Point(127, 25);
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
            this.rbnumerofact.Location = new System.Drawing.Point(274, 23);
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
            this.rbcodigoingreso.Location = new System.Drawing.Point(201, 25);
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
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por:";
            // 
            // tbseleccion
            // 
            this.tbseleccion.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbseleccion.Location = new System.Drawing.Point(398, 23);
            this.tbseleccion.Name = "tbseleccion";
            this.tbseleccion.Size = new System.Drawing.Size(53, 21);
            this.tbseleccion.TabIndex = 42;
            // 
            // CRUDIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntimprimiringreso);
            this.Controls.Add(this.btneliminaringreso);
            this.Controls.Add(this.btnactualizaringreso);
            this.Controls.Add(this.btbuscaringreso);
            this.Controls.Add(this.dgvdetalleingresos);
            this.Name = "CRUDIngresos";
            this.Text = "Detalle de Ingresos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleingresos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdetalleingresos;
        private System.Windows.Forms.Button bntimprimiringreso;
        private System.Windows.Forms.Button btneliminaringreso;
        private System.Windows.Forms.Button btnactualizaringreso;
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
    }
}