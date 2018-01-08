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
    public partial class SeleccionarCliente : Form
    {
        //Clases y Variables Reutilizables
        operacion oper = new operacion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public SeleccionarCliente()
        {
            InitializeComponent();
        }

        private void SeleccionarCliente_Load(object sender, EventArgs e)
        {
            MostrarTodo();
        }

        public void MostrarTodo()
        {
            try
            {
                dgvListaServicios.Rows.Clear();
                //Cargar la Tabla de todos los clientes activos
                ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, direccion_cliente FROM cliente;");

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    dgvListaServicios.Rows.Add();
                    for (int k = 0; k < 4; k++)
                    {
                        dgvListaServicios.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar todo", "Aviso");
            }

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        public void Seleccionar()
        {
            try
            {
                //Método para seleccionar el cliente marcado o clickeado
                Facturación.IdCliente = dgvListaServicios.CurrentRow.Cells[0].Value.ToString();
                Facturación.NombreCliente = dgvListaServicios.CurrentRow.Cells[1].Value.ToString()+ " " + dgvListaServicios.CurrentRow.Cells[2].Value.ToString();
                Facturación.SelecciónDeCliente = true; //Marcar un servicio como seleccionado
                MenuPrincipal.SelecciónDeCliente = dgvListaServicios.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            catch
            {
                MessageBox.Show("No se selecciónó un cliente, inténtelo de nuevo correctamente", "Aviso");
            }
        }

        public void BuscarPor()
        {

            try
            {
                dgvListaServicios.Rows.Clear();
                //Cargar con el filtro especificado...
                if (rdbnombre.Checked)
                {
                    ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, direccion_cliente FROM cliente WHERE nombre_cliente Like '%" + tbbuscar.Text + "%';");
                }
                else
                {
                    ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, direccion_cliente FROM cliente WHERE numero_cliente Like '%" + tbbuscar.Text + "%';");
                }

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    dgvListaServicios.Rows.Add();
                    for (int k = 0; k < 4; k++)
                    {
                        dgvListaServicios.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error al realizar la búsqueda, revise la base de datos", "Aviso");

            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Form f = new CRUDClientes();
            f.ShowDialog();
            MostrarTodo();
        }

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            MostrarTodo();
        }

        private void dgvListaServicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void tbbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                Seleccionar();
            }
            else { }
        }

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarPor();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarPor();
        }
    }
}
