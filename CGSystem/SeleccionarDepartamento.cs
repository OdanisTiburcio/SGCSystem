using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class SeleccionarDepartamento : Form
    {
        public operacion oper = new operacion();
        public DataSet ds = new DataSet();
        public SeleccionarDepartamento()
        {
            InitializeComponent();
        }
        public void BuscarPor()
        {

            try
            {
                dgvlistadepartamentos.Rows.Clear();
                //Cargar con el filtro especificado...
                if (rdbnombre.Checked)
                {
                    ds = oper.ConsultaConResultado("SELECT * FROM departamento WHERE descripcion_departamento LIKE '%" + tbbuscar.Text + "%';");
                }
                else
                {
                    ds = oper.ConsultaConResultado("SELECT * FROM departamento WHERE codigo_departamento = '" + tbbuscar.Text + "';");
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
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarPor();
        }

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarPor();
        }
        public void Seleccionar_Dpto()
        {
            if (dgvlistadepartamentos.SelectedRows.Count == 1)
            {
                Departamentos.NuevoDepartamento = false;
                Departamentos.DepartamentoEditarID = dgvlistadepartamentos.CurrentRow.Cells[0].Value.ToString();
                Departamentos.DepartamentoEditarDesc = dgvlistadepartamentos.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione el Departamento correctamente", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvlistadepartamentos.Focus();
            }
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
            BuscarPor();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Departamentos.CrearNuevo = true;
            this.Close();
        }

        public void MostrarTodo()
        {
            try
            {
                dgvlistadepartamentos.Rows.Clear();
                ds = oper.ConsultaConResultado("SELECT * FROM departamento;");

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
        private void SeleccionarDepartamento_Load(object sender, EventArgs e)
        {
            MostrarTodo();
        }
    }
}
