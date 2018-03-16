using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class Seleccionar_Empleado : Form
    {
        operacion oper = new operacion();
        DataSet ds = new DataSet();

        public Seleccionar_Empleado()
        {
            InitializeComponent();
        }

        private void Seleccionar_Empleado_Load(object sender, EventArgs e)
        {
            rdtodos.PerformClick();
            Buscar(); //MostrarTodo
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {
            try
            {
                if (rdbnombre.Checked)
                {
                    ds = oper.ConsultaConResultado("SELECT numero_empleado, nombre, apellido, cedula_empleado FROM empleado WHERE nombre LIKE '%" + tbbuscar.Text + "%'");
                    MostrarDataSet(ds);
                }
                else if (rdbid.Checked)
                {
                    ds = oper.ConsultaConResultado("SELECT numero_empleado, nombre, apellido, cedula_empleado FROM empleado WHERE numero_empleado = '" + tbbuscar.Text + "'");
                    MostrarDataSet(ds);
                }
                else if (rdbapellido.Checked)
                {
                    ds = oper.ConsultaConResultado("SELECT numero_empleado, nombre, apellido, cedula_empleado FROM empleado WHERE apellido LIKE '%" + tbbuscar.Text + "%'");
                    MostrarDataSet(ds);
                }
                else if (rdtodos.Checked)
                {
                    ds = oper.ConsultaConResultado("SELECT numero_empleado, nombre, apellido, cedula_empleado FROM empleado WHERE apellido LIKE '%" + tbbuscar.Text + "%'");
                    MostrarDataSet(ds);
                }

                else MessageBox.Show("Favor seleccionar una de las opciones...", "Buscar");
            }
            catch (Exception)
            {
                MessageBox.Show("No se cargaron los empleados...", "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void MostrarDataSet(DataSet ds)
        {
            try
            {
                //Pasar de una DataSet a un DataGrid
                dataGridView1.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    for (int k = 0; k < 4; k++)
                    {
                        dataGridView1.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error al mostrar los empleados...", "Empleados");
                return;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            CRUDEmpleados f = new CRUDEmpleados();
            f.ShowDialog();
            rdtodos.PerformClick();
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        public void Seleccionar()
        {
            try
            {
                MenuPrincipal.idseleccionar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            catch
            {
                MessageBox.Show("No seleccionó ningún empleado...", "Seleccionar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar();
        }
    }
}
