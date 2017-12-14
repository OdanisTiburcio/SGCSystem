﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Xml;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class MenuPrincipal : Form
    {
        //Variables Estáticas para el usuario logeado
        public static int UsuarioID = 0;
        public static string NombreUsuario = "Adanis Tiburcio";
        public static bool Logeado = false; //Para confirmar que la sesión esté iniciada
        public static bool SalirDelSistema = false;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            try
            {
                if (Logeado == false)
                {
                    Form F = new frmLogin();
                    F.ShowDialog();
                }
                else { }
            }
            catch
            {
            }
        }

        private void btnfacturar_Click(object sender, EventArgs e)
        {
            Facturación f = new Facturación();
            f.ShowDialog();
        }

        private void btncheckin_Click(object sender, EventArgs e)
        {
            CheckIn f = new CheckIn();
            f.ShowDialog();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnlistaclientes_Click(object sender, EventArgs e)
        {
            ListaDeClientes f = new ListaDeClientes();
            f.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Actualizar();
                if (SalirDelSistema) {
                    this.Close();
                } else
                {

                }
            }
            catch
            {
            }

            //try
            //{
                //DateTime fechahoy = DateTime.Today;
                operacion oper = new operacion();
                DataSet ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, foto FROM cliente");// WHERE fin_periodo < '" + fechahoy + "'");
                ds.WriteXml("C:\\CGSystem\\CGSystem\\Clientes con Servicios Vencidos.xml");
                VisorReportes f = new VisorReportes("C:\\CGSystem\\CGSystem\\ServiciosVencidos.rpt");//"C:\\CGSystem\\CGSystem\\ServiciosVencidos.rpt"
            f.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No hay clientes activos con servicios vencidos!");
            //}
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeEmpleados f = new ListaDeEmpleados();
            f.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDClientes f = new CRUDClientes();
            f.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDEmpleados f = new CRUDEmpleados();
            f.ShowDialog(); 
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiciosEmitidos f = new ServiciosEmitidos();
            f.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamentos f = new Departamentos();
            f.ShowDialog();
        }
    }
}
