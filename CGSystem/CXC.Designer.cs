namespace CGSystem
{
    partial class CXC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpagartotal = new System.Windows.Forms.TextBox();
            this.dgvCuentasPorCobrar = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.btnpagarfactura = new System.Windows.Forms.Button();
            this.btnimpingreso = new System.Windows.Forms.Button();
            this.btnimprimirestado = new System.Windows.Forms.Button();
            this.tbvalorapagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btbuscar1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbingreso = new System.Windows.Forms.ComboBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.btnpagartotal = new System.Windows.Forms.Button();
            this.btnmostrartodas = new System.Windows.Forms.Button();
            this.btnmostrarvencidas = new System.Windows.Forms.Button();
            this.btncuentasaldada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasPorCobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(477, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 116;
            this.label4.Text = "Total";
            // 
            // tbpagartotal
            // 
            this.tbpagartotal.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold);
            this.tbpagartotal.ForeColor = System.Drawing.Color.Red;
            this.tbpagartotal.Location = new System.Drawing.Point(543, 280);
            this.tbpagartotal.Name = "tbpagartotal";
            this.tbpagartotal.ReadOnly = true;
            this.tbpagartotal.Size = new System.Drawing.Size(126, 23);
            this.tbpagartotal.TabIndex = 115;
            this.tbpagartotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbpagartotal.Enter += new System.EventHandler(this.tbpagartotal_Enter);
            this.tbpagartotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbpagartotal_KeyDown);
            this.tbpagartotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtotal_KeyPress);
            this.tbpagartotal.Leave += new System.EventHandler(this.tbpagartotal_Leave);
            // 
            // dgvCuentasPorCobrar
            // 
            this.dgvCuentasPorCobrar.AllowUserToAddRows = false;
            this.dgvCuentasPorCobrar.AllowUserToDeleteRows = false;
            this.dgvCuentasPorCobrar.AllowUserToResizeColumns = false;
            this.dgvCuentasPorCobrar.AllowUserToResizeRows = false;
            this.dgvCuentasPorCobrar.BackgroundColor = System.Drawing.Color.White;
            this.dgvCuentasPorCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentasPorCobrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fact,
            this.total,
            this.restante,
            this.nombrecliente,
            this.fecha});
            this.dgvCuentasPorCobrar.Location = new System.Drawing.Point(12, 78);
            this.dgvCuentasPorCobrar.Name = "dgvCuentasPorCobrar";
            this.dgvCuentasPorCobrar.ReadOnly = true;
            this.dgvCuentasPorCobrar.RowHeadersVisible = false;
            this.dgvCuentasPorCobrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentasPorCobrar.Size = new System.Drawing.Size(657, 180);
            this.dgvCuentasPorCobrar.TabIndex = 114;
            this.dgvCuentasPorCobrar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentasPorCobrar_CellDoubleClick);
            // 
            // id
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // fact
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fact.DefaultCellStyle = dataGridViewCellStyle2;
            this.fact.HeaderText = "Factura #";
            this.fact.Name = "fact";
            this.fact.ReadOnly = true;
            this.fact.Width = 90;
            // 
            // total
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.total.DefaultCellStyle = dataGridViewCellStyle3;
            this.total.HeaderText = "Valor Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 120;
            // 
            // restante
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.restante.DefaultCellStyle = dataGridViewCellStyle4;
            this.restante.HeaderText = "Valor Restante";
            this.restante.Name = "restante";
            this.restante.ReadOnly = true;
            this.restante.Width = 120;
            // 
            // nombrecliente
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nombrecliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.nombrecliente.HeaderText = "Cliente";
            this.nombrecliente.Name = "nombrecliente";
            this.nombrecliente.ReadOnly = true;
            this.nombrecliente.Width = 174;
            // 
            // fecha
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle6;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // tbcodigo
            // 
            this.tbcodigo.Enabled = false;
            this.tbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbcodigo.Location = new System.Drawing.Point(317, 45);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(82, 23);
            this.tbcodigo.TabIndex = 112;
            // 
            // btnpagarfactura
            // 
            this.btnpagarfactura.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpagarfactura.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold);
            this.btnpagarfactura.Location = new System.Drawing.Point(12, 267);
            this.btnpagarfactura.Name = "btnpagarfactura";
            this.btnpagarfactura.Size = new System.Drawing.Size(156, 34);
            this.btnpagarfactura.TabIndex = 110;
            this.btnpagarfactura.Text = "Pagar Factura";
            this.btnpagarfactura.UseVisualStyleBackColor = false;
            this.btnpagarfactura.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnimpingreso
            // 
            this.btnimpingreso.BackColor = System.Drawing.Color.Cornsilk;
            this.btnimpingreso.Enabled = false;
            this.btnimpingreso.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold);
            this.btnimpingreso.Location = new System.Drawing.Point(12, 305);
            this.btnimpingreso.Name = "btnimpingreso";
            this.btnimpingreso.Size = new System.Drawing.Size(290, 41);
            this.btnimpingreso.TabIndex = 106;
            this.btnimpingreso.Text = "Imprimir Ingreso";
            this.btnimpingreso.UseVisualStyleBackColor = false;
            this.btnimpingreso.Click += new System.EventHandler(this.btnimpingreso_Click);
            // 
            // btnimprimirestado
            // 
            this.btnimprimirestado.BackColor = System.Drawing.Color.Cornsilk;
            this.btnimprimirestado.Enabled = false;
            this.btnimprimirestado.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimirestado.Location = new System.Drawing.Point(309, 273);
            this.btnimprimirestado.Name = "btnimprimirestado";
            this.btnimprimirestado.Size = new System.Drawing.Size(163, 70);
            this.btnimprimirestado.TabIndex = 105;
            this.btnimprimirestado.Text = "Imprimir Estado de Cuenta";
            this.btnimprimirestado.UseVisualStyleBackColor = false;
            this.btnimprimirestado.Click += new System.EventHandler(this.btnimprimirestado_Click);
            // 
            // tbvalorapagar
            // 
            this.tbvalorapagar.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvalorapagar.HideSelection = false;
            this.tbvalorapagar.Location = new System.Drawing.Point(174, 273);
            this.tbvalorapagar.MaxLength = 7;
            this.tbvalorapagar.Name = "tbvalorapagar";
            this.tbvalorapagar.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbvalorapagar.Size = new System.Drawing.Size(128, 27);
            this.tbvalorapagar.TabIndex = 103;
            this.tbvalorapagar.Text = "RD$ 0.00";
            this.tbvalorapagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbvalorapagar.Enter += new System.EventHandler(this.tbvalorapagar_Enter);
            this.tbvalorapagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbvalorapagar_KeyDown);
            this.tbvalorapagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbvalorapagar_KeyPress);
            this.tbvalorapagar.Leave += new System.EventHandler(this.tbvalorapagar_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(234, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 109;
            this.label2.Text = "Código";
            // 
            // tbnombre
            // 
            this.tbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbnombre.Location = new System.Drawing.Point(317, 14);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(300, 23);
            this.tbnombre.TabIndex = 102;
            this.tbnombre.TextChanged += new System.EventHandler(this.tbnombre_TextChanged);
            this.tbnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnombre_KeyPress);
            this.tbnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbnombre_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 108;
            this.label1.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(0, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 68);
            this.label3.TabIndex = 107;
            this.label3.Text = "Cuenta por Cobrar";
            // 
            // btbuscar1
            // 
            this.btbuscar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar1.Image = global::CGSystem.Properties.Resources.lupa_psd_468x468;
            this.btbuscar1.Location = new System.Drawing.Point(623, 7);
            this.btbuscar1.Name = "btbuscar1";
            this.btbuscar1.Size = new System.Drawing.Size(46, 39);
            this.btbuscar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btbuscar1.TabIndex = 111;
            this.btbuscar1.TabStop = false;
            this.btbuscar1.Click += new System.EventHandler(this.btbuscar1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(405, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 154;
            this.label5.Text = "Método de Pago";
            // 
            // cbingreso
            // 
            this.cbingreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbingreso.FormattingEnabled = true;
            this.cbingreso.Items.AddRange(new object[] {
            "EFECTIVO",
            "CHEQUE",
            "TARJETA CREDITO"});
            this.cbingreso.Location = new System.Drawing.Point(525, 47);
            this.cbingreso.Name = "cbingreso";
            this.cbingreso.Size = new System.Drawing.Size(145, 21);
            this.cbingreso.TabIndex = 153;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.BackColor = System.Drawing.SystemColors.Control;
            this.lbtotal.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold);
            this.lbtotal.ForeColor = System.Drawing.Color.Red;
            this.lbtotal.Location = new System.Drawing.Point(546, 284);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(67, 16);
            this.lbtotal.TabIndex = 155;
            this.lbtotal.Text = "RD$ 0.00";
            // 
            // btnpagartotal
            // 
            this.btnpagartotal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnpagartotal.Enabled = false;
            this.btnpagartotal.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagartotal.Location = new System.Drawing.Point(482, 308);
            this.btnpagartotal.Name = "btnpagartotal";
            this.btnpagartotal.Size = new System.Drawing.Size(187, 38);
            this.btnpagartotal.TabIndex = 104;
            this.btnpagartotal.Text = "Pagar Total";
            this.btnpagartotal.UseVisualStyleBackColor = false;
            this.btnpagartotal.Click += new System.EventHandler(this.btcsave_Click);
            // 
            // btnmostrartodas
            // 
            this.btnmostrartodas.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnmostrartodas.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrartodas.Location = new System.Drawing.Point(12, 352);
            this.btnmostrartodas.Name = "btnmostrartodas";
            this.btnmostrartodas.Size = new System.Drawing.Size(187, 57);
            this.btnmostrartodas.TabIndex = 156;
            this.btnmostrartodas.Text = "Mostrar Todas";
            this.btnmostrartodas.UseVisualStyleBackColor = false;
            this.btnmostrartodas.Click += new System.EventHandler(this.btnmostrartodas_Click);
            // 
            // btnmostrarvencidas
            // 
            this.btnmostrarvencidas.BackColor = System.Drawing.Color.FloralWhite;
            this.btnmostrarvencidas.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrarvencidas.Location = new System.Drawing.Point(205, 352);
            this.btnmostrarvencidas.Name = "btnmostrarvencidas";
            this.btnmostrarvencidas.Size = new System.Drawing.Size(187, 57);
            this.btnmostrarvencidas.TabIndex = 157;
            this.btnmostrarvencidas.Text = "Mostrar Vencidas";
            this.btnmostrarvencidas.UseVisualStyleBackColor = false;
            this.btnmostrarvencidas.Click += new System.EventHandler(this.btnmostrarvencidas_Click);
            // 
            // btncuentasaldada
            // 
            this.btncuentasaldada.BackColor = System.Drawing.SystemColors.Info;
            this.btncuentasaldada.Font = new System.Drawing.Font("Forte", 17F);
            this.btncuentasaldada.Location = new System.Drawing.Point(398, 352);
            this.btncuentasaldada.Name = "btncuentasaldada";
            this.btncuentasaldada.Size = new System.Drawing.Size(271, 57);
            this.btncuentasaldada.TabIndex = 158;
            this.btncuentasaldada.Text = "Cuentas Saldadas";
            this.btncuentasaldada.UseVisualStyleBackColor = false;
            this.btncuentasaldada.Click += new System.EventHandler(this.btncuentasaldada_Click);
            // 
            // CXC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 419);
            this.Controls.Add(this.btncuentasaldada);
            this.Controls.Add(this.btnmostrarvencidas);
            this.Controls.Add(this.btnmostrartodas);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.cbingreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbpagartotal);
            this.Controls.Add(this.dgvCuentasPorCobrar);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.btnpagarfactura);
            this.Controls.Add(this.btnimpingreso);
            this.Controls.Add(this.btnimprimirestado);
            this.Controls.Add(this.btnpagartotal);
            this.Controls.Add(this.tbvalorapagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btbuscar1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(697, 458);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(697, 458);
            this.Name = "CXC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta por Cobrar";
            this.Load += new System.EventHandler(this.CXC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasPorCobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbpagartotal;
        private System.Windows.Forms.DataGridView dgvCuentasPorCobrar;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.Button btnpagarfactura;
        private System.Windows.Forms.Button btnimpingreso;
        private System.Windows.Forms.Button btnimprimirestado;
        private System.Windows.Forms.TextBox tbvalorapagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btbuscar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbingreso;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn restante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Button btnpagartotal;
        private System.Windows.Forms.Button btnmostrartodas;
        private System.Windows.Forms.Button btnmostrarvencidas;
        private System.Windows.Forms.Button btncuentasaldada;
    }
}