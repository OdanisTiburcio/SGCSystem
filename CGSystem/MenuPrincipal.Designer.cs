﻿namespace CGSystem
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmcheckin = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadreCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeMedidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVencidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnfacturar = new System.Windows.Forms.Button();
            this.btncheckin = new System.Windows.Forms.Button();
            this.btnlistaclientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.contabilidadToolStripMenuItem,
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmcheckin,
            this.facturarToolStripMenuItem1,
            this.listaDeClientesToolStripMenuItem,
            this.listaDeEmpleadosToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasToolStripMenuItem.Image")));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.consultasToolStripMenuItem.Text = "Operaciones";
            // 
            // tsmcheckin
            // 
            this.tsmcheckin.Image = ((System.Drawing.Image)(resources.GetObject("tsmcheckin.Image")));
            this.tsmcheckin.Name = "tsmcheckin";
            this.tsmcheckin.Size = new System.Drawing.Size(175, 22);
            this.tsmcheckin.Text = "Check-In";
            this.tsmcheckin.Click += new System.EventHandler(this.tsmcheckin_Click);
            // 
            // facturarToolStripMenuItem1
            // 
            this.facturarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("facturarToolStripMenuItem1.Image")));
            this.facturarToolStripMenuItem1.Name = "facturarToolStripMenuItem1";
            this.facturarToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.facturarToolStripMenuItem1.Text = "Facturar";
            this.facturarToolStripMenuItem1.Click += new System.EventHandler(this.btnfacturar_Click);
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDeClientesToolStripMenuItem.Image")));
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            this.listaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.btnlistaclientes_Click);
            // 
            // listaDeEmpleadosToolStripMenuItem
            // 
            this.listaDeEmpleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDeEmpleadosToolStripMenuItem.Image")));
            this.listaDeEmpleadosToolStripMenuItem.Name = "listaDeEmpleadosToolStripMenuItem";
            this.listaDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.listaDeEmpleadosToolStripMenuItem.Text = "Lista de Empleados";
            this.listaDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listaDeEmpleadosToolStripMenuItem_Click);
            // 
            // contabilidadToolStripMenuItem
            // 
            this.contabilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.cuadreCajaToolStripMenuItem,
            this.cuentasPorCobrarToolStripMenuItem});
            this.contabilidadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contabilidadToolStripMenuItem.Image")));
            this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.contabilidadToolStripMenuItem.Text = "Contabilidad";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ingresosToolStripMenuItem.Image")));
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // cuadreCajaToolStripMenuItem
            // 
            this.cuadreCajaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cuadreCajaToolStripMenuItem.Image")));
            this.cuadreCajaToolStripMenuItem.Name = "cuadreCajaToolStripMenuItem";
            this.cuadreCajaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cuadreCajaToolStripMenuItem.Text = "Cuadre Caja";
            this.cuadreCajaToolStripMenuItem.Click += new System.EventHandler(this.cuadreCajaToolStripMenuItem_Click);
            // 
            // cuentasPorCobrarToolStripMenuItem
            // 
            this.cuentasPorCobrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cuentasPorCobrarToolStripMenuItem.Image")));
            this.cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
            this.cuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cuentasPorCobrarToolStripMenuItem.Text = "Cuentas por Cobrar";
            this.cuentasPorCobrarToolStripMenuItem.Click += new System.EventHandler(this.cuentasPorCobrarToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.ciudadesToolStripMenuItem,
            this.sectoresToolStripMenuItem,
            this.posicionesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.reporteVencidosToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.archivoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeMedidasToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // controlDeMedidasToolStripMenuItem
            // 
            this.controlDeMedidasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controlDeMedidasToolStripMenuItem.Image")));
            this.controlDeMedidasToolStripMenuItem.Name = "controlDeMedidasToolStripMenuItem";
            this.controlDeMedidasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.controlDeMedidasToolStripMenuItem.Text = "Control de Medidas";
            this.controlDeMedidasToolStripMenuItem.Click += new System.EventHandler(this.controlDeMedidasToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem.Image")));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviciosToolStripMenuItem.Image")));
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("departamentosToolStripMenuItem.Image")));
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // ciudadesToolStripMenuItem
            // 
            this.ciudadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ciudadesToolStripMenuItem.Image")));
            this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            this.ciudadesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ciudadesToolStripMenuItem.Text = "Ciudades";
            this.ciudadesToolStripMenuItem.Click += new System.EventHandler(this.ciudadesToolStripMenuItem_Click);
            // 
            // sectoresToolStripMenuItem
            // 
            this.sectoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sectoresToolStripMenuItem.Image")));
            this.sectoresToolStripMenuItem.Name = "sectoresToolStripMenuItem";
            this.sectoresToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sectoresToolStripMenuItem.Text = "Sectores";
            this.sectoresToolStripMenuItem.Click += new System.EventHandler(this.sectoresToolStripMenuItem_Click);
            // 
            // posicionesToolStripMenuItem
            // 
            this.posicionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("posicionesToolStripMenuItem.Image")));
            this.posicionesToolStripMenuItem.Name = "posicionesToolStripMenuItem";
            this.posicionesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.posicionesToolStripMenuItem.Text = "Posiciones";
            this.posicionesToolStripMenuItem.Click += new System.EventHandler(this.posicionesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::CGSystem.Properties.Resources.login;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // reporteVencidosToolStripMenuItem
            // 
            this.reporteVencidosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteVencidosToolStripMenuItem.Image")));
            this.reporteVencidosToolStripMenuItem.Name = "reporteVencidosToolStripMenuItem";
            this.reporteVencidosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.reporteVencidosToolStripMenuItem.Text = "Reporte Vencidos";
            this.reporteVencidosToolStripMenuItem.Click += new System.EventHandler(this.reporteVencidosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activarProductoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // activarProductoToolStripMenuItem
            // 
            this.activarProductoToolStripMenuItem.Image = global::CGSystem.Properties.Resources.Primary_icon;
            this.activarProductoToolStripMenuItem.Name = "activarProductoToolStripMenuItem";
            this.activarProductoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.activarProductoToolStripMenuItem.Text = "Activar Producto";
            this.activarProductoToolStripMenuItem.Click += new System.EventHandler(this.activarProductoToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = global::CGSystem.Properties.Resources.LogOut;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnfacturar
            // 
            this.btnfacturar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnfacturar.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnfacturar.ForeColor = System.Drawing.Color.Black;
            this.btnfacturar.Location = new System.Drawing.Point(10, 161);
            this.btnfacturar.Name = "btnfacturar";
            this.btnfacturar.Size = new System.Drawing.Size(222, 88);
            this.btnfacturar.TabIndex = 1;
            this.btnfacturar.Text = "Facturar";
            this.btnfacturar.UseVisualStyleBackColor = false;
            this.btnfacturar.Click += new System.EventHandler(this.btnfacturar_Click);
            // 
            // btncheckin
            // 
            this.btncheckin.BackColor = System.Drawing.Color.Khaki;
            this.btncheckin.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btncheckin.ForeColor = System.Drawing.Color.Black;
            this.btncheckin.Location = new System.Drawing.Point(10, 65);
            this.btncheckin.Name = "btncheckin";
            this.btncheckin.Size = new System.Drawing.Size(222, 89);
            this.btncheckin.TabIndex = 0;
            this.btncheckin.Text = "Check-in";
            this.btncheckin.UseVisualStyleBackColor = false;
            this.btncheckin.Click += new System.EventHandler(this.btncheckin_Click);
            // 
            // btnlistaclientes
            // 
            this.btnlistaclientes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnlistaclientes.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistaclientes.Location = new System.Drawing.Point(10, 255);
            this.btnlistaclientes.Name = "btnlistaclientes";
            this.btnlistaclientes.Size = new System.Drawing.Size(222, 88);
            this.btnlistaclientes.TabIndex = 2;
            this.btnlistaclientes.Text = "Clientes";
            this.btnlistaclientes.UseVisualStyleBackColor = false;
            this.btnlistaclientes.Click += new System.EventHandler(this.btnlistaclientes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(10, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 89);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vencidos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(898, 531);
            this.Controls.Add(this.btnlistaclientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncheckin);
            this.Controls.Add(this.btnfacturar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(914, 569);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Button btnfacturar;
        private System.Windows.Forms.Button btncheckin;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmcheckin;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadreCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnlistaclientes;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posicionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVencidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeMedidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activarProductoToolStripMenuItem;
    }
}