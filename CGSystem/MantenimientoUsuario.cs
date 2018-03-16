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
            bool eliminarusuario = oper.CajaDeMensaje("¿Seguro que de sea eliminar este usuario?", "Eliminar");
            if (eliminarusuario)
            {
                if (dgvusuarios.SelectedRows.Count == 1)
                {
                    oper.ConsultaSinResultado("DELETE FROM login WHERE usuario = '" + dgvusuarios.CurrentRow.Cells[0].Value.ToString() + "';");
                    MostrarTodos();
                }
            }
            else { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoUsuario();
            txtusuario.Focus();
        }

        private void button1_Click(object sender, EventArgs e) //Resetear
        {
            bool eliminarusuario = oper.CajaDeMensaje("¿Seguro que de sea resetear este usuario?", "Resetear");
            if (eliminarusuario)
            {
                if (dgvusuarios.SelectedRows.Count == 1)
                {
                    oper.ConsultaSinResultado("UPDATE login SET clave_usuario = '123456' WHERE alias_usuario = '" + dgvusuarios.CurrentRow.Cells[0].Value.ToString() + "';");
                    MostrarTodos();
                }
            }
            else { }
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
                modificar = true;
                btnagregar.Text = "MODIFICAR";
                DataSet ds = oper.ConsultaConResultado("SELECT login.alias_usuario, login.numero_empleado, tipo_usuario.descripcion_tipo_usuario  FROM login INNER JOIN tipo_usuario on tipo_usuario.codigo_tipo_usuario = login.codigo_tipo_usuario WHERE alias_usuario = '" + idmodificar + "';");
                txtempleado.Text = CargarEmpleado(dgvusuarios.CurrentRow.Cells[2].Value.ToString());
                txtidempleado.Text = ds.Tables[0].Rows[0][1].ToString();
                txtusuario.Text = ds.Tables[0].Rows[0][0].ToString();
                txtcontraseña.Text = "*******";
                cbtipousuario.Text = ds.Tables[0].Rows[0][2].ToString();
                txtusuario.Focus();
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
                    oper.ConsultaSinResultado("UPDATE login SET alias_usuario = '" + txtusuario.Text + "', clave_usuario = '" + txtcontraseña.Text + "', numero_empleado = '" + txtidempleado.Text + "', coddigo_tipo_usuario = '" + CodigoTipoUsuario + "' WHERE alias_usuario = '" + idmodificar + "';");
                    NuevoUsuario();
                }
                else
                {
                    oper.ConsultaSinResultado("INSERT INTO login (alias_usuario, clave_usuario, numero_empleado, codigo_tipo_usuario) VALUES ('" + txtusuario.Text + "','" + txtcontraseña.Text + "','" + txtidempleado.Text + "','" + CodigoTipoUsuario + "');");
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
