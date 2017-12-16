namespace CGSystem
{
    partial class CuadreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuadreCaja));
            this.dtvcuadrecaja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbventacredito = new System.Windows.Forms.TextBox();
            this.tbventacontado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncuadrehoy = new System.Windows.Forms.Button();
            this.btncuadremes = new System.Windows.Forms.Button();
            this.pbimprimircuadre = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmescuadre = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvcuadrecaja)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimprimircuadre)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvcuadrecaja
            // 
            this.dtvcuadrecaja.AllowUserToAddRows = false;
            this.dtvcuadrecaja.AllowUserToDeleteRows = false;
            this.dtvcuadrecaja.AllowUserToOrderColumns = true;
            this.dtvcuadrecaja.AllowUserToResizeColumns = false;
            this.dtvcuadrecaja.AllowUserToResizeRows = false;
            this.dtvcuadrecaja.BackgroundColor = System.Drawing.Color.White;
            this.dtvcuadrecaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvcuadrecaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cliente,
            this.tipo});
            this.dtvcuadrecaja.Location = new System.Drawing.Point(13, 13);
            this.dtvcuadrecaja.Name = "dtvcuadrecaja";
            this.dtvcuadrecaja.ReadOnly = true;
            this.dtvcuadrecaja.RowHeadersVisible = false;
            this.dtvcuadrecaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvcuadrecaja.Size = new System.Drawing.Size(314, 394);
            this.dtvcuadrecaja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crédito";
            // 
            // tbventacredito
            // 
            this.tbventacredito.BackColor = System.Drawing.Color.Cornsilk;
            this.tbventacredito.Enabled = false;
            this.tbventacredito.Location = new System.Drawing.Point(6, 47);
            this.tbventacredito.Name = "tbventacredito";
            this.tbventacredito.Size = new System.Drawing.Size(137, 25);
            this.tbventacredito.TabIndex = 2;
            this.tbventacredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbventacontado
            // 
            this.tbventacontado.BackColor = System.Drawing.Color.Cornsilk;
            this.tbventacontado.Enabled = false;
            this.tbventacontado.Location = new System.Drawing.Point(6, 101);
            this.tbventacontado.Name = "tbventacontado";
            this.tbventacontado.Size = new System.Drawing.Size(137, 25);
            this.tbventacontado.TabIndex = 2;
            this.tbventacontado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbventacontado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbventacredito);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(333, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // btncuadrehoy
            // 
            this.btncuadrehoy.BackColor = System.Drawing.Color.Cornsilk;
            this.btncuadrehoy.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuadrehoy.Location = new System.Drawing.Point(352, 13);
            this.btncuadrehoy.Name = "btncuadrehoy";
            this.btncuadrehoy.Size = new System.Drawing.Size(106, 47);
            this.btncuadrehoy.TabIndex = 4;
            this.btncuadrehoy.Text = "Hoy";
            this.btncuadrehoy.UseVisualStyleBackColor = false;
            this.btncuadrehoy.Click += new System.EventHandler(this.btncuadrehoy_Click);
            // 
            // btncuadremes
            // 
            this.btncuadremes.BackColor = System.Drawing.Color.Cornsilk;
            this.btncuadremes.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuadremes.Location = new System.Drawing.Point(352, 69);
            this.btncuadremes.Name = "btncuadremes";
            this.btncuadremes.Size = new System.Drawing.Size(106, 47);
            this.btncuadremes.TabIndex = 4;
            this.btncuadremes.Text = "Últ. mes";
            this.btncuadremes.UseVisualStyleBackColor = false;
            this.btncuadremes.Click += new System.EventHandler(this.btncuadremes_Click);
            // 
            // pbimprimircuadre
            // 
            this.pbimprimircuadre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbimprimircuadre.BackgroundImage")));
            this.pbimprimircuadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbimprimircuadre.InitialImage = null;
            this.pbimprimircuadre.Location = new System.Drawing.Point(352, 184);
            this.pbimprimircuadre.Name = "pbimprimircuadre";
            this.pbimprimircuadre.Size = new System.Drawing.Size(109, 81);
            this.pbimprimircuadre.TabIndex = 5;
            this.pbimprimircuadre.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Histórico:";
            // 
            // cbmescuadre
            // 
            this.cbmescuadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmescuadre.FormattingEnabled = true;
            this.cbmescuadre.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbmescuadre.Location = new System.Drawing.Point(352, 154);
            this.cbmescuadre.Name = "cbmescuadre";
            this.cbmescuadre.Size = new System.Drawing.Size(101, 21);
            this.cbmescuadre.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Tipo";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 130;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Total (RD$)";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 121;
            // 
            // CuadreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 415);
            this.Controls.Add(this.cbmescuadre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbimprimircuadre);
            this.Controls.Add(this.btncuadremes);
            this.Controls.Add(this.btncuadrehoy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtvcuadrecaja);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CuadreCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadre de Caja";
            this.Load += new System.EventHandler(this.CuadreCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvcuadrecaja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimprimircuadre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvcuadrecaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbventacredito;
        private System.Windows.Forms.TextBox tbventacontado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncuadrehoy;
        private System.Windows.Forms.Button btncuadremes;
        private System.Windows.Forms.PictureBox pbimprimircuadre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmescuadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
    }
}