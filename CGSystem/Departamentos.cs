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
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
        }
        public bool ReadOnly { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tbCodigoDepartamento.Text == "")
            {
                MessageBox.Show("Favor digitar un código de departamento válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("DELETE FROM departamento WHERE codigo_departamento ='" + tbCodigoDepartamento.Text.ToString() + "'");
                tbCodigoDepartamento.Clear();
                tbDescripDepartamento.Clear();
                MessageBox.Show("Departamento eliminado correctamente!");
            }
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            tbCodigoDepartamento.ReadOnly = true;
        }

        private void btNuevoDepartamento_Click_1(object sender, EventArgs e)
        {
            if (tbDescripDepartamento.Text == "")
            {
                MessageBox.Show("Favor digitar un nombre de departamento válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("INSERT INTO departamento (descripcion_departamento) VALUES ('" + tbDescripDepartamento.Text.ToString().ToUpper() + "')");
                tbDescripDepartamento.Clear();
                MessageBox.Show("Datos registrados satisfactoriamente!");
            }
        }

        private void btGuardarDepartamento_Click_1(object sender, EventArgs e)
        {
            if (tbCodigoDepartamento.Text == "")
            {
                MessageBox.Show("Favor digitar un código de departamento válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("UPDATE departamento SET descripcion_departamento ='" + tbDescripDepartamento.Text.ToString().ToUpper() + "' WHERE codigo_departamento = '" + tbCodigoDepartamento.Text.ToString() + "'");
                tbCodigoDepartamento.Clear();
                tbDescripDepartamento.Clear();
                MessageBox.Show("Datos actualizados correctamente!");
            }

        }

        private void tsbnuevodepartamento_Click(object sender, EventArgs e)
        {
            tbDescripDepartamento.Enabled = true;
        }

        private void tsbbuscardepartamento_Click(object sender, EventArgs e)
        {
            tbCodigoDepartamento.Enabled = true;
        }

        private void btnbuscardepartamento_Click(object sender, EventArgs e)
        {
            //if (tbCodigoDepartamento.Text == "")
            //{
            //    MessageBox.Show("Favor digitar un código de departamento válido!");
            //}
            //else
            //{
            //    operacion oper = new operacion();
            //    oper.ConsultaSinResultado("SELECT * FROM departamento WHERE codigo_departamento = '" + tbCodigoDepartamento.Text.ToString() + "')");
            //    MessageBox.Show("Datos registrados satisfactoriamente!");
            //}
        }
    }
}
