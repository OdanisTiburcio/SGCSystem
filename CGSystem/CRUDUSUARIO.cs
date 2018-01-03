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
            //DataSet ds = new DataSet();
            //ds = oper.ConsultaConResultado("SELECT numero_empleado FROM empleado ORDER BY numero_empleado");
            //cbnumeroempleado.DataSource = ds.Tables[0].Rows[0][0];
        }

        private void btnnuevoingreso_Click(object sender, EventArgs e)
        {
            cbtipocuentausuario.Enabled = true;
            cbnumeroempleado.Enabled = true;
            tbaliasusuario.Enabled = true;
            tbcontrasenausuario.Enabled = true;

        }

        private void btnguardarusuario_Click(object sender, EventArgs e)
        {
            string tipousuario;
            string idempleado;
            DataSet ds = new DataSet();
            ds = oper.ConsultaConResultado("SELECT codigo_tipo_usuario FROM tipo_usuario WHERE descripcion_tipo_usuario = '" + cbtipocuentausuario.Text + "'");
            tipousuario = ds.Tables[0].Rows[0][0].ToString();
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
                        oper.ConsultaSinResultado("INSERT INTO login (numero_empleado, alias_usuario, clave_usuario, codigo_tipo_usuario) VALUES ('" + cbnumeroempleado.Text.ToString() + "','" + tbaliasusuario.Text.ToString() + "','" + tbcontrasenausuario.Text.ToString() + "','" + cbtipocuentausuario.Text + "')");
                        MessageBox.Show("Se registró el nuevo usuario!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos...");
            }
        }
    }
    }
