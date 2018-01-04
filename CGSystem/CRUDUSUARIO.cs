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
    public partial class CRUDUSUARIO : Form
    {
        operacion oper = new operacion();
        public CRUDUSUARIO()
        {
            InitializeComponent();
        }

        private void CRUDUSUARIO_Load(object sender, EventArgs e)
        {
            btnguardarusuario.Enabled = false;
            btnactualizarusuario.Enabled = false;
        }

        private void btnguardarusuario_Click(object sender, EventArgs e)
        {
            string tipousuario;
            string idempleado;
            string estado;
            DataSet ds = new DataSet();
            ds = oper.ConsultaConResultado("SELECT codigo_tipo_usuario FROM tipo_usuario WHERE descripcion_tipo_usuario = '" + cbtipocuentausuario.Text + "'");
            tipousuario = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_estado_usuario FROM estado WHERE descripcion_estado = '" + cbestadousuario.Text + "'");
            estado = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT numero_empleado FROM login WHERE numero_empleado = '" + cbnumeroempleado.Text + "'");
            try
            {
                idempleado = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                idempleado = "Nuevo usuario";
            }

            if (cbtipocuentausuario.Text != "" && cbnumeroempleado.Text != "" && tbaliasusuario.Text != "" && tbcontrasenausuario.Text != "")
            {
                DialogResult Result = MessageBox.Show("Se creará un nuevo usuario del tipo: " + cbtipocuentausuario.Text, "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    if (idempleado == cbnumeroempleado.Text)
                    {
                        MessageBox.Show("Este empleado ya posee una cuenta de usuario, favor revisar");
                        return;
                    }
                    else
                    {
                        oper.ConsultaSinResultado("INSERT INTO login (numero_empleado, alias_usuario, clave_usuario, codigo_tipo_usuario, codigo_estado) VALUES ('" + cbnumeroempleado.Text.ToString() + "','" + tbaliasusuario.Text.ToString() + "','" + tbcontrasenausuario.Text.ToString() + "','" + tipousuario + "', '" + estado + "')");
                        MessageBox.Show("Se registró el nuevo usuario!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos...");
            }
        }

        private void btnactualizarusuario_Click(object sender, EventArgs e)
        {
            string idtipousuario;
            string idestadousuario;
            DataSet ds = new DataSet();
            ds = oper.ConsultaConResultado("SELECT codigo_tipo_usuario FROM tipo_usuario WHERE descripcion_tipo_usuario = '" + cbtipocuentausuario.Text + "'");
            idtipousuario = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_estado FROM estado WHERE descripcion_estado = '" + cbestadousuario.Text + "'");
            idestadousuario = ds.Tables[0].Rows[0][0].ToString();
            if (cbtipocuentausuario.Text != "" && tbaliasusuario.Text != "" && tbcontrasenausuario.Text != "")
            {
                oper.ConsultaSinResultado("UPDATE login SET alias_usuario = '" + tbaliasusuario.Text.ToString() + "', clave_usuario = '" + tbcontrasenausuario.Text.ToString().ToUpper() + "', codigo_tipo_usuario = '" + idtipousuario + "', codigo_estado = '" + idestadousuario + "' WHERE numero_empleado = '" + cbnumeroempleado.Text + "'");
                cbtipocuentausuario.Text = "";
                tbaliasusuario.Text = "";
                tbcontrasenausuario.Text = "";
                cbnumeroempleado.Text = "";
                cbestadousuario.Text = "";
                MessageBox.Show("El usuario fue actualizado correctamente!");
            }
            else MessageBox.Show("Debe completar todos los datos!");
        }
    }
}
