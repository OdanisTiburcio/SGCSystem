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
    public partial class SeleccionarServicio : Form
    {
        //Clases y Variables Reutilizables
        operacion oper = new operacion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public static string NombreABuscar = "";
        public DateTime fechaDT = DateTime.Now;
        public string fechaHoy = "";

        public SeleccionarServicio()
        {
            InitializeComponent();
        }

        private void SeleccionarServicio_Load(object sender, EventArgs e)
        {
            tbbuscar.Text = NombreABuscar;
            BuscarPor();
            if(dgvListaServicios.RowCount > 0 && tbbuscar.Text != "")
            {
                dgvListaServicios.Select();
            }
            else {
                tbbuscar.Select(tbbuscar.Text.Length, 0); //Colocar el cursos al final del texto por si se desea editar...
            }
            
            Facturación.SeleccionDeServicio = false; //desactivar la opción de servicio seleccionado por si solo se cierra el formulario
        }

        public void MostrarTodo()
        {
            try
            {
                dgvListaServicios.Rows.Clear();
                //Cargar la Tabla de todos los servicios activos
                ds = oper.ConsultaConResultado("SELECT * FROM servicio WHERE estado = 'ACTIVO';");

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
                //Método para seleccionar el servicio marcado o clickeado
                Facturación.ServicioBuscarID = dgvListaServicios.CurrentRow.Cells[0].Value.ToString();
                Facturación.SeleccionDeServicio = true; //Marcar un servicio como seleccionado
                MenuPrincipal.SeleccionDeServicio = dgvListaServicios.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            catch
            {
                MessageBox.Show("No se selección un servicio, inténtelo de nuevo correctamente", "Aviso");
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
                    ds = oper.ConsultaConResultado("SELECT * FROM servicio WHERE descripcion_servicio Like '%" + tbbuscar.Text + "%' AND estado = 'ACTIVO';");
                }
                else
                {
                    ds = oper.ConsultaConResultado("SELECT * FROM servicio WHERE codigo_servicio Like '%" + tbbuscar.Text + "%' AND estado = 'ACTIVO';");
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

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarPor();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarPor();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Form f = new MantenimientoDeServicios();
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

        private void dgvListaServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                Seleccionar();
            }
            else { }
        }

        private void tbbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
            else { }
        }
    }
}
