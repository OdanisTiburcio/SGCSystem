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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.dgvCuentasPorCobrar = new System.Windows.Forms.DataGridView();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btcnew = new System.Windows.Forms.Button();
            this.btimprimir = new System.Windows.Forms.Button();
            this.btcsave = new System.Windows.Forms.Button();
            this.tbdetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btbuscar1 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasPorCobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(477, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 116;
            this.label4.Text = "Total";
            // 
            // tbtotal
            // 
            this.tbtotal.Enabled = false;
            this.tbtotal.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold);
            this.tbtotal.ForeColor = System.Drawing.Color.Red;
            this.tbtotal.Location = new System.Drawing.Point(543, 332);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(126, 23);
            this.tbtotal.TabIndex = 115;
            this.tbtotal.Text = "RD$ 0.00";
            this.tbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.restante});
            this.dgvCuentasPorCobrar.Location = new System.Drawing.Point(12, 133);
            this.dgvCuentasPorCobrar.Name = "dgvCuentasPorCobrar";
            this.dgvCuentasPorCobrar.ReadOnly = true;
            this.dgvCuentasPorCobrar.RowHeadersVisible = false;
            this.dgvCuentasPorCobrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentasPorCobrar.Size = new System.Drawing.Size(657, 180);
            this.dgvCuentasPorCobrar.TabIndex = 114;
            // 
            // tbcodigo
            // 
            this.tbcodigo.Enabled = false;
            this.tbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbcodigo.Location = new System.Drawing.Point(213, 100);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(82, 23);
            this.tbcodigo.TabIndex = 112;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbuscar.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.Location = new System.Drawing.Point(12, 319);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(156, 34);
            this.btnbuscar.TabIndex = 110;
            this.btnbuscar.Text = "Pagar Factura";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // btcnew
            // 
            this.btcnew.BackColor = System.Drawing.Color.Cornsilk;
            this.btcnew.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold);
            this.btcnew.Location = new System.Drawing.Point(12, 357);
            this.btcnew.Name = "btcnew";
            this.btcnew.Size = new System.Drawing.Size(290, 41);
            this.btcnew.TabIndex = 106;
            this.btcnew.Text = "Imprimir Ingreso";
            this.btcnew.UseVisualStyleBackColor = false;
            // 
            // btimprimir
            // 
            this.btimprimir.BackColor = System.Drawing.Color.Cornsilk;
            this.btimprimir.Enabled = false;
            this.btimprimir.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimprimir.Location = new System.Drawing.Point(309, 325);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(163, 70);
            this.btimprimir.TabIndex = 105;
            this.btimprimir.Text = "Imprimir Estado de Cuenta";
            this.btimprimir.UseVisualStyleBackColor = false;
            // 
            // btcsave
            // 
            this.btcsave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btcsave.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcsave.Location = new System.Drawing.Point(482, 360);
            this.btcsave.Name = "btcsave";
            this.btcsave.Size = new System.Drawing.Size(187, 38);
            this.btcsave.TabIndex = 104;
            this.btcsave.Text = "Pagar Total";
            this.btcsave.UseVisualStyleBackColor = false;
            // 
            // tbdetalle
            // 
            this.tbdetalle.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdetalle.Location = new System.Drawing.Point(174, 325);
            this.tbdetalle.MaxLength = 175;
            this.tbdetalle.Multiline = true;
            this.tbdetalle.Name = "tbdetalle";
            this.tbdetalle.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbdetalle.Size = new System.Drawing.Size(128, 24);
            this.tbdetalle.TabIndex = 103;
            this.tbdetalle.Text = "RD$0.00";
            this.tbdetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(135, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 109;
            this.label2.Text = "Código";
            // 
            // tbnombre
            // 
            this.tbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbnombre.Location = new System.Drawing.Point(213, 69);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(321, 23);
            this.tbnombre.TabIndex = 102;
            this.tbnombre.TextChanged += new System.EventHandler(this.tbnombre_TextChanged);
            this.tbnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbnombre_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 108;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 30.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(98, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 48);
            this.label3.TabIndex = 107;
            this.label3.Text = "Cuenta por Cobrar";
            // 
            // btbuscar1
            // 
            this.btbuscar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar1.Image = global::CGSystem.Properties.Resources.lupa_psd_468x468;
            this.btbuscar1.Location = new System.Drawing.Point(540, 51);
            this.btbuscar1.Name = "btbuscar1";
            this.btbuscar1.Size = new System.Drawing.Size(63, 57);
            this.btbuscar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btbuscar1.TabIndex = 111;
            this.btbuscar1.TabStop = false;
            this.btbuscar1.Click += new System.EventHandler(this.btbuscar1_Click);
            // 
            // id
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle17;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // fact
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fact.DefaultCellStyle = dataGridViewCellStyle18;
            this.fact.HeaderText = "Factura #";
            this.fact.Name = "fact";
            this.fact.ReadOnly = true;
            this.fact.Width = 194;
            // 
            // total
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.total.DefaultCellStyle = dataGridViewCellStyle19;
            this.total.HeaderText = "Valor Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 200;
            // 
            // restante
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.restante.DefaultCellStyle = dataGridViewCellStyle20;
            this.restante.HeaderText = "Valor Restante";
            this.restante.Name = "restante";
            this.restante.ReadOnly = true;
            this.restante.Width = 200;
            // 
            // CXC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 410);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.dgvCuentasPorCobrar);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btcnew);
            this.Controls.Add(this.btimprimir);
            this.Controls.Add(this.btcsave);
            this.Controls.Add(this.tbdetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btbuscar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(697, 449);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(697, 449);
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
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.DataGridView dgvCuentasPorCobrar;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btcnew;
        private System.Windows.Forms.Button btimprimir;
        private System.Windows.Forms.Button btcsave;
        private System.Windows.Forms.TextBox tbdetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btbuscar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn restante;
    }
}