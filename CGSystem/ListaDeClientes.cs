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
    public partial class ListaDeClientes : Form
    {
        //Variables necesarias
        public static bool Seleccionando = false;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        operacion oper = new operacion();

        public ListaDeClientes()
        {
            InitializeComponent();
        }

        private void ListaDeClientes_Load(object sender, EventArgs e)
        {
            if (Seleccionando)
            {
                btnimprimir.Text = "Seleccionar";
                btnimprimir.Enabled = true;
            }
            else { btnimprimir.Text = "Imprimir"; }

            MostrarTodo();

        }

        public void ImprimirSel()
        {
            if (Seleccionando)
            {
                try
                {
                    //Seleccionar el id de la columna seleccionada.
                    CheckIn.IdEmpleado = dgvListaEmpleados.CurrentRow.Cells[0].Value.ToString();
                    Seleccionando = false;
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Hubo un error al seleccionar el cliente, inténtelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {

                try
                {
                    //Codigo para imprimir Reporte Presentado en el DataGridView de Lista de Empleados
                }
                catch
                {
                    MessageBox.Show("Hubo un error al intentar imprimir el reporte actual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            ImprimirSel();
        }

        private void dgvListaEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Seleccionando)
            {
                ImprimirSel();
            }
            else
            {

            }
        }

        public void MostrarTodo()
        {
            //Este método muestra todos los clientes existentes en la base de datos
            try
            {
                dgvListaEmpleados.Rows.Clear();
                //Cargar la Tabla de todos los empleados activos
                ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, inicio_periodo, fin_periodo FROM cliente;"); //WHERE codigo_estado = '1' o Activo

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    dgvListaEmpleados.Rows.Add();
                    for (int k = 0; k < 6; k++)
                    {
                        dgvListaEmpleados.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                    }

                }

            }
            catch
            {

            }
        }

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            MostrarTodo();
        }
    }
}
