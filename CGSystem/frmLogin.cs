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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            cbusuario.Select();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Entrar()
        {

            if (cbusuario.Text == "Adanis Tiburcio" && tbcontraseña.Text == "bros")
            {
                Form f = new Visor_de_Datos_Sqlite();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Revise los datos e inténtelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbcontraseña.Select();

            }

        }

    }
}
