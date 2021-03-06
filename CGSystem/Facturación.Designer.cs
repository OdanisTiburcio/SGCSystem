﻿namespace CGSystem
{
    partial class Facturación
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturación));
            this.btneliminiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcliente = new System.Windows.Forms.TextBox();
            this.lbidcliente = new System.Windows.Forms.Label();
            this.tbidcliente = new System.Windows.Forms.TextBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.lbfecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbnumfactura = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.tbproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvListaServicios = new System.Windows.Forms.DataGridView();
            this.iddetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldobruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahorros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsearch = new System.Windows.Forms.PictureBox();
            this.btbuscar = new System.Windows.Forms.PictureBox();
            this.rdContado = new System.Windows.Forms.RadioButton();
            this.rdCredito = new System.Windows.Forms.RadioButton();
            this.cbingreso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminiar
            // 
            this.btneliminiar.Font = new System.Drawing.Font("Impact", 18.25F);
            this.btneliminiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneliminiar.Location = new System.Drawing.Point(310, 384);
            this.btneliminiar.Name = "btneliminiar";
            this.btneliminiar.Size = new System.Drawing.Size(158, 72);
            this.btneliminiar.TabIndex = 121;
            this.btneliminiar.Text = "ELIMINAR SERVICIO";
            this.btneliminiar.UseVisualStyleBackColor = true;
            this.btneliminiar.Click += new System.EventHandler(this.btneliminiar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(167, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 125;
            this.button1.Text = "Nueva Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 141;
            this.label6.Text = "Crédito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 140;
            this.label5.Text = "Contado";
            // 
            // tbtotal
            // 
            this.tbtotal.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.tbtotal.ForeColor = System.Drawing.Color.Blue;
            this.tbtotal.Location = new System.Drawing.Point(610, 389);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.ReadOnly = true;
            this.tbtotal.Size = new System.Drawing.Size(167, 26);
            this.tbtotal.TabIndex = 139;
            this.tbtotal.Text = "RD$ 0.00";
            this.tbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(544, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 138;
            this.label4.Text = "Total";
            // 
            // tbcliente
            // 
            this.tbcliente.Enabled = false;
            this.tbcliente.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcliente.Location = new System.Drawing.Point(594, 106);
            this.tbcliente.Name = "tbcliente";
            this.tbcliente.Size = new System.Drawing.Size(167, 22);
            this.tbcliente.TabIndex = 135;
            this.tbcliente.Text = "Cliente";
            // 
            // lbidcliente
            // 
            this.lbidcliente.AutoSize = true;
            this.lbidcliente.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidcliente.Location = new System.Drawing.Point(564, 133);
            this.lbidcliente.Name = "lbidcliente";
            this.lbidcliente.Size = new System.Drawing.Size(27, 23);
            this.lbidcliente.TabIndex = 134;
            this.lbidcliente.Text = "Id";
            // 
            // tbidcliente
            // 
            this.tbidcliente.Enabled = false;
            this.tbidcliente.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbidcliente.Location = new System.Drawing.Point(594, 134);
            this.tbidcliente.Name = "tbidcliente";
            this.tbidcliente.Size = new System.Drawing.Size(83, 22);
            this.tbidcliente.TabIndex = 2;
            this.tbidcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnsearch_Click);
            this.tbidcliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnsearch_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Enabled = false;
            this.btnimprimir.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.Blue;
            this.btnimprimir.Location = new System.Drawing.Point(167, 384);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(137, 29);
            this.btnimprimir.TabIndex = 124;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Goudy Old Style", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbfecha.Location = new System.Drawing.Point(714, 5);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(96, 21);
            this.lbfecha.TabIndex = 130;
            this.lbfecha.Text = "00/00/0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 129;
            this.label2.Text = "Cliente";
            // 
            // lbnumfactura
            // 
            this.lbnumfactura.AutoSize = true;
            this.lbnumfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbnumfactura.Location = new System.Drawing.Point(627, 25);
            this.lbnumfactura.Name = "lbnumfactura";
            this.lbnumfactura.Size = new System.Drawing.Size(119, 20);
            this.lbnumfactura.TabIndex = 131;
            this.lbnumfactura.Text = "No. Factura: ";
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnguardar.Location = new System.Drawing.Point(3, 384);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(158, 72);
            this.btnguardar.TabIndex = 120;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // tbproducto
            // 
            this.tbproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbproducto.Location = new System.Drawing.Point(286, 25);
            this.tbproducto.Name = "tbproducto";
            this.tbproducto.Size = new System.Drawing.Size(182, 22);
            this.tbproducto.TabIndex = 1;
            this.tbproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbproducto_KeyPress);
            this.tbproducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbproducto_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 50);
            this.label1.TabIndex = 128;
            this.label1.Text = "Servicio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(13, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 44);
            this.label11.TabIndex = 146;
            this.label11.Text = "Facturar";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 18.25F);
            this.button2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Location = new System.Drawing.Point(564, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 41);
            this.button2.TabIndex = 147;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvListaServicios
            // 
            this.dgvListaServicios.AllowUserToAddRows = false;
            this.dgvListaServicios.AllowUserToResizeColumns = false;
            this.dgvListaServicios.AllowUserToResizeRows = false;
            this.dgvListaServicios.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvListaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetalle,
            this.cedula,
            this.dataGridViewTextBoxColumn1,
            this.sueldobruto,
            this.cargo,
            this.ahorros,
            this.isr});
            this.dgvListaServicios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvListaServicios.Location = new System.Drawing.Point(6, 53);
            this.dgvListaServicios.Name = "dgvListaServicios";
            this.dgvListaServicios.RowHeadersVisible = false;
            this.dgvListaServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaServicios.Size = new System.Drawing.Size(508, 319);
            this.dgvListaServicios.TabIndex = 148;
            this.dgvListaServicios.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaServicios_CellValueChanged);
            this.dgvListaServicios.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvListaServicios_UserDeletedRow_1);
            // 
            // iddetalle
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iddetalle.DefaultCellStyle = dataGridViewCellStyle1;
            this.iddetalle.HeaderText = "#";
            this.iddetalle.Name = "iddetalle";
            this.iddetalle.Width = 25;
            // 
            // cedula
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cedula.DefaultCellStyle = dataGridViewCellStyle2;
            this.cedula.HeaderText = "Código";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 45;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 185;
            // 
            // sueldobruto
            // 
            this.sueldobruto.HeaderText = "Precio";
            this.sueldobruto.Name = "sueldobruto";
            this.sueldobruto.ReadOnly = true;
            this.sueldobruto.Width = 65;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Días(+)";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 50;
            // 
            // ahorros
            // 
            this.ahorros.HeaderText = "Cantidad";
            this.ahorros.MaxInputLength = 4;
            this.ahorros.Name = "ahorros";
            this.ahorros.ReadOnly = true;
            this.ahorros.Width = 60;
            // 
            // isr
            // 
            this.isr.HeaderText = "Total";
            this.isr.Name = "isr";
            this.isr.ReadOnly = true;
            this.isr.Width = 75;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Image = global::CGSystem.Properties.Resources.lupa_psd_468x468;
            this.btnsearch.Location = new System.Drawing.Point(764, 98);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(43, 38);
            this.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsearch.TabIndex = 136;
            this.btnsearch.TabStop = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btbuscar
            // 
            this.btbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar.Image = global::CGSystem.Properties.Resources.lupa_psd_468x468;
            this.btbuscar.Location = new System.Drawing.Point(469, 14);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(55, 36);
            this.btbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btbuscar.TabIndex = 126;
            this.btbuscar.TabStop = false;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // rdContado
            // 
            this.rdContado.AutoSize = true;
            this.rdContado.Checked = true;
            this.rdContado.Location = new System.Drawing.Point(610, 83);
            this.rdContado.Name = "rdContado";
            this.rdContado.Size = new System.Drawing.Size(14, 13);
            this.rdContado.TabIndex = 150;
            this.rdContado.TabStop = true;
            this.rdContado.UseVisualStyleBackColor = true;
            this.rdContado.CheckedChanged += new System.EventHandler(this.rdContado_CheckedChanged);
            this.rdContado.Click += new System.EventHandler(this.rdContado_Click);
            // 
            // rdCredito
            // 
            this.rdCredito.AutoSize = true;
            this.rdCredito.Location = new System.Drawing.Point(718, 83);
            this.rdCredito.Name = "rdCredito";
            this.rdCredito.Size = new System.Drawing.Size(14, 13);
            this.rdCredito.TabIndex = 150;
            this.rdCredito.UseVisualStyleBackColor = true;
            this.rdCredito.CheckedChanged += new System.EventHandler(this.rdCredito_CheckedChanged);
            this.rdCredito.Click += new System.EventHandler(this.rdCredito_Click);
            // 
            // cbingreso
            // 
            this.cbingreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbingreso.FormattingEnabled = true;
            this.cbingreso.Items.AddRange(new object[] {
            "EFECTIVO",
            "CHEQUE",
            "TARJETA CREDITO"});
            this.cbingreso.Location = new System.Drawing.Point(662, 53);
            this.cbingreso.Name = "cbingreso";
            this.cbingreso.Size = new System.Drawing.Size(134, 21);
            this.cbingreso.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(540, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 152;
            this.label3.Text = "Método de Pago";
            // 
            // Facturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 464);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbingreso);
            this.Controls.Add(this.rdCredito);
            this.Controls.Add(this.rdContado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvListaServicios);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btneliminiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbcliente);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lbidcliente);
            this.Controls.Add(this.tbidcliente);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbnumfactura);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.tbproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(824, 503);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(824, 503);
            this.Name = "Facturación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Facturación_FormClosing);
            this.Load += new System.EventHandler(this.Facturación_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbcliente;
        private System.Windows.Forms.PictureBox btnsearch;
        private System.Windows.Forms.Label lbidcliente;
        private System.Windows.Forms.TextBox tbidcliente;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbnumfactura;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox tbproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btbuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvListaServicios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdContado;
        private System.Windows.Forms.RadioButton rdCredito;
        private System.Windows.Forms.ComboBox cbingreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldobruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ahorros;
        private System.Windows.Forms.DataGridViewTextBoxColumn isr;
    }
}