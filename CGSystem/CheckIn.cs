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
    public partial class CheckIn : Form
    {
        DataSet ds = new DataSet();
        operacion oper = new operacion();

        //Variables necesarias
        public static string IdEmpleado = "0";

        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {
            //Buscar un empleado mostrando el formulario de selección de cliente...
            Form f = new SeleccionarCliente();
            f.ShowDialog();
            Actualizar();
        }

        public void Actualizar()
        {
            try
            {
                //Actualizar el formulario de CheckIn con el empleado seleccionado
                string id = MenuPrincipal.SelecciónDeCliente;
                tbid.Text = id;
                ds = oper.ConsultaConResultado("SELECT cliente.nombre_cliente, cliente.apellido_cliente, cliente.cedula_cliente, cliente.fin_periodo, cliente.foto FROM cliente WHERE cliente.numero_cliente = '" + id + "';");
                tbnombre.Text = ds.Tables[0].Rows[0][0].ToString();
                tbapellidos.Text = ds.Tables[0].Rows[0][1].ToString();
                tbcedula.Text = ds.Tables[0].Rows[0][2].ToString();
                string fechafinperiodo = ds.Tables[0].Rows[0][3].ToString();
                DateTime FinPeriodoCliente = Convert.ToDateTime(fechafinperiodo);

                //Mostrar la imagen del cliente
                string RutaFoto = ds.Tables[0].Rows[0][4].ToString();
                //ptbfotoempleado.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap Foto = new Bitmap(RutaFoto);
                ptbfotoempleado.Image = Foto;

                //Establecer si está vencido o no...
                DateTime Hoy = DateTime.Now;
                if(FinPeriodoCliente < Hoy)
                {
                    //Vencido
                    rdbinactivo.Checked = true;
                    rdbactivo.Checked = false;
                }
                else
                {
                    //Vigente
                    rdbactivo.Checked = true;
                    rdbinactivo.Checked = false;
                }

            }
            catch
            {
                MessageBox.Show("No seleccionó ningún cliente...");
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
