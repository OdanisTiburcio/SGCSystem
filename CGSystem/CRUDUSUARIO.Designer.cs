namespace CGSystem
{
    partial class CRUDUSUARIO
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
            this.lbidcliente = new System.Windows.Forms.Label();
            this.tbaliasusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcontrasenausuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtipocuentausuario = new System.Windows.Forms.ComboBox();
            this.cbnumeroempleado = new System.Windows.Forms.ComboBox();
            this.btnguardarusuario = new System.Windows.Forms.Button();
            this.btnactualizarusuario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbestadousuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbidcliente
            // 
            this.lbidcliente.AutoSize = true;
            this.lbidcliente.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidcliente.Location = new System.Drawing.Point(94, 72);
            this.lbidcliente.Name = "lbidcliente";
            this.lbidcliente.Size = new System.Drawing.Size(52, 23);
            this.lbidcliente.TabIndex = 138;
            this.lbidcliente.Text = "Alias";
            // 
            // tbaliasusuario
            // 
            this.tbaliasusuario.Enabled = false;
            this.tbaliasusuario.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaliasusuario.Location = new System.Drawing.Point(147, 74);
            this.tbaliasusuario.Name = "tbaliasusuario";
            this.tbaliasusuario.Size = new System.Drawing.Size(133, 22);
            this.tbaliasusuario.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 136;
            this.label2.Text = "Id Empleado";
            // 
            // tbcontrasenausuario
            // 
            this.tbcontrasenausuario.Enabled = false;
            this.tbcontrasenausuario.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontrasenausuario.Location = new System.Drawing.Point(147, 103);
            this.tbcontrasenausuario.Name = "tbcontrasenausuario";
            this.tbcontrasenausuario.PasswordChar = '*';
            this.tbcontrasenausuario.Size = new System.Drawing.Size(133, 22);
            this.tbcontrasenausuario.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 138;
            this.label1.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 140;
            this.label3.Text = "Tipo de Usuario";
            // 
            // cbtipocuentausuario
            // 
            this.cbtipocuentausuario.Enabled = false;
            this.cbtipocuentausuario.FormattingEnabled = true;
            this.cbtipocuentausuario.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cbtipocuentausuario.Location = new System.Drawing.Point(147, 45);
            this.cbtipocuentausuario.Name = "cbtipocuentausuario";
            this.cbtipocuentausuario.Size = new System.Drawing.Size(133, 21);
            this.cbtipocuentausuario.TabIndex = 141;
            // 
            // cbnumeroempleado
            // 
            this.cbnumeroempleado.Enabled = false;
            this.cbnumeroempleado.FormattingEnabled = true;
            this.cbnumeroempleado.Location = new System.Drawing.Point(147, 15);
            this.cbnumeroempleado.Name = "cbnumeroempleado";
            this.cbnumeroempleado.Size = new System.Drawing.Size(51, 21);
            this.cbnumeroempleado.TabIndex = 142;
            // 
            // btnguardarusuario
            // 
            this.btnguardarusuario.BackColor = System.Drawing.Color.Cornsilk;
            this.btnguardarusuario.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarusuario.Location = new System.Drawing.Point(7, 164);
            this.btnguardarusuario.Name = "btnguardarusuario";
            this.btnguardarusuario.Size = new System.Drawing.Size(133, 44);
            this.btnguardarusuario.TabIndex = 145;
            this.btnguardarusuario.Text = "Guardar";
            this.btnguardarusuario.UseVisualStyleBackColor = false;
            this.btnguardarusuario.Click += new System.EventHandler(this.btnguardarusuario_Click);
            // 
            // btnactualizarusuario
            // 
            this.btnactualizarusuario.BackColor = System.Drawing.Color.Cornsilk;
            this.btnactualizarusuario.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarusuario.Location = new System.Drawing.Point(147, 164);
            this.btnactualizarusuario.Name = "btnactualizarusuario";
            this.btnactualizarusuario.Size = new System.Drawing.Size(133, 44);
            this.btnactualizarusuario.TabIndex = 147;
            this.btnactualizarusuario.Text = "Actualizar";
            this.btnactualizarusuario.UseVisualStyleBackColor = false;
            this.btnactualizarusuario.Click += new System.EventHandler(this.btnactualizarusuario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 138;
            this.label4.Text = "Estado";
            // 
            // cbestadousuario
            // 
            this.cbestadousuario.Enabled = false;
            this.cbestadousuario.FormattingEnabled = true;
            this.cbestadousuario.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbestadousuario.Location = new System.Drawing.Point(147, 133);
            this.cbestadousuario.Name = "cbestadousuario";
            this.cbestadousuario.Size = new System.Drawing.Size(133, 21);
            this.cbestadousuario.TabIndex = 141;
            // 
            // CRUDUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 216);
            this.Controls.Add(this.btnactualizarusuario);
            this.Controls.Add(this.btnguardarusuario);
            this.Controls.Add(this.cbnumeroempleado);
            this.Controls.Add(this.cbestadousuario);
            this.Controls.Add(this.cbtipocuentausuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcontrasenausuario);
            this.Controls.Add(this.lbidcliente);
            this.Controls.Add(this.tbaliasusuario);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CRUDUSUARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de Usuarios";
            this.Load += new System.EventHandler(this.CRUDUSUARIO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbidcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnguardarusuario;
        public System.Windows.Forms.Button btnactualizarusuario;
        public System.Windows.Forms.ComboBox cbnumeroempleado;
        public System.Windows.Forms.TextBox tbaliasusuario;
        public System.Windows.Forms.TextBox tbcontrasenausuario;
        public System.Windows.Forms.ComboBox cbtipocuentausuario;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbestadousuario;
    }
}