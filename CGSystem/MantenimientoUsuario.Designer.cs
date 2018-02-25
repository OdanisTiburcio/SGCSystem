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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncrearusuario = new System.Windows.Forms.Button();
            this.btnbuscarusuario = new System.Windows.Forms.Button();
            this.rdbusuarios = new System.Windows.Forms.RadioButton();
            this.rdbaliasusuario = new System.Windows.Forms.RadioButton();
            this.rdbtipousuario = new System.Windows.Forms.RadioButton();
            this.rdbnumeroempleado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbbuscarusuarios = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(487, 140);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btncrearusuario
            // 
            this.btncrearusuario.BackColor = System.Drawing.Color.Cornsilk;
            this.btncrearusuario.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearusuario.Location = new System.Drawing.Point(366, 151);
            this.btncrearusuario.Name = "btncrearusuario";
            this.btncrearusuario.Size = new System.Drawing.Size(85, 47);
            this.btncrearusuario.TabIndex = 145;
            this.btncrearusuario.Text = "Crear";
            this.btncrearusuario.UseVisualStyleBackColor = false;
            this.btncrearusuario.Click += new System.EventHandler(this.btncrearingreso_Click);
            // 
            // btnbuscarusuario
            // 
            this.btnbuscarusuario.BackColor = System.Drawing.Color.Cornsilk;
            this.btnbuscarusuario.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarusuario.Location = new System.Drawing.Point(276, 151);
            this.btnbuscarusuario.Name = "btnbuscarusuario";
            this.btnbuscarusuario.Size = new System.Drawing.Size(85, 47);
            this.btnbuscarusuario.TabIndex = 146;
            this.btnbuscarusuario.Text = "Buscar";
            this.btnbuscarusuario.UseVisualStyleBackColor = false;
            this.btnbuscarusuario.Click += new System.EventHandler(this.btnbuscarusuario_Click);
            // 
            // rdbusuarios
            // 
            this.rdbusuarios.AutoSize = true;
            this.rdbusuarios.Checked = true;
            this.rdbusuarios.Location = new System.Drawing.Point(129, 154);
            this.rdbusuarios.Name = "rdbusuarios";
            this.rdbusuarios.Size = new System.Drawing.Size(64, 17);
            this.rdbusuarios.TabIndex = 147;
            this.rdbusuarios.TabStop = true;
            this.rdbusuarios.Text = "Todos...";
            this.rdbusuarios.UseVisualStyleBackColor = true;
            // 
            // rdbaliasusuario
            // 
            this.rdbaliasusuario.AutoSize = true;
            this.rdbaliasusuario.Location = new System.Drawing.Point(42, 181);
            this.rdbaliasusuario.Name = "rdbaliasusuario";
            this.rdbaliasusuario.Size = new System.Drawing.Size(47, 17);
            this.rdbaliasusuario.TabIndex = 148;
            this.rdbaliasusuario.Text = "Alias";
            this.rdbaliasusuario.UseVisualStyleBackColor = true;
            // 
            // rdbtipousuario
            // 
            this.rdbtipousuario.AutoSize = true;
            this.rdbtipousuario.Location = new System.Drawing.Point(95, 181);
            this.rdbtipousuario.Name = "rdbtipousuario";
            this.rdbtipousuario.Size = new System.Drawing.Size(46, 17);
            this.rdbtipousuario.TabIndex = 149;
            this.rdbtipousuario.Text = "Tipo";
            this.rdbtipousuario.UseVisualStyleBackColor = true;
            // 
            // rdbnumeroempleado
            // 
            this.rdbnumeroempleado.AutoSize = true;
            this.rdbnumeroempleado.Location = new System.Drawing.Point(193, 154);
            this.rdbnumeroempleado.Name = "rdbnumeroempleado";
            this.rdbnumeroempleado.Size = new System.Drawing.Size(84, 17);
            this.rdbnumeroempleado.TabIndex = 150;
            this.rdbnumeroempleado.Text = "Id Empleado";
            this.rdbnumeroempleado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 151;
            this.label1.Text = "Buscar Por";
            // 
            // tbbuscarusuarios
            // 
            this.tbbuscarusuarios.Location = new System.Drawing.Point(141, 178);
            this.tbbuscarusuarios.Name = "tbbuscarusuarios";
            this.tbbuscarusuarios.Size = new System.Drawing.Size(129, 20);
            this.tbbuscarusuarios.TabIndex = 152;
            // 
            // MantenimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 204);
            this.Controls.Add(this.tbbuscarusuarios);
            this.Controls.Add(this.rdbusuarios);
            this.Controls.Add(this.rdbaliasusuario);
            this.Controls.Add(this.rdbtipousuario);
            this.Controls.Add(this.rdbnumeroempleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscarusuario);
            this.Controls.Add(this.btncrearusuario);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.MantenimientoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btncrearusuario;
        public System.Windows.Forms.Button btnbuscarusuario;
        private System.Windows.Forms.RadioButton rdbusuarios;
        private System.Windows.Forms.RadioButton rdbaliasusuario;
        private System.Windows.Forms.RadioButton rdbtipousuario;
        private System.Windows.Forms.RadioButton rdbnumeroempleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbbuscarusuarios;
    }
}