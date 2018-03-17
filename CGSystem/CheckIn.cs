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
            btnguardar.Select();
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
                if (FinPeriodoCliente < Hoy)
                {
                    //Vencido
                    rdbinactivo.Checked = true;
                    rdbactivo.Checked = false;
                    tbrestante.Text = "Servicio Vencido";
                    tbrestante.BackColor = Color.Yellow;

                }
                else
                {
                    //Vigente
                    rdbactivo.Checked = true;
                    rdbinactivo.Checked = false;

                    //Mostrar el tiempo de servicio restante...
                    string tiemporestante = "";
                    int diasrestantes = ((FinPeriodoCliente - Hoy).Days)+1;
                    int mesesretantes = 0;
                    int añosrestantes = 0;

                    string años = "";
                    string meses = "";
                    string dias = "";

                    while (diasrestantes >= 365)
                    {
                        diasrestantes -= 365;
                        añosrestantes++;
                    }

                    while (diasrestantes >= 30)
                    {
                        diasrestantes -= 30;
                        mesesretantes++;
                    }

                    if (añosrestantes != 0) //Formatear los años
                    {
                        if (añosrestantes > 1)
                        {
                            años = añosrestantes.ToString() + " años, ";
                        }
                        else
                        {
                            años = añosrestantes.ToString() + " año, ";
                        }

                    }
                    else
                    {
                        años = "";
                    }

                    if (mesesretantes != 0) //Formatear los meses
                    {
                        if (mesesretantes > 1)
                        {
                            meses = mesesretantes.ToString() + " meses ";
                        }
                        else
                        {
                            meses = mesesretantes.ToString() + " mes ";
                        }

                    }
                    else
                    {
                        meses = "";
                    }

                    if (diasrestantes != 0) //Formatear los días
                    {
                        if (diasrestantes > 1)
                        {
                            if (años != "" || meses != "")
                            {
                                dias = "y " + diasrestantes.ToString() + " días";
                            }
                            else
                            {
                                dias = diasrestantes.ToString() + " días";
                            }
                        }
                        else
                        {
                            if (años != "" || meses != "")
                            {
                                dias = "y " + diasrestantes.ToString() + " día";
                            }
                            else
                            {
                                dias = diasrestantes.ToString() + " día";
                            }
                        }

                    }
                    else
                    {
                        dias = "";
                        if (años != "" && meses != "")
                        {
                            años = añosrestantes.ToString() + " años ";
                            meses = "y " + mesesretantes.ToString() + " meses";
                        }
                    }

                    tiemporestante = años + meses + dias;

                    tbrestante.Text = tiemporestante;
                    tbrestante.BackColor = Color.LightBlue;
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
