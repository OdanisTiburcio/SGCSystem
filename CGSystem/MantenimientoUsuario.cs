using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class MantenimientoUsuario : Form
    {
        operacion oper = new operacion();
        public bool modificar = false;
        public string idmodificar = "";
        public string AliasDeUsuarioDelDueñoDelSistema = "Cosobo";

        public MantenimientoUsuario()
        {
            InitializeComponent();
        }

        private void MantenimientoUsuario_Load(object sender, EventArgs e)
        {
            MostrarTodos();
            cbtipousuario.SelectedIndex = 0;
        }

        private void dgvequipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idmodificar = dgvusuarios.CurrentRow.Cells[0].Value.ToString();
            Modificar();
        }

        private void btnbuscar_Click(object sender, EventArgs e) //Eliminar
        {
            if (dgvusuarios.CurrentRow.Cells[3].Value.ToString() != "ADMINISTRADOR" && dgvusuarios.CurrentRow.Cells[0].Value.ToString() != "Cosobo")
            {

                bool eliminarusuario = oper.CajaDeMensaje("¿Seguro que de sea eliminar este usuario?", "Eliminar");
                if (eliminarusuario)
                {
                    if (dgvusuarios.SelectedRows.Count == 1)
                    {
                        oper.ConsultaSinResultado("DELETE FROM login WHERE alias_usuario = '" + dgvusuarios.CurrentRow.Cells[0].Value.ToString() + "';");
                        MostrarTodos();
                    }
                }
                else
                {

                }

            }
            else
            {
                MessageBox.Show("No puede eliminar la cuenta de un administrador...", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoUsuario();
            txtusuario.Focus();
        }

        private void button1_Click(object sender, EventArgs e) //Resetear
        {
            if (dgvusuarios.CurrentRow.Cells[3].Value.ToString() != "ADMINISTRADOR" && dgvusuarios.CurrentRow.Cells[0].Value.ToString() != "Cosobo")
            {
                bool eliminarusuario = oper.CajaDeMensaje("¿Seguro que de sea resetear este usuario?", "Resetear");
                if (eliminarusuario)
                {
                    if (dgvusuarios.SelectedRows.Count == 1)
                    {
                        oper.ConsultaSinResultado("UPDATE login SET clave_usuario = '123456' WHERE alias_usuario = '" + dgvusuarios.CurrentRow.Cells[0].Value.ToString() + "';");
                        MessageBox.Show("Cuenta Reseteada, ahora la contraseña de este usuario es: 123456", "Reseteada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarTodos();
                    }
                }
                else { }
            }
            else
            {
                MessageBox.Show("No puede resetear la cuenta de un administrador...", "Resetear", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            Form f = new Seleccionar_Empleado();
            MenuPrincipal.idseleccionar = "0";
            f.ShowDialog();
            if (MenuPrincipal.idseleccionar != "0")
            {
                txtempleado.Text = CargarEmpleado(MenuPrincipal.idseleccionar);
                txtidempleado.Text = MenuPrincipal.idseleccionar;
                MenuPrincipal.idseleccionar = "0";
            }
            else { }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            CrearModificar();
            MostrarTodos();
        }

        //Métodos-Funciones
        public void MostrarTodos()
        {
            DataSet ds = oper.ConsultaConResultado("SELECT login.alias_usuario, empleado.nombre, tipo_usuario.descripcion_tipo_usuario  FROM login INNER JOIN empleado on empleado.numero_empleado = login.numero_empleado INNER JOIN tipo_usuario on tipo_usuario.codigo_tipo_usuario = login.codigo_tipo_usuario;");

            dgvusuarios.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvusuarios.Rows.Add();

                dgvusuarios.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                dgvusuarios.Rows[i].Cells[1].Value = "*******";
                dgvusuarios.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][1].ToString();
                dgvusuarios.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][2].ToString();

            }

        }

        public void Modificar()
        {
            try
            {
                txtusuario.Enabled = false;
                modificar = true;
                btnagregar.Text = "MODIFICAR";
                DataSet ds = oper.ConsultaConResultado("SELECT login.alias_usuario, login.numero_empleado, tipo_usuario.descripcion_tipo_usuario, login.clave_usuario FROM login INNER JOIN tipo_usuario on tipo_usuario.codigo_tipo_usuario = login.codigo_tipo_usuario WHERE alias_usuario = '" + idmodificar + "';");
                txtempleado.Text = CargarEmpleado(ds.Tables[0].Rows[0][1].ToString());
                txtidempleado.Text = ds.Tables[0].Rows[0][1].ToString();
                txtusuario.Text = ds.Tables[0].Rows[0][0].ToString();
                txtcontraseña.Text = ds.Tables[0].Rows[0][3].ToString();
                cbtipousuario.Text = ds.Tables[0].Rows[0][2].ToString();
                txtusuario.Focus();

                //Validar que la cuenta del superusuario o dueño del negocio no esté siendo cambiada a tipo "EMPLEADO"
                if (txtusuario.Text == AliasDeUsuarioDelDueñoDelSistema)
                {
                    cbtipousuario.Enabled = false;
                }
                else
                {
                    cbtipousuario.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Hubo un error al intentar cargar el usuario que desea modificar...", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public string CargarEmpleado(string idempleado)
        {
            try
            {
                //Cargar nombre del empleado desde el id
                DataSet ds = oper.ConsultaConResultado("SELECT nombre FROM empleado WHERE numero_empleado = '" + idempleado + "';");
                return ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("Error al tratar de Cargar el Empleado...", "Cargar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }

        }

        public void NuevoUsuario()
        {
            txtusuario.Enabled = true;
            cbtipousuario.Enabled = true;
            modificar = false;
            txtcontraseña.Clear();
            txtempleado.Text = "Seleccione";
            txtidempleado.Text = "0";
            txtusuario.Clear();
            cbtipousuario.SelectedIndex = 0;
            btnagregar.Text = "CREAR";
        }

        public bool ValidarCampos()
        {
            if (txtidempleado.Text != "0")
            {
                if (txtusuario.TextLength < 6 || txtcontraseña.TextLength < 6)
                {
                    MessageBox.Show("El usuario y la contraseña deben ser de por lo menos seis (6) carácteres...", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusuario.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos...", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public void CrearModificar()
        {
            //Crear o modificar el usuario segun sea el caso
            bool CamposCompletados = ValidarCampos();
            string CodigoTipoUsuario = SaberTipoUsuarioPorID(cbtipousuario.Text);
            if (CamposCompletados)
            {
                if (modificar)
                {
                    oper.ConsultaSinResultado("UPDATE login SET alias_usuario = '" + txtusuario.Text + "', clave_usuario = '" + txtcontraseña.Text + "', numero_empleado = '" + txtidempleado.Text + "', codigo_tipo_usuario = '" + CodigoTipoUsuario + "' WHERE alias_usuario = '" + idmodificar + "';");
                    NuevoUsuario();
                    MessageBox.Show("Usuario Modificado Satisfactoriamente...", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    oper.ConsultaSinResultado("INSERT INTO login (alias_usuario, clave_usuario, numero_empleado, codigo_tipo_usuario) VALUES ('" + txtusuario.Text + "','" + txtcontraseña.Text + "','" + txtidempleado.Text + "','" + CodigoTipoUsuario + "');");
                    MessageBox.Show("Usuario creado Satisfactoriamente...", "Crear", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoUsuario();
                }
            }
            else { }
        }

        public string SaberTipoUsuarioPorID(string descripcion)
        {
            DataSet ds = oper.ConsultaConResultado("SELECT tipo_usuario.codigo_tipo_usuario FROM tipo_usuario WHERE tipo_usuario.descripcion_tipo_usuario = '" + descripcion + "';");
            return ds.Tables[0].Rows[0][0].ToString();
        }



    }

}
