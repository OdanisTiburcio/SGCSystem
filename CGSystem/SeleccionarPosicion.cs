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
    public partial class SeleccionarPosicion : Form
    {
        public operacion oper = new operacion();
        public DataSet ds = new DataSet();

        public SeleccionarPosicion()
        {
            InitializeComponent();
        }

        private void SeleccionarPosicion_Load(object sender, EventArgs e)
        {

            MostrarTodo();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarPor();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Posiciones.CrearNuevo = true;
            this.Close();
        }

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarPor();
        }

        private void btnseleccionardepto_Click(object sender, EventArgs e)
        {
            Seleccionar_Dpto();
        }

        private void dgvlistadepartamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar_Dpto();
        }

        public void Seleccionar_Dpto()
        {
            if (dgvlistadepartamentos.SelectedRows.Count == 1)
            {
                Posiciones.NuevaPosicion = false;
                Posiciones.PosicionEditarID = dgvlistadepartamentos.CurrentRow.Cells[0].Value.ToString();
                Posiciones.PosicionEditarDesc = dgvlistadepartamentos.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione la Posicion correctamente", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ds = oper.ConsultaConResultado("SELECT * FROM posicion WHERE descripcion_posicion LIKE '%" + tbbuscar.Text + "%';");
                }
                else
                {
                    ds = oper.ConsultaConResultado("SELECT * FROM posicion WHERE codigo_posicion = '" + tbbuscar.Text + "';");
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

        public void MostrarTodo()
        {
            try
            {
                dgvlistadepartamentos.Rows.Clear();
                ds = oper.ConsultaConResultado("SELECT * FROM posicion;");

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

    }
}
