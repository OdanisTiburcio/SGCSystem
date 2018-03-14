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
    public partial class Ciudades : Form
    {

        public static bool NuevaCiudad = false;
        public static bool CrearNuevo = false;
        public static string CiudadEditarID = "0";
        public static string CiudadEditarDesc = "";

        public Ciudades()
        {
            InitializeComponent();
        }

        private void Ciudades_Load(object sender, EventArgs e)
        {
            NuevaCiudad = true;
            Nuevo();
            if (MenuPrincipal.TipoUsuario == 1)
            {
                btneliminarciudad.Enabled = true;
            }
            else
            {
                btneliminarciudad.Enabled = false;
            }
        }

        private void btnguardarciudad_Click_1(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btneditarciudad_Click(object sender, EventArgs e)
        {
            Form f = new SeleccionarCiudad();
            f.ShowDialog();
            if (!NuevaCiudad)
            {
                tbcodigociudad.Text = CiudadEditarID;
                tbdescripciudad.Text = CiudadEditarDesc;
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

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btneliminarciudad_Click_1(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            if (!NuevaCiudad)
            {
                bool Eliminar = oper.CajaDeMensaje("¿Seguro que desea eliminar la ciudad: " + tbdescripciudad.Text + "?", "Eliminar");
                if (Eliminar)
                {
                    if (tbcodigociudad.Text == "")
                    {
                        MessageBox.Show("Favor seleccionar un código de ciudad válido!", "Aviso!");
                    }
                    else
                    {
                        bool EstaSiendoUsado = false;
                        DataSet ds = oper.ConsultaConResultado("SELECT codigo_ciudad FROM cliente;");
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() == tbcodigociudad.Text)
                            {
                                EstaSiendoUsado = true;
                            }
                            else
                            {

                            }
                        }

                        ds = oper.ConsultaConResultado("SELECT codigo_ciudad FROM empleado;");
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() == tbcodigociudad.Text)
                            {
                                EstaSiendoUsado = true;
                            }
                            else
                            {

                            }
                        }

                        if (EstaSiendoUsado)
                        {
                            MessageBox.Show("Esta ciudad no se puede eliminar porque está siendo usada...", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            oper = new operacion();
                            oper.ConsultaSinResultado("DELETE FROM ciudad WHERE codigo_ciudad ='" + tbcodigociudad.Text.ToString() + "'");
                            MessageBox.Show("Ciudad eliminada correctamente!");
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
                MessageBox.Show("Seleccione la ciudad que desea eliminar..." + Environment.NewLine + "Haga clic en el botón Editar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Guardar()
        {
            operacion oper = new operacion();
            if (tbdescripciudad.Text == "" || string.IsNullOrEmpty(tbdescripciudad.Text))
            {
                MessageBox.Show("La descripción no puede estar en blanco...", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (NuevaCiudad)
                {

                    oper.ConsultaSinResultado("INSERT INTO ciudad (descripcion_ciudad) VALUES ('" + tbdescripciudad.Text.ToString().ToUpper() + "')");
                    MessageBox.Show("Ciudad creada satisfactoriamente!", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevaCiudad = false;
                    Nuevo();
                }
                else
                {
                    oper.ConsultaSinResultado("UPDATE ciudad SET descripcion_ciudad ='" + tbdescripciudad.Text.ToString().ToUpper() + "' WHERE codigo_ciudad = '" + tbcodigociudad.Text.ToString() + "'");
                    MessageBox.Show("Datos actualizados correctamente!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevaCiudad = false;
                }
            }
        }

        public void Nuevo()
        {
            operacion oper = new operacion();
            DataSet ds = new DataSet();

            ds = oper.ConsultaConResultado("SELECT MAX(codigo_ciudad) value FROM ciudad;");
            try
            {
                tbcodigociudad.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                tbdescripciudad.Clear();
                NuevaCiudad = true;
            }
            catch
            {
                MessageBox.Show("El código de la nueva ciudad...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tbdescripciudad.Clear();

        }

    }
}
