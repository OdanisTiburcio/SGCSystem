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
        DataSet ds = new DataSet();
        operacion oper = new operacion();

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

            try
            {
                ds = oper.ConsultaConResultado("SELECT clave_usuario, numero_empleado, codigo_tipo_usuario FROM login WHERE alias_usuario = '"+cbusuario.Text+"'");
                string clave = ds.Tables[0].Rows[0][0].ToString();
                if(clave == tbcontraseña.Text)
                {
                    MenuPrincipal.Logeado = true;
                    MenuPrincipal.UsuarioID = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
                    MenuPrincipal.TipoUsuario = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
                    ds = oper.ConsultaConResultado("SELECT nombre, apellido FROM empleado WHERE numero_empleado = '"+MenuPrincipal.UsuarioID.ToString()+"'");
                    MenuPrincipal.SalirDelSistema = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, inténtelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbcontraseña.Select();
                }
            }
            catch
            {
                MessageBox.Show("Este usuario no existe");
            }



            if (cbusuario.Text == "Adanis Tiburcio" || cbusuario.Text == "Jeffry Marte" && tbcontraseña.Text == "bros")
            {

            }
            else
            {


            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MenuPrincipal.SalirDelSistema = true;
            CargarUsuarios();
        }

        public void CargarUsuarios()
        {
            try//Cargar Usuarios al combobox
            {
                cbusuario.Items.Clear();
                ds = oper.ConsultaConResultado("SELECT alias_usuario FROM login;");
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    cbusuario.Items.Add(fila["alias_usuario"].ToString());
                }
                cbusuario.Text = cbusuario.Items[0].ToString(); //Seleccionar el primer usuario encontrado...
            }
            catch
            {
                MessageBox.Show("Error al cargar los usuarios, revise la base de datos...");
            }
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

        private void tbcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Entrar();
                e.Handled = true;
            }
        }
    }
}