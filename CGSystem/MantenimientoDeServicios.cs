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
    public partial class MantenimientoDeServicios : Form
    {
        DataSet ds = new DataSet();
        operacion oper = new operacion();
        public bool NuevoServicio = false;

        public MantenimientoDeServicios()
        {
            InitializeComponent();
        }

        private void btpnew_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btpsearch_Click(object sender, EventArgs e)
        {
            Form f = new SeleccionarServicio();
            f.ShowDialog();
            if (MenuPrincipal.SeleccionDeServicio != "0")
            {
                Cargar();
            }
            else
            {
                //MessageBox.Show("No seleccionó ningún servicio...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void Cargar()
        {
            try
            {
                ds = oper.ConsultaConResultado("SELECT * FROM servicio WHERE codigo_servicio = '" + MenuPrincipal.SeleccionDeServicio + "' AND estado = 'ACTIVO';");
                tbpcodigo.Text = ds.Tables[0].Rows[0][0].ToString();
                tbpnombre.Text = ds.Tables[0].Rows[0][1].ToString();
                tbpprecio.Text = ds.Tables[0].Rows[0][2].ToString();
                tbdias.Text = ds.Tables[0].Rows[0][3].ToString();
                NuevoServicio = false;
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el servicio seleccionado...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MantenimientoDeServicios_Load(object sender, EventArgs e)
        {
            //ds = oper.ConsultaConResultado("SELECT MAX(codigo_servicio) value FROM servicio;");
            //tbpcodigo.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
            NuevoServicio = true;
            Nuevo();
        }

        private void btnactualizarservicio_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar()
        {

            if (tbpnombre.Text != "" && tbpprecio.Text != "" && tbdias.Text != "")
            {
                bool PrecioEsNumero = oper.ValidarNumero(tbpprecio.Text);
                bool DiasEsNumero = oper.ValidarNumero(tbdias.Text);

                if (PrecioEsNumero)
                {
                    if (DiasEsNumero)
                    {
                        //Continuar
                    }else
                    {
                        //Los días insertados no representan una cantidad numérica válida
                        MessageBox.Show("Los días insertados no representan una cantidad numérica válida...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbdias.Focus();
                        tbdias.Select();
                        return;
                    }
                }else
                {
                    //Los días insertados no representan una cantidad numérica válida
                    MessageBox.Show("El precio insertado no representa una cantidad numérica válida...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbpprecio.Focus();
                    tbpprecio.Select();
                    return;
                }

                if (NuevoServicio)
                {
                    oper.ConsultaSinResultado("INSERT INTO servicio (descripcion_servicio, precio_servicio, dias, estado) VALUES ('" + tbpnombre.Text.ToUpper() + "','" + tbpprecio.Text + "','" + tbdias.Text + "', 'ACTIVO')");
                    tbpnombre.Clear();
                    tbpprecio.Clear();
                    tbdias.Clear();
                    tbpcodigo.Clear();
                    MessageBox.Show("Datos registrados satisfactoriamente!");

                    Nuevo();
                }
                else
                {
                    oper.ConsultaSinResultado("UPDATE servicio SET descripcion_servicio = '" + tbpnombre.Text + "', precio_servicio = '" + tbpprecio.Text + "', dias = '" + tbdias.Text + "' WHERE codigo_servicio = '" + tbpcodigo.Text + "'");
                    MessageBox.Show("Se guardaron los cambios satisfactoriamente!...", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos, complete todos los campos...");
            }
        }

        private void btpdelete_Click(object sender, EventArgs e)
        {
            if (tbpcodigo.Text != "1")
            {
                bool Eliminar = oper.CajaDeMensaje("¿Seguro que quiere eliminar este servicio?", "Aviso");
                if (Eliminar)
                {
                    oper.ConsultaSinResultado("UPDATE servicio SET estado = 'DESACTIVADO' WHERE codigo_servicio = '" + tbpcodigo.Text + "'");
                    MessageBox.Show("Se eliminó el servicio correctamente...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevo();
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("No puede eliminar este servicio, ya que es utilizado para la facturación rápida...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Nuevo()
        {
            ds = oper.ConsultaConResultado("SELECT MAX(codigo_servicio) value FROM servicio;");
            try
            {
                tbpcodigo.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
            }
            catch
            {
                MessageBox.Show("El código del nuevo servicio es erróneo...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            tbpnombre.Text = "";
            tbpsearchcode.Text = "";
            tbdias.Text = "";
            tbpprecio.Text = "";
            NuevoServicio = true;
        }

    }
}
