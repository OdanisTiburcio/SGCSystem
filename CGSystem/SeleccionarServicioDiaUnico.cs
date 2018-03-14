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
    public partial class SeleccionarServicioDiaUnico : Form
    {
        public SeleccionarServicioDiaUnico()
        {
            InitializeComponent();
        }

        private void SeleccionarServicioDiaUnico_Load(object sender, EventArgs e)
        {
            MostrarTodo();
            dgvListaServicios.Select();
            dgvListaServicios.Focus();
        }

        public void MostrarTodo()
        {
            try
            {
                dgvListaServicios.Rows.Clear();
                //Cargar la Tabla de todos los servicios activos
                operacion oper = new operacion();
                DataSet ds = oper.ConsultaConResultado("SELECT * FROM servicio WHERE estado = 'ACTIVO';");

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

        private void dgvListaServicios_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    Seleccionar();
            //}
            //else
            //{

            //}
        }


        public void Seleccionar()
        {
            try
            {
                if (dgvListaServicios.SelectedRows.Count == 1) {
                    Facturación.oncecodigo = dgvListaServicios.CurrentRow.Cells[0].Value.ToString();
                    Facturación.oncedescripcion = dgvListaServicios.CurrentRow.Cells[1].Value.ToString();
                    Facturación.onceprecio = dgvListaServicios.CurrentRow.Cells[2].Value.ToString();
                    Facturación.oncedias = dgvListaServicios.CurrentRow.Cells[3].Value.ToString();
                    Facturación.AceptarOnce = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccione un solo servicio...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Hubo algún error al seleccionar el servicio, inténtelo de nuevo...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvListaServicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void dgvListaServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Seleccionar();
            }
            else
            {

            }
        }
    }
}
