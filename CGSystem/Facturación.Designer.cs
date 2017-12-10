namespace CGSystem
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
            this.btneliminiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkbcredito = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkbcontado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcliente = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.PictureBox();
            this.lbidcliente = new System.Windows.Forms.Label();
            this.tbidcliente = new System.Windows.Forms.TextBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.lbfecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbnumfactura = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.tbproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1detalle = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btbuscar = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1detalle)).BeginInit();
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
            this.btneliminiar.Text = "ELIMINAR PRODUCTO";
            this.btneliminiar.UseVisualStyleBackColor = true;
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
            // 
            // chkbcredito
            // 
            this.chkbcredito.AutoSize = true;
            this.chkbcredito.Location = new System.Drawing.Point(674, 62);
            this.chkbcredito.Name = "chkbcredito";
            this.chkbcredito.Size = new System.Drawing.Size(15, 14);
            this.chkbcredito.TabIndex = 123;
            this.chkbcredito.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(604, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 141;
            this.label6.Text = "Crédito";
            // 
            // chkbcontado
            // 
            this.chkbcontado.AutoSize = true;
            this.chkbcontado.Checked = true;
            this.chkbcontado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbcontado.Location = new System.Drawing.Point(567, 62);
            this.chkbcontado.Name = "chkbcontado";
            this.chkbcontado.Size = new System.Drawing.Size(15, 14);
            this.chkbcontado.TabIndex = 122;
            this.chkbcontado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 140;
            this.label5.Text = "Contado";
            // 
            // tbtotal
            // 
            this.tbtotal.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.ForeColor = System.Drawing.Color.Blue;
            this.tbtotal.Location = new System.Drawing.Point(567, 384);
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
            this.label4.Location = new System.Drawing.Point(501, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 138;
            this.label4.Text = "Total";
            // 
            // tbcliente
            // 
            this.tbcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcliente.Location = new System.Drawing.Point(547, 96);
            this.tbcliente.Name = "tbcliente";
            this.tbcliente.Size = new System.Drawing.Size(167, 22);
            this.tbcliente.TabIndex = 135;
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Image = global::CGSystem.Properties.Resources.lupa_psd_468x468;
            this.btnsearch.Location = new System.Drawing.Point(717, 88);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(43, 38);
            this.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsearch.TabIndex = 136;
            this.btnsearch.TabStop = false;
            this.btnsearch.Visible = false;
            // 
            // lbidcliente
            // 
            this.lbidcliente.AutoSize = true;
            this.lbidcliente.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidcliente.Location = new System.Drawing.Point(517, 123);
            this.lbidcliente.Name = "lbidcliente";
            this.lbidcliente.Size = new System.Drawing.Size(27, 23);
            this.lbidcliente.TabIndex = 134;
            this.lbidcliente.Text = "Id";
            this.lbidcliente.Visible = false;
            // 
            // tbidcliente
            // 
            this.tbidcliente.Enabled = false;
            this.tbidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbidcliente.Location = new System.Drawing.Point(547, 124);
            this.tbidcliente.Name = "tbidcliente";
            this.tbidcliente.Size = new System.Drawing.Size(83, 22);
            this.tbidcliente.TabIndex = 133;
            this.tbidcliente.Visible = false;
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
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Goudy Old Style", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbfecha.Location = new System.Drawing.Point(671, 0);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(96, 21);
            this.lbfecha.TabIndex = 130;
            this.lbfecha.Text = "00/00/0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 129;
            this.label2.Text = "Cliente";
            // 
            // lbnumfactura
            // 
            this.lbnumfactura.AutoSize = true;
            this.lbnumfactura.Font = new System.Drawing.Font("Goudy Old Style", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbnumfactura.Location = new System.Drawing.Point(584, 20);
            this.lbnumfactura.Name = "lbnumfactura";
            this.lbnumfactura.Size = new System.Drawing.Size(101, 21);
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
            // 
            // tbproducto
            // 
            this.tbproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbproducto.Location = new System.Drawing.Point(287, 22);
            this.tbproducto.Name = "tbproducto";
            this.tbproducto.Size = new System.Drawing.Size(187, 22);
            this.tbproducto.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 128;
            this.label1.Text = "Producto";
            // 
            // total
            // 
            this.total.Frozen = true;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.Frozen = true;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 70;
            // 
            // cantidad
            // 
            this.cantidad.Frozen = true;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MaxInputLength = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 60;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 180;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "Código";
            this.id.MaxInputLength = 25;
            this.id.MinimumWidth = 3;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 50;
            // 
            // dataGridView1detalle
            // 
            this.dataGridView1detalle.AllowUserToAddRows = false;
            this.dataGridView1detalle.AllowUserToDeleteRows = false;
            this.dataGridView1detalle.AllowUserToResizeColumns = false;
            this.dataGridView1detalle.AllowUserToResizeRows = false;
            this.dataGridView1detalle.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1detalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.cantidad,
            this.precio,
            this.total});
            this.dataGridView1detalle.Location = new System.Drawing.Point(7, 58);
            this.dataGridView1detalle.Name = "dataGridView1detalle";
            this.dataGridView1detalle.RowHeadersVisible = false;
            this.dataGridView1detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1detalle.Size = new System.Drawing.Size(461, 317);
            this.dataGridView1detalle.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(13, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 44);
            this.label11.TabIndex = 146;
            this.label11.Text = "Facturar";
            // 
            // btbuscar
            // 
            this.btbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar.Image = global::CGSystem.Properties.Resources.lupa_psd_468x468;
            this.btbuscar.Location = new System.Drawing.Point(470, 14);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(55, 36);
            this.btbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btbuscar.TabIndex = 126;
            this.btbuscar.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 18.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(521, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 41);
            this.button2.TabIndex = 147;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Facturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 464);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btneliminiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkbcredito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkbcontado);
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
            this.Controls.Add(this.dataGridView1detalle);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.label11);
            this.Name = "Facturación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkbcredito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkbcontado;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView dataGridView1detalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btbuscar;
        private System.Windows.Forms.Button button2;
    }
}