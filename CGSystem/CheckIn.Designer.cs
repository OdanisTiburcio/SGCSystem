﻿namespace CGSystem
{
    partial class CheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.label7 = new System.Windows.Forms.Label();
            this.tbcedula = new System.Windows.Forms.TextBox();
            this.ptbfotoempleado = new System.Windows.Forms.PictureBox();
            this.rdbinactivo = new System.Windows.Forms.RadioButton();
            this.rdbactivo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbapellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.Restante = new System.Windows.Forms.Label();
            this.tbrestante = new System.Windows.Forms.TextBox();
            this.txtfechapago = new System.Windows.Forms.TextBox();
            this.lblfechapago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfotoempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Cédula";
            // 
            // tbcedula
            // 
            this.tbcedula.Location = new System.Drawing.Point(64, 90);
            this.tbcedula.Name = "tbcedula";
            this.tbcedula.ReadOnly = true;
            this.tbcedula.Size = new System.Drawing.Size(115, 20);
            this.tbcedula.TabIndex = 23;
            // 
            // ptbfotoempleado
            // 
            this.ptbfotoempleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbfotoempleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbfotoempleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbfotoempleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbfotoempleado.Image = ((System.Drawing.Image)(resources.GetObject("ptbfotoempleado.Image")));
            this.ptbfotoempleado.Location = new System.Drawing.Point(261, 12);
            this.ptbfotoempleado.Name = "ptbfotoempleado";
            this.ptbfotoempleado.Size = new System.Drawing.Size(191, 177);
            this.ptbfotoempleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbfotoempleado.TabIndex = 42;
            this.ptbfotoempleado.TabStop = false;
            // 
            // rdbinactivo
            // 
            this.rdbinactivo.AutoCheck = false;
            this.rdbinactivo.AutoSize = true;
            this.rdbinactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbinactivo.Location = new System.Drawing.Point(164, 132);
            this.rdbinactivo.Name = "rdbinactivo";
            this.rdbinactivo.Size = new System.Drawing.Size(77, 21);
            this.rdbinactivo.TabIndex = 44;
            this.rdbinactivo.Text = "Vencido";
            this.rdbinactivo.UseVisualStyleBackColor = true;
            // 
            // rdbactivo
            // 
            this.rdbactivo.AutoCheck = false;
            this.rdbactivo.AutoSize = true;
            this.rdbactivo.Checked = true;
            this.rdbactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbactivo.Location = new System.Drawing.Point(47, 132);
            this.rdbactivo.Name = "rdbactivo";
            this.rdbactivo.Size = new System.Drawing.Size(74, 21);
            this.rdbactivo.TabIndex = 43;
            this.rdbactivo.TabStop = true;
            this.rdbactivo.Text = "Vigente";
            this.rdbactivo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Mistral", 26.25F);
            this.button1.Location = new System.Drawing.Point(234, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 59);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(61, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Estado del Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Apellidos";
            // 
            // tbapellidos
            // 
            this.tbapellidos.Location = new System.Drawing.Point(64, 64);
            this.tbapellidos.Name = "tbapellidos";
            this.tbapellidos.ReadOnly = true;
            this.tbapellidos.Size = new System.Drawing.Size(191, 20);
            this.tbapellidos.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(64, 12);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(61, 20);
            this.tbid.TabIndex = 22;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(64, 38);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.ReadOnly = true;
            this.tbnombre.Size = new System.Drawing.Size(191, 20);
            this.tbnombre.TabIndex = 20;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnguardar.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(11, 212);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(217, 59);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Buscar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Restante
            // 
            this.Restante.AutoSize = true;
            this.Restante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restante.Location = new System.Drawing.Point(15, 162);
            this.Restante.Name = "Restante";
            this.Restante.Size = new System.Drawing.Size(58, 13);
            this.Restante.TabIndex = 47;
            this.Restante.Text = "Restante";
            // 
            // tbrestante
            // 
            this.tbrestante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbrestante.Location = new System.Drawing.Point(77, 159);
            this.tbrestante.Name = "tbrestante";
            this.tbrestante.ReadOnly = true;
            this.tbrestante.Size = new System.Drawing.Size(151, 20);
            this.tbrestante.TabIndex = 46;
            // 
            // txtfechapago
            // 
            this.txtfechapago.BackColor = System.Drawing.Color.Snow;
            this.txtfechapago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfechapago.Location = new System.Drawing.Point(108, 184);
            this.txtfechapago.Name = "txtfechapago";
            this.txtfechapago.ReadOnly = true;
            this.txtfechapago.Size = new System.Drawing.Size(119, 20);
            this.txtfechapago.TabIndex = 46;
            // 
            // lblfechapago
            // 
            this.lblfechapago.AutoSize = true;
            this.lblfechapago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechapago.Location = new System.Drawing.Point(14, 187);
            this.lblfechapago.Name = "lblfechapago";
            this.lblfechapago.Size = new System.Drawing.Size(93, 13);
            this.lblfechapago.TabIndex = 47;
            this.lblfechapago.Text = "Fecha de Pago";
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 283);
            this.Controls.Add(this.lblfechapago);
            this.Controls.Add(this.txtfechapago);
            this.Controls.Add(this.Restante);
            this.Controls.Add(this.tbrestante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbcedula);
            this.Controls.Add(this.ptbfotoempleado);
            this.Controls.Add(this.rdbinactivo);
            this.Controls.Add(this.rdbactivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbapellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.btnguardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check - In";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbfotoempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbcedula;
        private System.Windows.Forms.PictureBox ptbfotoempleado;
        private System.Windows.Forms.RadioButton rdbinactivo;
        private System.Windows.Forms.RadioButton rdbactivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbapellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label Restante;
        private System.Windows.Forms.TextBox tbrestante;
        private System.Windows.Forms.TextBox txtfechapago;
        private System.Windows.Forms.Label lblfechapago;
    }
}