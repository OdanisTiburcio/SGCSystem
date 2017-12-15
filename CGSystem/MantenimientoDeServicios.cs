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
        operacion oper = new operacion();
        public MantenimientoDeServicios()
        {
            InitializeComponent();
        }

        private void btpnew_Click(object sender, EventArgs e)
        {
            if (tbpnombre.Text != "" && tbpprecio.Text != "" && tbdias.Text != "")
            {
                oper.ConsultaSinResultado("INSERT INTO servicio (descripcion_servicio, precio_servicio, dias) VALUES ('" + tbpnombre.Text.ToString() + "','" + tbpprecio.Text + "','" + tbdias.Text + "')");
                tbpnombre.Clear();
                tbpprecio.Clear();
                tbdias.Clear();
                tbpcodigo.Clear();
                MessageBox.Show("Datos registrados satisfactoriamente!");
            }
            else
            {
                MessageBox.Show("Faltan datos por registrar! ");
            }
        }

        private void btpsearch_Click(object sender, EventArgs e)
        {

        }
    }
}
