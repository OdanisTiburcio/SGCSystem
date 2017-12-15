using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class Facturación : Form
    {

        //Variables Estáticas necesarias
        public static string ServicioBuscarID = "0";
        public static bool SeleccionDeServicio = false; //Para confirmar si se seleccionó un servicio o si solo se cerró el formulario.


        //Clases Reutilizables
        operacion oper = new operacion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public int NuevaFila = 0;
        public double TotalFactura = 0;
        public bool ClienteSeleccionado = false;

        public Facturación()
        {
            InitializeComponent();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Actualizar()
        {
            //Método para actualizar el Data Grid View
            TotalFactura = 0;
            for (int i = 0; i < dgvListaServicios.RowCount; i++)
            {
                dgvListaServicios.Rows[i].Cells[5].Value = Convert.ToInt32(dgvListaServicios.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvListaServicios.Rows[i].Cells[4].Value);
                TotalFactura += Convert.ToInt32(dgvListaServicios.Rows[i].Cells[5].Value);
            }
            tbtotal.Text = "RD$ " + TotalFactura.ToString();
        }

        private void Facturación_Load(object sender, EventArgs e)
        {

        }

        public void AñadirServicioSeleccionado()
        {
            //Con este método se va a añadir a la factura el servicio buscado y seleccionado
            //Cargar la Tabla de todos los servicios activos
            ds = oper.ConsultaConResultado("SELECT * FROM servicio WHERE codigo_servicio = '" + ServicioBuscarID + "';");


            NuevaFila = dgvListaServicios.RowCount; //Escribir sobre la última fila mas uno(+1)...

            dgvListaServicios.Rows.Add();
            for (int k = 0; k < 4; k++)
            {
                dgvListaServicios.Rows[NuevaFila].Cells[k].Value = ds.Tables[0].Rows[0][k].ToString();
            }
            dgvListaServicios.Rows[NuevaFila].Cells[4].Value = "1"; //Asignar cantidad 1 como predeterminada...
            Actualizar();
        }

        private void tbproducto_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    Buscar();
            //}
            //else { }
        }

        public void Buscar()
        {
            //Llamar al formulario de Seleccionar Servicio
            Form f = new SeleccionarServicio();
            SeleccionarServicio.NombreABuscar = tbproducto.Text;//Asignar la palabra clave a buscar/filtrar
            f.ShowDialog();

            if (SeleccionDeServicio)//Comprobar si se seleccionó un servicio...
            {
                AñadirServicioSeleccionado();
                tbproducto.Text = "";
                tbproducto.Focus();
            }
            else { }
        }

        private void tbproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                Buscar();
            }
            else { }

        }

        private void chkbcontado_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCheckBox();
        }

        public void ActualizarCheckBox()
        {
            if (chkbcontado.Checked)
            {
                tbcliente.Enabled = true;
                tbcliente.Text = "";
                tbidcliente.Text = "";
                ClienteSeleccionado = false;
            }
            else
            {
                tbcliente.Enabled = false;
                tbcliente.Text = "";
                tbidcliente.Text = "";
            }
        }
    }
}
