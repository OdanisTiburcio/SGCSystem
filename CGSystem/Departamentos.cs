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
            operacion oper = new operacion();
            oper.ConsultaSinResultado("DELETE FROM departamento WHERE codigo_departamento ='" + tbCodigoDepartamento1.Text.ToString() + "')");
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            tbCodigoDepartamento1.ReadOnly = true;
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
            operacion oper = new operacion();
            oper.ConsultaSinResultado("UPDATE departamento SET descripcion_departamento ='" + tbDescripDepartamento.Text.ToString().ToUpper() + "' WHERE codigo_departamento = '" + tbCodigoDepartamento1.Text.ToString() + "')");
        }
    }
}
