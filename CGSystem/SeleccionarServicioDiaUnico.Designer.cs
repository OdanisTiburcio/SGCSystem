namespace CGSystem
{
    partial class SeleccionarServicioDiaUnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarServicioDiaUnico));
            this.dgvListaServicios = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldobruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaServicios
            // 
            this.dgvListaServicios.AllowUserToAddRows = false;
            this.dgvListaServicios.AllowUserToDeleteRows = false;
            this.dgvListaServicios.AllowUserToResizeColumns = false;
            this.dgvListaServicios.AllowUserToResizeRows = false;
            this.dgvListaServicios.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvListaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.Nombre,
            this.sueldobruto,
            this.cargo});
            this.dgvListaServicios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvListaServicios.Location = new System.Drawing.Point(12, 12);
            this.dgvListaServicios.MultiSelect = false;
            this.dgvListaServicios.Name = "dgvListaServicios";
            this.dgvListaServicios.ReadOnly = true;
            this.dgvListaServicios.RowHeadersVisible = false;
            this.dgvListaServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaServicios.Size = new System.Drawing.Size(683, 274);
            this.dgvListaServicios.TabIndex = 3;
            this.dgvListaServicios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaServicios_CellDoubleClick);
            this.dgvListaServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvListaServicios_KeyPress);
            this.dgvListaServicios.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvListaServicios_KeyUp);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Código";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 85;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Descripción";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 350;
            // 
            // sueldobruto
            // 
            this.sueldobruto.HeaderText = "Precio";
            this.sueldobruto.Name = "sueldobruto";
            this.sueldobruto.ReadOnly = true;
            this.sueldobruto.Width = 150;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Días (+)";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 95;
            // 
            // SeleccionarServicioDiaUnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 297);
            this.Controls.Add(this.dgvListaServicios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(724, 326);
            this.Name = "SeleccionarServicioDiaUnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Servicio";
            this.Load += new System.EventHandler(this.SeleccionarServicioDiaUnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldobruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
    }
}