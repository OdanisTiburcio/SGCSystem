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
        public static bool NuevoDepartamento = false;
        public static string DepartamentoEditarID = "0";
        public static string DepartamentoEditarDesc = "";
        public static bool CrearNuevo = false;

        public Departamentos()
        {
            InitializeComponent();
        }

        public bool ReadOnly { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            Nuevo();
            tbDescripDepartamento.Enabled = true;
        }
        public void Nuevo()
        {
            operacion oper = new operacion();
            DataSet ds = new DataSet();

            ds = oper.ConsultaConResultado("SELECT MAX(codigo_departamento) value FROM departamento;");
            try
            {
                tbCodigoDepartamento.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                tbDescripDepartamento.Clear();
                NuevoDepartamento = true;
            }
            catch
            {
                MessageBox.Show("El código del nuevo departamento es erróneo...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tbDescripDepartamento.Clear();

        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            tbCodigoDepartamento.ReadOnly = true;
        }

        private void btNuevoDepartamento_Click_1(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btGuardarDepartamento_Click_1(object sender, EventArgs e)
        {
            Form f = new SeleccionarDepartamento();
            f.ShowDialog();
            if (!NuevoDepartamento)
            {
                tbCodigoDepartamento.Text = DepartamentoEditarID;
                tbDescripDepartamento.Text = DepartamentoEditarDesc;
            }
            else
            {

            }
            if (CrearNuevo)
            {
                Nuevo();
                CrearNuevo = false;
            }
            else
            {
            }
        }

        private void tsbnuevodepartamento_Click(object sender, EventArgs e)
        {
            tbDescripDepartamento.Enabled = true;
        }

        private void tsbbuscardepartamento_Click(object sender, EventArgs e)
        {
            tbCodigoDepartamento.Enabled = true;
        }
        private void btneliminardepartamento_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            if (!NuevoDepartamento)
            {
                bool Eliminar = oper.CajaDeMensaje("¿Seguro que desea eliminar el departamento: " + tbDescripDepartamento.Text + "?", "Eliminar");
                if (Eliminar)
                {
                    if (tbCodigoDepartamento.Text == "")
                    {
                        MessageBox.Show("Favor digitar un código de departamento válido!");
                    }
                    else
                    {
                        bool EstaSiendoUsado = false;
                        DataSet ds = oper.ConsultaConResultado("SELECT codigo_departamento FROM empleado;");
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() == tbCodigoDepartamento.Text)
                            {
                                EstaSiendoUsado = true;
                            }
                            else
                            {

                            }
                        }

                        if (EstaSiendoUsado)
                        {
                            MessageBox.Show("Este departamento no se puede eliminar porque está siendo usado...", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            oper = new operacion();
                            oper.ConsultaSinResultado("DELETE FROM departamento WHERE codigo_departamento ='" + tbCodigoDepartamento.Text.ToString() + "'");
                            MessageBox.Show("Departamento eliminado correctamente!");
                            Nuevo();
                        }
                    }
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Seleccione el Departamento que desea eliminar..." + Environment.NewLine + "Haga clic en el botón Editar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            NuevoDepartamento = true;
            Nuevo();
            if (MenuPrincipal.TipoUsuario == 1)
            {
                btneliminardepartamento.Enabled = true;
            }
            else
            {
                btneliminardepartamento.Enabled = false;
            }
        }

        public void Guardar()
        {
            operacion oper = new operacion();
            if (tbDescripDepartamento.Text == "" || string.IsNullOrEmpty(tbDescripDepartamento.Text))
            {
                MessageBox.Show("La descripción no puede estar en blanco...", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (NuevoDepartamento)
                {

                    oper.ConsultaSinResultado("INSERT INTO departamento (descripcion_departamento) VALUES ('" + tbDescripDepartamento.Text.ToString().ToUpper() + "')");
                    MessageBox.Show("Departamento creado satisfactoriamente!", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoDepartamento = false;
                    Nuevo();
                }
                else
                {
                    oper.ConsultaSinResultado("UPDATE departamento SET descripcion_departamento ='" + tbDescripDepartamento.Text.ToString().ToUpper() + "' WHERE codigo_departamento = '" + tbCodigoDepartamento.Text.ToString() + "'");
                    MessageBox.Show("Datos actualizados correctamente!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoDepartamento = false;
                }
            }
        }

    }
}
