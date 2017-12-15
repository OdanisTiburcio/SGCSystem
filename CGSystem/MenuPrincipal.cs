using System;
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

        //Clases Reutilizables
        operacion oper = new operacion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

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

                    if (SalirDelSistema)
                    {
                        this.Close();
                        return;
                    }
                    else
                    {
                    }
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
            CheckIn check = new CheckIn();
            check.Show();
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
            Cerrar();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            Actualizar();
            if (SalirDelSistema)
            {
                return;
            }
            else
            {
            }

            MostrarCLientesVencidos();

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

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool salir = oper.CajaDeMensaje("Seguro que desea Cerrar Sesión", "Aviso");
            if (salir)
            {
                Logeado = false;
                Actualizar();
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarCLientesVencidos();
        }

        public void MostrarCLientesVencidos()
        {
            try
            {
                DateTime fechahoy = DateTime.Today;
                string fecha = oper.FormatearFecha(fechahoy);
                DataSet ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, fin_periodo, foto FROM cliente WHERE fin_periodo < '" + fecha + "'");
                ds.WriteXml("C:\\CGSystem\\CGSystem\\Clientes con Servicios Vencidos.xml");
                Form f = new VisorReportes("ServiciosVencidos.rpt");
                f.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No hay clientes activos con servicios vencidos!");
            }
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SalirDelSistema)
            {
                Cerrar();
                if (!SalirDelSistema)
                {
                    e.Cancel = true;
                }
                else
                {

                }
            }
            else { }
        }

        public void Cerrar()
        {
            if (!SalirDelSistema)
            {
                DialogResult Result = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    SalirDelSistema = true;
                    this.Close();
                }
            }else
            {
                this.Close();
            }

        }

        private void facturarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CheckIn f = new CheckIn();
            f.Show();
        }
    }
}
