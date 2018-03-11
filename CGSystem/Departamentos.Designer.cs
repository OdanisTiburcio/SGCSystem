namespace CGSystem
{
    partial class Departamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departamentos));
            this.btnnuevodepartamento = new System.Windows.Forms.Button();
            this.btneliminardepartamento = new System.Windows.Forms.Button();
            this.btneditardepartamento = new System.Windows.Forms.Button();
            this.btnguardardepartamento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripDepartamento = new System.Windows.Forms.TextBox();
            this.tbCodigoDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnnuevodepartamento
            // 
            this.btnnuevodepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevodepartamento.Location = new System.Drawing.Point(236, 73);
            this.btnnuevodepartamento.Name = "btnnuevodepartamento";
            this.btnnuevodepartamento.Size = new System.Drawing.Size(93, 41);
            this.btnnuevodepartamento.TabIndex = 11;
            this.btnnuevodepartamento.Text = "Nuevo (+)";
            this.btnnuevodepartamento.UseVisualStyleBackColor = true;
            this.btnnuevodepartamento.Click += new System.EventHandler(this.button2_Click);
            // 
            // btneliminardepartamento
            // 
            this.btneliminardepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminardepartamento.Location = new System.Drawing.Point(335, 73);
            this.btneliminardepartamento.Name = "btneliminardepartamento";
            this.btneliminardepartamento.Size = new System.Drawing.Size(93, 41);
            this.btneliminardepartamento.TabIndex = 10;
            this.btneliminardepartamento.Text = "Eliminar";
            this.btneliminardepartamento.UseVisualStyleBackColor = true;
            this.btneliminardepartamento.Click += new System.EventHandler(this.btneliminardepartamento_Click);
            // 
            // btneditardepartamento
            // 
            this.btneditardepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditardepartamento.Location = new System.Drawing.Point(137, 73);
            this.btneditardepartamento.Name = "btneditardepartamento";
            this.btneditardepartamento.Size = new System.Drawing.Size(93, 41);
            this.btneditardepartamento.TabIndex = 9;
            this.btneditardepartamento.Text = "Editar";
            this.btneditardepartamento.UseVisualStyleBackColor = true;
            this.btneditardepartamento.Click += new System.EventHandler(this.btGuardarDepartamento_Click_1);
            // 
            // btnguardardepartamento
            // 
            this.btnguardardepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardardepartamento.Location = new System.Drawing.Point(38, 73);
            this.btnguardardepartamento.Name = "btnguardardepartamento";
            this.btnguardardepartamento.Size = new System.Drawing.Size(93, 41);
            this.btnguardardepartamento.TabIndex = 8;
            this.btnguardardepartamento.Text = "Guardar";
            this.btnguardardepartamento.UseVisualStyleBackColor = true;
            this.btnguardardepartamento.Click += new System.EventHandler(this.btNuevoDepartamento_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descripción Departamento:";
            // 
            // tbDescripDepartamento
            // 
            this.tbDescripDepartamento.Location = new System.Drawing.Point(200, 43);
            this.tbDescripDepartamento.Name = "tbDescripDepartamento";
            this.tbDescripDepartamento.Size = new System.Drawing.Size(250, 20);
            this.tbDescripDepartamento.TabIndex = 14;
            // 
            // tbCodigoDepartamento
            // 
            this.tbCodigoDepartamento.Enabled = false;
            this.tbCodigoDepartamento.Location = new System.Drawing.Point(200, 9);
            this.tbCodigoDepartamento.Name = "tbCodigoDepartamento";
            this.tbCodigoDepartamento.Size = new System.Drawing.Size(54, 20);
            this.tbCodigoDepartamento.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código Departamento:";
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 122);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescripDepartamento);
            this.Controls.Add(this.tbCodigoDepartamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnuevodepartamento);
            this.Controls.Add(this.btneliminardepartamento);
            this.Controls.Add(this.btneditardepartamento);
            this.Controls.Add(this.btnguardardepartamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Departamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.Departamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnuevodepartamento;
        private System.Windows.Forms.Button btneliminardepartamento;
        private System.Windows.Forms.Button btneditardepartamento;
        private System.Windows.Forms.Button btnguardardepartamento;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbDescripDepartamento;
        public System.Windows.Forms.TextBox tbCodigoDepartamento;
        private System.Windows.Forms.Label label1;
    }
}