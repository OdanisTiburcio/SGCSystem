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

        public static bool NuevoSector = false;
        public static bool CrearNuevo = false;
        public static string SectorEditarID = "0";
        public static string SectorEditarDesc = "";

        public Sectores()
        {
            InitializeComponent();
        }

        private void btnguardarsector_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnactualizarsector_Click(object sender, EventArgs e)
        {
            Form f = new SeleccionarSector();
            f.ShowDialog();
            if (!NuevoSector)
            {
                tbcodigosector.Text = SectorEditarID;
                tbdescripsector.Text = SectorEditarDesc;
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

        private void btneliminarsector_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            if (!NuevoSector)
            {
                bool Eliminar = oper.CajaDeMensaje("¿Seguro que desea eliminar el sector: " + tbdescripsector.Text + "?", "Eliminar");
                if (Eliminar)
                {
                    if (tbcodigosector.Text == "")
                    {
                        MessageBox.Show("Favor digitar un código de sector válido!", "Aviso!");
                    }
                    else
                    {
                        bool EstaSiendoUsado = false;
                        DataSet ds = oper.ConsultaConResultado("SELECT codigo_sector FROM cliente;");
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() == tbcodigosector.Text)
                            {
                                EstaSiendoUsado = true;
                            }
                            else
                            {

                            }
                        }

                        ds = oper.ConsultaConResultado("SELECT codigo_sector FROM empleado;");
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() == tbcodigosector.Text)
                            {
                                EstaSiendoUsado = true;
                            }
                            else
                            {

                            }
                        }

                        if (EstaSiendoUsado)
                        {
                            MessageBox.Show("Este sector no se puede eliminar porque está siendo usado...", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            oper = new operacion();
                            oper.ConsultaSinResultado("DELETE FROM sector WHERE codigo_sector ='" + tbcodigosector.Text.ToString() + "'");
                            MessageBox.Show("Sector eliminado correctamente!");
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
                MessageBox.Show("Seleccione el sector que desea eliminar..." + Environment.NewLine + "Haga clic en el botón Editar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnimprimirsector_Click(object sender, EventArgs e)
        {

        }

        private void Sectores_Load(object sender, EventArgs e)
        {
            NuevoSector = true;
            Nuevo();
            if (MenuPrincipal.TipoUsuario == 1) 
            {
                btneliminarsector.Enabled = true;
            }
            else
            {
                btneliminarsector.Enabled = false;
            }
        }

        public void Nuevo()
        {
            operacion oper = new operacion();
            DataSet ds = new DataSet();

            ds = oper.ConsultaConResultado("SELECT MAX(codigo_sector) value FROM sector;");
            try
            {
                tbcodigosector.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                tbdescripsector.Clear();
                NuevoSector = true;
            }
            catch
            {
                MessageBox.Show("El código del nuevo servicio es erróneo...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tbdescripsector.Clear();

        }

        public void Guardar()
        {
            operacion oper = new operacion();
            if (tbdescripsector.Text == "" || string.IsNullOrEmpty(tbdescripsector.Text))
            {
                MessageBox.Show("La descripción no puede estar en blanco...", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (NuevoSector)
                {

                    oper.ConsultaSinResultado("INSERT INTO sector (descripcion_sector) VALUES ('" + tbdescripsector.Text.ToString().ToUpper() + "')");
                    MessageBox.Show("Sector creado satisfactoriamente!", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoSector = false;
                    Nuevo();
                }
                else
                {
                    oper.ConsultaSinResultado("UPDATE sector SET descripcion_sector ='" + tbdescripsector.Text.ToString().ToUpper() + "' WHERE codigo_sector = '" + tbcodigosector.Text.ToString() + "'");
                    MessageBox.Show("Datos actualizados correctamente!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoSector = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
