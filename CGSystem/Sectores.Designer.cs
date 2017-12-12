namespace CGSystem
{
    partial class Sectores
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbdescripsector = new System.Windows.Forms.TextBox();
            this.tbcodigosector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardarsector = new System.Windows.Forms.Button();
            this.btnactualizarsector = new System.Windows.Forms.Button();
            this.btneliminarsector = new System.Windows.Forms.Button();
            this.btnimprimirsector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descripción Sector:";
            // 
            // tbdescripsector
            // 
            this.tbdescripsector.Location = new System.Drawing.Point(167, 40);
            this.tbdescripsector.Name = "tbdescripsector";
            this.tbdescripsector.Size = new System.Drawing.Size(244, 20);
            this.tbdescripsector.TabIndex = 30;
            // 
            // tbcodigosector
            // 
            this.tbcodigosector.Location = new System.Drawing.Point(165, 6);
            this.tbcodigosector.Name = "tbcodigosector";
            this.tbcodigosector.Size = new System.Drawing.Size(83, 20);
            this.tbcodigosector.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código Sector:";
            // 
            // btnguardarsector
            // 
            this.btnguardarsector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarsector.Location = new System.Drawing.Point(26, 75);
            this.btnguardarsector.Name = "btnguardarsector";
            this.btnguardarsector.Size = new System.Drawing.Size(94, 51);
            this.btnguardarsector.TabIndex = 32;
            this.btnguardarsector.Text = "Guardar";
            this.btnguardarsector.UseVisualStyleBackColor = true;
            this.btnguardarsector.Click += new System.EventHandler(this.btnguardarsector_Click);
            // 
            // btnactualizarsector
            // 
            this.btnactualizarsector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarsector.Location = new System.Drawing.Point(123, 75);
            this.btnactualizarsector.Name = "btnactualizarsector";
            this.btnactualizarsector.Size = new System.Drawing.Size(94, 51);
            this.btnactualizarsector.TabIndex = 32;
            this.btnactualizarsector.Text = "Actualizar";
            this.btnactualizarsector.UseVisualStyleBackColor = true;
            this.btnactualizarsector.Click += new System.EventHandler(this.btnactualizarsector_Click);
            // 
            // btneliminarsector
            // 
            this.btneliminarsector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarsector.Location = new System.Drawing.Point(220, 75);
            this.btneliminarsector.Name = "btneliminarsector";
            this.btneliminarsector.Size = new System.Drawing.Size(94, 51);
            this.btneliminarsector.TabIndex = 32;
            this.btneliminarsector.Text = "Eliminar";
            this.btneliminarsector.UseVisualStyleBackColor = true;
            this.btneliminarsector.Click += new System.EventHandler(this.btneliminarsector_Click);
            // 
            // btnimprimirsector
            // 
            this.btnimprimirsector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimirsector.Location = new System.Drawing.Point(317, 75);
            this.btnimprimirsector.Name = "btnimprimirsector";
            this.btnimprimirsector.Size = new System.Drawing.Size(94, 51);
            this.btnimprimirsector.TabIndex = 32;
            this.btnimprimirsector.Text = "Imprimir";
            this.btnimprimirsector.UseVisualStyleBackColor = true;
            // 
            // Sectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 134);
            this.Controls.Add(this.btnimprimirsector);
            this.Controls.Add(this.btneliminarsector);
            this.Controls.Add(this.btnactualizarsector);
            this.Controls.Add(this.btnguardarsector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbdescripsector);
            this.Controls.Add(this.tbcodigosector);
            this.Controls.Add(this.label1);
            this.Name = "Sectores";
            this.Text = "Sectores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbdescripsector;
        public System.Windows.Forms.TextBox tbcodigosector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardarsector;
        private System.Windows.Forms.Button btnactualizarsector;
        private System.Windows.Forms.Button btneliminarsector;
        private System.Windows.Forms.Button btnimprimirsector;
    }
}