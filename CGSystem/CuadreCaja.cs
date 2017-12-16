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
    public partial class CuadreCaja : Form
    {
        //Clases y Variables Reutilizables
        operacion oper = new operacion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public int TotalContado = 0;
        public int TotalCredito = 0;

        public CuadreCaja()
        {
            InitializeComponent();
        }

        private void CuadreCaja_Load(object sender, EventArgs e)
        {
            MostrarHoy();
            cbmescuadre.Text = cbmescuadre.Items[(DateTime.Now.Month - 1)].ToString(); //Asignar el mes actual al Combobox
        }

        public void MostrarHoy()
        {
            DateTime fechaDT = DateTime.Now;//Para tomar la fecha de hoy, formatearla y luego hacer el filtro correcto...
            string fechaHoy = oper.FormatearFecha(fechaDT);

            TotalContado = 0;//Para Contar los totales
            TotalCredito = 0;

            dtvcuadrecaja.Rows.Clear();
            //Cargar la Tabla de todos los clientes activos
            ds = oper.ConsultaConResultado("SELECT id_factura, id_tipo_factura, total FROM cabecera_factura WHERE fecha between '" + fechaHoy + "' AND '" + fechaHoy + "';");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                dtvcuadrecaja.Rows.Add();
                for (int k = 0; k < 3; k++)
                {
                    dtvcuadrecaja.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                }
                if(Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[1].Value) == 1)//Al Contado
                {
                    TotalContado += Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[2].Value);
                }
                else
                {
                    TotalCredito += Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[2].Value);
                }

                //Pasar Valores a los TextBox
                tbventacontado.Text = "RD$ " + TotalContado.ToString();
                tbventacredito.Text = "RD$ " + TotalCredito.ToString();

            }

        }

        public void MostrarUltimoMes()
        {
            DateTime fechaDT = DateTime.Now;//Para tomar la fecha de hoy, formatearla y luego hacer el filtro correcto...
            string fechamesuno;
            string fechamesdos;

            if ((cbmescuadre.SelectedIndex + 1) < 10)
            {
                fechamesuno = fechaDT.Year.ToString() + "-" + "0"+(cbmescuadre.SelectedIndex + 1).ToString() + "-01";
                fechamesdos = fechaDT.Year.ToString() + "-" + "0"+(cbmescuadre.SelectedIndex + 1).ToString() + "-31";
            }
            else
            {
                fechamesuno = fechaDT.Year.ToString() + "-" + (cbmescuadre.SelectedIndex + 1).ToString() + "-01";
                fechamesdos = fechaDT.Year.ToString() + "-" + (cbmescuadre.SelectedIndex + 1).ToString() + "-31";
            }

            TotalContado = 0;//Para Contar los totales
            TotalCredito = 0;

            dtvcuadrecaja.Rows.Clear();
            //Cargar la Tabla de todos los clientes activos
            ds = oper.ConsultaConResultado("SELECT id_factura, id_tipo_factura, total FROM cabecera_factura WHERE fecha between '" + fechamesuno + "' AND '" + fechamesdos + "';");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                dtvcuadrecaja.Rows.Add();
                for (int k = 0; k < 3; k++)
                {
                    dtvcuadrecaja.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                }
                if (Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[1].Value) == 1)//Al Contado
                {
                    TotalContado += Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[2].Value);
                }
                else
                {
                    TotalCredito += Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[2].Value);
                }

                //Pasar Valores a los TextBox
                tbventacontado.Text = "RD$ " + TotalContado.ToString();
                tbventacredito.Text = "RD$ " + TotalCredito.ToString();

            }

        }

        private void btncuadrehoy_Click(object sender, EventArgs e)
        {
            MostrarHoy();
        }

        private void btncuadremes_Click(object sender, EventArgs e)
        {
            MostrarUltimoMes();
        }
    }
}
