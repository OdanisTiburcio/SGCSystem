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
    public partial class SeleccionarSector : Form
    {
        public operacion oper = new operacion();
        public DataSet ds = new DataSet();

        public SeleccionarSector()
        {
            InitializeComponent();
        }

        private void SeleccionarSector_Load(object sender, EventArgs e)
        {
            MostrarTodo();
        }

        public void MostrarTodo()
        {
            try
            {
                dgvListaSectores.Rows.Clear();
                //Cargar la Tabla de todos los clientes activos
                ds = oper.ConsultaConResultado("SELECT * FROM sector;");

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    dgvListaSectores.Rows.Add();
                    for (int k = 0; k < 2; k++)
                    {
                        dgvListaSectores.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar todo", "Aviso");
            }

        }

        public void Seleccionar()
        {
            if(dgvListaSectores.SelectedRows.Count == 1)
            {
                Sectores.NuevoSector = false;
                Sectores.SectorEditarID = dgvListaSectores.CurrentRow.Cells[0].Value.ToString();
                Sectores.SectorEditarDesc = dgvListaSectores.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione el sector correctamente", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListaSectores.Focus();
            }
        }

        private void dgvListaSectores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarPor();
        }

        public void BuscarPor()
        {

            try
            {
                dgvListaSectores.Rows.Clear();
                //Cargar con el filtro especificado...
                if (rdbnombre.Checked)
                {
                    ds = oper.ConsultaConResultado("SELECT * FROM sector WHERE descripcion_sector Like '%" + tbbuscar.Text + "%';");
                }
                else
                {
                    ds = oper.ConsultaConResultado("SELECT * FROM sector WHERE codigo_sector = '" + tbbuscar.Text + "';");
                }

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    dgvListaSectores.Rows.Add();
                    for (int k = 0; k < 2; k++)
                    {
                        dgvListaSectores.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Sectores.CrearNuevo = true;
            this.Close();
        }

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            BuscarPor();
        }
    }
}
