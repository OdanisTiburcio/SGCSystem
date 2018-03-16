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
        public static int TipoUsuario = 0; //usuario 1 igual a administrador y usuario 2 igual a empleado...
        public string estadoreporte;
        public static string SelecciónDeCliente = "0";
        public static string SeleccionDeServicio = "0";
        public static string idseleccionar = "0";

        //Clases Reutilizables
        operacion oper = new operacion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public MenuPrincipal()
        {
            InitializeComponent();
            //Mostrar estado si o no en tabla de reportes vencidos
            ds = oper.ConsultaConResultado("SELECT mostrar_reporte FROM reporte_vencidos WHERE id_reporte = '1'");
            estadoreporte = ds.Tables[0].Rows[0][0].ToString();
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

                //Desactivar los Campos para usuarios específicos...
                if (TipoUsuario == 1) //Administrador
                {
                    //Activar
                    consultasToolStripMenuItem.DropDownItems[3].Visible = true;
                    contabilidadToolStripMenuItem.DropDownItems[0].Visible = true;
                    archivoToolStripMenuItem.DropDownItems[1].Visible = true;
                    archivoToolStripMenuItem.DropDownItems[2].Visible = true;
                    archivoToolStripMenuItem.DropDownItems[3].Visible = true;
                    archivoToolStripMenuItem.DropDownItems[6].Visible = true;
                    archivoToolStripMenuItem.DropDownItems[7].Visible = true;

                }
                else //Empleado
                {
                    //Desactivar
                    consultasToolStripMenuItem.DropDownItems[3].Visible = false;
                    contabilidadToolStripMenuItem.DropDownItems[0].Visible = false;
                    contabilidadToolStripMenuItem.DropDownItems[1].Visible = false;
                    archivoToolStripMenuItem.DropDownItems[0].Visible = true;
                    archivoToolStripMenuItem.DropDownItems[1].Visible = false;
                    archivoToolStripMenuItem.DropDownItems[2].Visible = false;
                    archivoToolStripMenuItem.DropDownItems[3].Visible = false;
                    archivoToolStripMenuItem.DropDownItems[6].Visible = false;
                    archivoToolStripMenuItem.DropDownItems[7].Visible = false;
                    archivoToolStripMenuItem.DropDownItems[8].Visible = false;
                    ayudaToolStripMenuItem.DropDownItems[0].Visible = false;

                }

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
            check.ShowDialog();
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
            //Si el usuario selecciona mostrar el reporte de vencidos en el menú principal
            if (estadoreporte == "si")
            {
                MostrarCLientesVencidos();
            }
            else
            {
                return;
            }
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
            Form f = new MantenimientoDeServicios();
            f.ShowDialog();
        }

        private void listaDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarServicio f = new SeleccionarServicio();
            f.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamentos f = new Departamentos();
            f.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool salir = oper.CajaDeMensaje("¿Seguro que Desea Cerrar Sesión?", "Aviso");
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
                DataSet ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, fin_periodo, foto FROM cliente WHERE fin_periodo < '" + fecha + "' AND codigo_estado = '1'");
                if (ds.Tables[0].Rows[0][0].ToString() == "")
                {
                    MessageBox.Show("No hay clientes activos con servicios vencidos!", "Reporte de Clientes con Servicios Vencidos", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
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

            }
            else
            {
                this.Close();
            }

        }

        private void facturarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void cuadreCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuadreCaja f = new CuadreCaja();
            f.ShowDialog();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDIngresos f = new CRUDIngresos();
            f.ShowDialog();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC f = new CXC();
            f.ShowDialog();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciudades f = new Ciudades();
            f.ShowDialog();
        }

        private void sectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sectores f = new Sectores();
            f.ShowDialog();
        }

        private void posicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posiciones f = new Posiciones();
            f.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new MantenimientoUsuario();
            f.ShowDialog();
        }

        private void reporteVencidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Seleccionar si el usuario desea o no mostrar el reporte de servicios vencidos al inicio del sistema
            DialogResult Result = MessageBox.Show("Reporte de clientes activos con servicios vencidos." + Environment.NewLine + "" + Environment.NewLine + "¿Desea mostrar este reporte cada ocasión al iniciar el sistema?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                oper.ConsultaSinResultado("UPDATE reporte_vencidos SET mostrar_reporte = 'si' WHERE id_reporte = '1'");
            }
            else
            {
                oper.ConsultaSinResultado("UPDATE reporte_vencidos SET mostrar_reporte = 'no' WHERE id_reporte = '1'");
            }
        }

        private void tsmcheckin_Click(object sender, EventArgs e)
        {
            CheckIn f = new CheckIn();
            f.ShowDialog();
        }

        private void controlDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlMedidas frm = new CtrlMedidas();
            frm.Show();
        }

        private void activarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = oper.ConsultaConResultado("SELECT estado FROM licencia;");
            if (ds.Tables[0].Rows[0][0].ToString() == "ACTIVADO")
            {
                MessageBox.Show("¡Enhorabuena! su producto ya está activado...", "Activación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form f = new insertarLicencia();
                f.ShowDialog();
            }            
        }
    }
}
