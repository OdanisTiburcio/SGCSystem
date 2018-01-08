using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data.SQLite;
using CrystalDecisions.CrystalReports.Engine;
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
        public static string fechamesuno;
        public static string fechamesdos;
        public bool BuscandoHoy = false;
        public bool Iniciando = true; //Para no mostrar nada al principio...


        public CuadreCaja()
        {
            InitializeComponent();
        }

        private void CuadreCaja_Load(object sender, EventArgs e)
        {
            Iniciando = true;
            //MostrarUltimoMes();
            cbmescuadre.Text = cbmescuadre.Items[(DateTime.Now.Month)].ToString(); //Asignar el mes actual al Combobox
            Iniciando = false;
        }

        public void MostrarHoy()
        {
            BuscandoHoy = true;
            DateTime fechaDT = DateTime.Now;//Para tomar la fecha de hoy, formatearla y luego hacer el filtro correcto...
            string fechaHoy = oper.FormatearFecha(fechaDT);

            //Para reiniciar los totales
            TotalContado = 0;
            TotalCredito = 0;

            dtvcuadrecaja.Rows.Clear();
            dtvcuadrecaja.Refresh();

            //Cargar la Tabla con todas las facturas activas
            ds = oper.ConsultaConResultado("SELECT c.id_factura, c.id_tipo_factura, t.descripcion_tipo_factura, c.total FROM cabecera_factura c INNER JOIN tipo_factura t ON c.id_tipo_factura = t.codigo_tipo_factura WHERE fecha BETWEEN '" + fechaHoy + "' AND '" + fechaHoy + "' AND estado = 'ACTIVO';");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                dtvcuadrecaja.Rows.Add();
                for (int k = 0; k < 4; k++)
                {
                    dtvcuadrecaja.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                }
                if (Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[1].Value) == 1)//Al Contado
                {
                    TotalContado += Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[3].Value);
                }
                else
                {
                    TotalCredito += Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[3].Value);
                }

                //Pasar Valores a los TextBox
                tbventacontado.Text = "RD$ " + TotalContado.ToString();
                tbventacredito.Text = "RD$ " + TotalCredito.ToString();
                tbtotal.Text = "RD$ " + (TotalContado + TotalCredito).ToString();

            }

        }

        public void Mostrarrango()
        {
            BuscandoHoy = false;
            dtvcuadrecaja.Rows.Clear();
            dtvcuadrecaja.Refresh();
            TotalContado = 0;
            TotalCredito = 0;

            if (cbmescuadre.Text != "Rango...")
            {
                MostrarUltimoMes();
            }
            else
            {
                DateTime desde = dtpinicio.Value;
                DateTime hasta = dtpfin.Value;
                string fechadesde = oper.FormatearFecha(desde);
                string fechahasta = oper.FormatearFecha(hasta);

                ds = oper.ConsultaConResultado("SELECT c.id_factura, c.id_tipo_factura, t.descripcion_tipo_factura, c.total FROM cabecera_factura c INNER JOIN tipo_factura t ON c.id_tipo_factura = t.codigo_tipo_factura WHERE fecha BETWEEN '" + fechadesde + "' AND '" + fechahasta + "' AND estado = 'ACTIVO';");

                //Rellenar el Data Grid...
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dtvcuadrecaja.Rows.Add();
                    for (int k = 0; k < 4; k++)
                    {
                        dtvcuadrecaja.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                    }
                    if (Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[1].Value) == 1)//Al Contado
                    {
                        TotalContado += Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[3].Value);
                    }
                    else
                    {
                        TotalCredito += Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[3].Value);
                    }
                }
                //Pasar Valores a los TextBox
                tbventacontado.Text = "RD$ " + TotalContado.ToString();
                tbventacredito.Text = "RD$ " + TotalCredito.ToString();
                tbtotal.Text = "RD$ " + (TotalContado + TotalCredito).ToString();
            }

        }

        public void MostrarUltimoMes()
        {
            BuscandoHoy = false;
            DateTime fechaDT = DateTime.Now;//Para tomar la fecha de hoy, formatearla y luego hacer el filtro correcto...

            if ((cbmescuadre.SelectedIndex) < 10)
            {
                fechamesuno = fechaDT.Year.ToString() + "-" + "0" + (cbmescuadre.SelectedIndex).ToString() + "-01";
                fechamesdos = fechaDT.Year.ToString() + "-" + "0" + (cbmescuadre.SelectedIndex).ToString() + "-31";
            }
            else
            {
                fechamesuno = fechaDT.Year.ToString() + "-" + (cbmescuadre.SelectedIndex).ToString() + "-01";
                fechamesdos = fechaDT.Year.ToString() + "-" + (cbmescuadre.SelectedIndex).ToString() + "-31";
            }

            TotalContado = 0;//Para Contar los totales
            TotalCredito = 0;

            dtvcuadrecaja.Rows.Clear();
            //Cargar la Tabla de todos los clientes activos
            ds = oper.ConsultaConResultado("SELECT c.id_factura, c.id_tipo_factura, t.descripcion_tipo_factura, c.total FROM cabecera_factura c INNER JOIN tipo_factura t ON c.id_tipo_factura = t.codigo_tipo_factura WHERE fecha BETWEEN '" + fechamesuno + "' AND '" + fechamesdos + "' AND estado = 'ACTIVO';");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                dtvcuadrecaja.Rows.Add();
                for (int k = 0; k < 4; k++)
                {
                    dtvcuadrecaja.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                }
                if (Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[1].Value) == 1)//Al Contado
                {
                    TotalContado += Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[3].Value);
                }
                else
                {
                    TotalCredito += Convert.ToInt32(dtvcuadrecaja.Rows[i].Cells[3].Value);
                }

                //Pasar Valores a los TextBox
                tbventacontado.Text = "RD$ " + TotalContado.ToString();
                tbventacredito.Text = "RD$ " + TotalCredito.ToString();
                tbtotal.Text = "RD$ " + (TotalContado + TotalCredito).ToString();

            }

        }

        private void btncuadrehoy_Click(object sender, EventArgs e)
        {
            MostrarHoy();
        }

        private void btncuadremes_Click(object sender, EventArgs e)
        {
            //MostrarUltimoMes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mostrarrango();
        }

        private void pbimprimircuadre_Click(object sender, EventArgs e)
        {

            if (dtvcuadrecaja.Rows.Count < 1)
            {
                MessageBox.Show("No hay nada para imprimir", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //Continua
            }

            try
            {

                DateTime FechaCuadre1 = dtpinicio.Value;
                DateTime FechaCuadre2 = dtpfin.Value;
                string fechaini = oper.FormatearFecha(FechaCuadre1);
                string fechafin = oper.FormatearFecha(FechaCuadre2);
                string fecharango = fechaini + " / " + fechafin; //Colocar ambas fechas en un string
                DataSet dsxml = new DataSet();
                dsxml.Tables.Add();
                dsxml.Tables[0].Rows.Add();

                if (BuscandoHoy)
                {
                    BuscandoHoy = true;
                    DateTime fechaDT = DateTime.Now;//Para tomar la fecha de hoy, formatearla y luego hacer el filtro correcto...
                    string fechaHoy = oper.FormatearFecha(fechaDT);

                    dsxml.Tables[0].Columns.Add();
                    dsxml.Tables[0].Columns.Add();
                    dsxml.Tables[0].Columns.Add();
                    dsxml.Tables[0].Columns.Add();
                    dsxml.Tables[0].Rows[0][0] = fechaHoy;
                    dsxml.Tables[0].Rows[0][1] = TotalContado.ToString();
                    dsxml.Tables[0].Rows[0][2] = TotalCredito.ToString();
                    dsxml.Tables[0].Rows[0][3] = tbtotal.Text;
                    dsxml.WriteXml("C:\\CGSystem\\CGSystem\\DatosCuadre.xml");

                    dtvcuadrecaja.Rows.Clear();
                    //Cargar la Tabla de todos los clientes activos
                    ds = oper.ConsultaConResultado("SELECT c.id_factura, c.id_tipo_factura, t.descripcion_tipo_factura, c.total FROM cabecera_factura c INNER JOIN tipo_factura t ON c.id_tipo_factura = t.codigo_tipo_factura WHERE fecha BETWEEN '" + fechaHoy + "' AND '" + fechaHoy + "' AND estado = 'ACTIVO';");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\CuadreCaja.xml");
                    Form f = new VisorReportes("Reporte de Cuadre.rpt");
                    f.ShowDialog();
                }
                else
                {
                    if (cbmescuadre.Text != "Rango...")
                    {
                        //Imprimir busqueda por mes...
                        dsxml.Tables[0].Columns.Add();
                        dsxml.Tables[0].Columns.Add();
                        dsxml.Tables[0].Columns.Add();
                        dsxml.Tables[0].Columns.Add();
                        dsxml.Tables[0].Rows[0][0] = cbmescuadre.Text + " del " + DateTime.Now.Year.ToString();
                        dsxml.Tables[0].Rows[0][1] = TotalContado.ToString();
                        dsxml.Tables[0].Rows[0][2] = TotalCredito.ToString();
                        dsxml.Tables[0].Rows[0][3] = tbtotal.Text;
                        dsxml.WriteXml("C:\\CGSystem\\CGSystem\\DatosCuadre.xml");

                        ds = oper.ConsultaConResultado("SELECT c.id_factura, c.id_tipo_factura, t.descripcion_tipo_factura, c.total FROM cabecera_factura c INNER JOIN tipo_factura t ON c.id_tipo_factura = t.codigo_tipo_factura WHERE fecha BETWEEN '" + fechamesuno + "' AND '" + fechamesdos + "' AND estado = 'ACTIVO';");
                        ds.WriteXml("C:\\CGSystem\\CGSystem\\CuadreCaja.xml");
                        Form f = new VisorReportes("Reporte de Cuadre.rpt");
                        f.ShowDialog();
                    }
                    else
                    {
                        //Imprimir busqueda por rango...
                        dsxml.Tables[0].Columns.Add();
                        dsxml.Tables[0].Columns.Add();
                        dsxml.Tables[0].Columns.Add();
                        dsxml.Tables[0].Columns.Add();
                        dsxml.Tables[0].Rows[0][0] = fecharango;
                        dsxml.Tables[0].Rows[0][1] = TotalContado.ToString();
                        dsxml.Tables[0].Rows[0][2] = TotalCredito.ToString();
                        dsxml.Tables[0].Rows[0][3] = tbtotal.Text;
                        dsxml.WriteXml("C:\\CGSystem\\CGSystem\\DatosCuadre.xml");

                        DateTime desde = dtpinicio.Value;
                        DateTime hasta = dtpfin.Value;
                        string fechadesde = oper.FormatearFecha(dtpinicio.Value);
                        string fechahasta = oper.FormatearFecha(dtpfin.Value);
                        DataSet ds = oper.ConsultaConResultado("SELECT c.id_factura, c.id_tipo_factura, t.descripcion_tipo_factura, c.total FROM cabecera_factura c INNER JOIN tipo_factura t ON c.id_tipo_factura = t.codigo_tipo_factura WHERE fecha BETWEEN '" + fechadesde + "' AND '" + fechahasta + "' AND estado = 'ACTIVO';");
                        ds.WriteXml("C:\\CGSystem\\CGSystem\\CuadreCaja.xml");
                        Form f = new VisorReportes("Reporte de Cuadre.rpt");
                        f.ShowDialog();
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error al tratar de imprimir, reinicie el formulario de cuadre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void cbmescuadre_TextChanged(object sender, EventArgs e)
        {
            if (!Iniciando)
            {
                if (cbmescuadre.Text == "Rango")
                {
                    Mostrarrango();
                }
                else
                {
                    MostrarUltimoMes();
                }
            }
            else { }
        }

        private void dtpinicio_ValueChanged(object sender, EventArgs e)
        {
            Mostrarrango();
        }

        private void dtpfin_ValueChanged(object sender, EventArgs e)
        {
            Mostrarrango();
        }
    }
}
