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
                MessageBox.Show("No seleccionó ningún servicio...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        void Cargar()
        {
            try
            {
                ds = oper.ConsultaConResultado("SELECT * FROM servicio WHERE codigo_servicio = '"+ MenuPrincipal.SeleccionDeServicio + "' AND estado = 'ACTIVO';;");
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el servicio seleccionado...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MantenimientoDeServicios_Load(object sender, EventArgs e)
        {
            ds = oper.ConsultaConResultado("SELECT MAX(codigo_servicio) value FROM servicio;");
            tbpcodigo.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void btnactualizarservicio_Click(object sender, EventArgs e)
        {
            oper.ConsultaSinResultado("UPDATE servicio SET descripcion_servicio = '" + tbpnombre.Text + "', precio_servicio = '" + tbpprecio.Text + "', dias = '" + tbdias.Text + "' WHERE codigo_servicio = '" + tbpcodigo.Text + "'");
        }

        public void Guardar()
        {
            if (tbpnombre.Text != "" && tbpprecio.Text != "" && tbdias.Text != "")
            {
                oper.ConsultaSinResultado("INSERT INTO servicio (descripcion_servicio, precio_servicio, dias, estado) VALUES ('" + tbpnombre.Text.ToString() + "','" + tbpprecio.Text + "','" + tbdias.Text + "', 'ACTIVO')");
                tbpnombre.Clear();
                tbpprecio.Clear();
                tbdias.Clear();
                tbpcodigo.Clear();
                MessageBox.Show("Datos registrados satisfactoriamente!");

                ds = oper.ConsultaConResultado("SELECT MAX(codigo_servicio) value FROM servicio;");
                tbpcodigo.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("Faltan datos, compléte todos los campos...");
            }
        }

        private void btpdelete_Click(object sender, EventArgs e)
        {
            oper.ConsultaSinResultado("UPDATE servicio SET estado = 'DESACTIVADO' WHERE codigo_servicio = '" + tbpcodigo.Text + "'");
        }

        public void Nuevo()
        {
            ds = oper.ConsultaConResultado("SELECT MAX(codigo_servicio) value FROM servicio;");
            tbpcodigo.Text = ds.Tables[0].Rows[0][0].ToString();

            tbpnombre.Text = "";
            tbpsearchcode.Text = "";
            tbdias.Text = "";
            tbpprecio.Text = "";
        }

        public void Buscar()
        {
            //ds = oper.ConsultaConResultado("SELECT * FROM servicio WHERE codigo_servicio = '"+btpsearch.ResetText+"';")

        }
    }
}
