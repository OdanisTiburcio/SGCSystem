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
            //Validar Inicio de Sesión
            if (cbusuario.Text == "Adanis Tiburcio" && tbcontraseña.Text == "bros")
            {
                MenuPrincipal.Logeado = true;
                MenuPrincipal.SalirDelSistema = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectos, inténtelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbcontraseña.Select();

            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MenuPrincipal.SalirDelSistema = true;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MenuPrincipal.Logeado) { }
            else
            {
                bool cerrar = true;
                cerrar = Cerrar(cerrar);
                if (!cerrar)
                {
                    e.Cancel = true;
                }
                else
                {
                }
            }
        }

        public bool Cerrar(bool close)
        {
            DialogResult Result = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                close = true;
                return close;
            }
            close = false;
            return close;
        }

    }
}