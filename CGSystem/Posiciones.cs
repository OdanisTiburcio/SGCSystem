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
    public partial class Posiciones : Form
    {

        public static bool NuevaPosicion = false;
        public static bool CrearNuevo = false;
        public static string PosicionEditarID = "0";
        public static string PosicionEditarDesc = "";

        public Posiciones()
        {
            InitializeComponent();
        }

        private void Posiciones_Load(object sender, EventArgs e)
        {
            NuevaPosicion = true;
            Nuevo();
            if (MenuPrincipal.TipoUsuario == 1)
            {
                btneliminarposi.Enabled = true;
            }
            else
            {
                btneliminarposi.Enabled = false;
            }
        }

        public void Nuevo()
        {
            operacion oper = new operacion();
            DataSet ds = new DataSet();

            ds = oper.ConsultaConResultado("SELECT MAX(codigo_posicion) value FROM posicion;");
            try
            {
                tbcodigoposicion.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                tbdescripposición.Clear();
                NuevaPosicion = true;
            }
            catch
            {
                MessageBox.Show("El código del nuevo servicio es erróneo...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tbdescripposición.Clear();

        }

        private void btnguardarposi_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar()
        {
            operacion oper = new operacion();
            if (tbdescripposición.Text == "" || string.IsNullOrEmpty(tbdescripposición.Text))
            {
                MessageBox.Show("La descripción no puede estar en blanco...", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (NuevaPosicion)
                {

                    oper.ConsultaSinResultado("INSERT INTO posicion (descripcion_posicion) VALUES ('" + tbdescripposición.Text.ToString().ToUpper() + "')");
                    MessageBox.Show("Posición creada satisfactoriamente!", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevaPosicion = false;
                    Nuevo();
                }
                else
                {
                    oper.ConsultaSinResultado("UPDATE posicion SET descripcion_posicion ='" + tbdescripposición.Text.ToString().ToUpper() + "' WHERE codigo_posicion = '" + tbcodigoposicion.Text.ToString() + "'");
                    MessageBox.Show("Datos actualizados correctamente!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevaPosicion = false;
                }
            }
        }

        private void btneliminarposi_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            if (!NuevaPosicion)
            {
                bool Eliminar = oper.CajaDeMensaje("¿Seguro que desea eliminar el sector: " + tbdescripposición.Text + "?", "Eliminar");
                if (Eliminar)
                {
                    if (tbcodigoposicion.Text == "")
                    {
                        MessageBox.Show("Favor seleccionar un código de posicion válido!", "Aviso!");
                    }
                    else
                    {
                        bool EstaSiendoUsado = false;
                        DataSet ds = oper.ConsultaConResultado("SELECT codigo_posicion FROM cliente;");
                        //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        //{
                        //    if (ds.Tables[0].Rows[0][0].ToString() == tbcodigoposicion.Text)
                        //    {
                        //        EstaSiendoUsado = true;
                        //    }
                        //    else
                        //    {

                        //    }
                        //}

                        ds = oper.ConsultaConResultado("SELECT codigo_posicion FROM empleado;");
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() == tbcodigoposicion.Text)
                            {
                                EstaSiendoUsado = true;
                            }
                            else
                            {

                            }
                        }

                        if (EstaSiendoUsado)
                        {
                            MessageBox.Show("Esta posición no se puede eliminar porque está siendo usada...", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            oper = new operacion();
                            oper.ConsultaSinResultado("DELETE FROM posicion WHERE codigo_posicion ='" + tbcodigoposicion.Text.ToString() + "'");
                            MessageBox.Show("Posición eliminada correctamente!");
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

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btneditarposi_Click(object sender, EventArgs e)
        {
            Form f = new SeleccionarPosicion();
            f.ShowDialog();
            if (!NuevaPosicion)
            {
                tbcodigoposicion.Text = PosicionEditarID;
                tbdescripposición.Text = PosicionEditarDesc;
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
    }
}
