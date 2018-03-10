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
    public partial class Sectores : Form
    {
        public Sectores()
        {
            InitializeComponent();
        }

        private void btnguardarsector_Click(object sender, EventArgs e)
        {
            if (tbdescripsector.Text == "")
            {
                MessageBox.Show("Favor digitar un nombre de sector válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("INSERT INTO sector (descripcion_sector) VALUES ('" + tbdescripsector.Text.ToString().ToUpper() + "')");
                tbdescripsector.Clear();
                MessageBox.Show("Datos registrados satisfactoriamente!");
            }

        }

        private void btnactualizarsector_Click(object sender, EventArgs e)
        {
            if (tbcodigosector.Text == "")
            {
                MessageBox.Show("Favor digitar un código de sector válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("UPDATE sector SET descripcion_sector ='" + tbdescripsector.Text.ToString().ToUpper() + "' WHERE codigo_sector = '" + tbcodigosector.Text.ToString() + "'");
                tbcodigosector.Clear();
                tbdescripsector.Clear();
                MessageBox.Show("Datos actualizados correctamente!");
            }

        }

        private void btneliminarsector_Click(object sender, EventArgs e)
        {
            if (tbcodigosector.Text == "")
            {
                MessageBox.Show("Favor digitar un código de sector válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("DELETE FROM sector WHERE codigo_sector ='" + tbcodigosector.Text.ToString() + "'");
                tbcodigosector.Clear();
                tbdescripsector.Clear();
                MessageBox.Show("Sector eliminado correctamente!");
            }

        }

        private void btnimprimirsector_Click(object sender, EventArgs e)
        {

        }
    }
}
