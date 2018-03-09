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
    public partial class insertarLicencia : Form
    {
        public operacion oper = new operacion();

        public insertarLicencia()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtlicencia.Text == "CF567-DFD345-SSDD324RRR3")//Licencia Correcta
            {
                oper.ConsultaSinResultado("UPDATE licencia SET fechaini = '2998-01-01';");
                MessageBox.Show("Felicidades, ha activado satisfactoriamente el sistema...", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.IniciarSistema = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Licencia Incorrecta, revise bien los carácteres insertados...","Error de Activación",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
