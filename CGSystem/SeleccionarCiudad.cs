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
    public partial class SeleccionarCiudad : Form
    {
        public operacion oper = new operacion();
        public DataSet ds = new DataSet();

        public SeleccionarCiudad()
        {
            InitializeComponent();
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
            Ciudades.CrearNuevo = true;
            this.Close();
        }

        private void dgvlistadepartamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar_Dpto();
        }

        private void btnseleccionardepto_Click(object sender, EventArgs e)
        {
            Seleccionar_Dpto();
        }

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            MostrarTodo();
        }

        private void SeleccionarCiudad_Load(object sender, EventArgs e)
        {
            MostrarTodo();
        }

        public void MostrarTodo()
        {
            try
            {
                dgvlistadepartamentos.Rows.Clear();
                ds = oper.ConsultaConResultado("SELECT * FROM ciudad;");

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    dgvlistadepartamentos.Rows.Add();
                    for (int k = 0; k < 2; k++)
                    {
                        dgvlistadepartamentos.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar todo", "Aviso");
            }

        }

        public void Seleccionar_Dpto()
        {
            if (dgvlistadepartamentos.SelectedRows.Count == 1)
            {
                Ciudades.NuevaCiudad = false;
                Ciudades.CiudadEditarID = dgvlistadepartamentos.CurrentRow.Cells[0].Value.ToString();
                Ciudades.CiudadEditarDesc = dgvlistadepartamentos.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione la ciudad correctamente", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvlistadepartamentos.Focus();
            }
        }

        public void BuscarPor()
        {

            try
            {
                dgvlistadepartamentos.Rows.Clear();
                //Cargar con el filtro especificado...
                if (rdbnombre.Checked)
                {
                    ds = oper.ConsultaConResultado("SELECT * FROM ciudad WHERE descripcion_ciudad LIKE '%" + tbbuscar.Text + "%';");
                }
                else
                {
                    ds = oper.ConsultaConResultado("SELECT * FROM ciudad WHERE codigo_ciudad = '" + tbbuscar.Text + "';");
                }

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    dgvlistadepartamentos.Rows.Add();
                    for (int k = 0; k < 2; k++)
                    {
                        dgvlistadepartamentos.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error al realizar la búsqueda, revise la base de datos", "Aviso");

            }

        }

    }
}
