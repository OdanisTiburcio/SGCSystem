using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class CRUDIngresos : Form
    {
        operacion oper = new operacion();
        public CRUDIngresos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btbuscaringreso_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
                cnx.Open();
                if (rbtodosingresos.Checked)
                {
                    string consulta = "SELECT ing.codigo_ingreso Código, tip.descripcion_tipo_ingreso Tipo, cab.id_factura No_Factura, ing.monto_ingreso Monto, ing.fecha Fecha FROM ingreso ing INNER JOIN tipo_ingreso tip ON tip.codigo_tipo_ingreso = ing.codigo_tipo_ingreso INNER JOIN cabecera_factura cab ON cab.id_factura = ing.numero_factura WHERE ing.estado = 'ACTIVO'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dgvdetalleingresos.DataSource = dt;
                    cnx.Close();
                }
                else if (rbcodigoingreso.Checked)
                {
                    string consulta = "SELECT ing.codigo_ingreso Código, tip.descripcion_tipo_ingreso Tipo, cab.id_factura No_Factura, ing.monto_ingreso Monto, ing.fecha Fecha FROM ingreso ing INNER JOIN tipo_ingreso tip ON tip.codigo_tipo_ingreso = ing.codigo_tipo_ingreso INNER JOIN cabecera_factura cab ON cab.id_factura = ing.numero_factura WHERE ing.codigo_ingreso = '" + tbseleccion.Text + "' AND ing.estado = 'ACTIVO'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dgvdetalleingresos.DataSource = dt;
                    cnx.Close();
                }
                else if (rbnumerofact.Checked)
                {
                    string consulta = "SELECT ing.codigo_ingreso Código, tip.descripcion_tipo_ingreso Tipo, cab.id_factura No_Factura, ing.monto_ingreso Monto, ing.fecha Fecha FROM ingreso ing INNER JOIN tipo_ingreso tip ON tip.codigo_tipo_ingreso = ing.codigo_tipo_ingreso INNER JOIN cabecera_factura cab ON cab.id_factura = ing.numero_factura WHERE ing.numero_factura = '" + tbseleccion.Text + "' AND ing.estado = 'ACTIVO'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dgvdetalleingresos.DataSource = dt;
                    cnx.Close();
                }
                else
                {
                    DateTime desde = dtpIngresodesde.Value;
                    DateTime hasta = dtpIngresohasta.Value;
                    string fechadesde = oper.FormatearFecha(dtpIngresodesde.Value);
                    string fechahasta = oper.FormatearFecha(dtpIngresohasta.Value);
                    try
                    {
                        string consulta = "SELECT ing.codigo_ingreso Código, tip.descripcion_tipo_ingreso Tipo, cab.id_factura No_Factura, ing.monto_ingreso Monto, ing.fecha Fecha FROM ingreso ing INNER JOIN tipo_ingreso tip ON tip.codigo_tipo_ingreso = ing.codigo_tipo_ingreso INNER JOIN cabecera_factura cab ON cab.id_factura = ing.numero_factura WHERE ing.fecha BETWEEN '" + desde + "' AND '" + hasta + "'";
                        SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                        DataSet ds = new DataSet();
                        ds.Reset();
                        DataTable dt = new DataTable();
                        db.Fill(ds);
                        dt = ds.Tables[0];
                        dgvdetalleingresos.DataSource = dt;
                        cnx.Close();
                    }
                    catch (Exception ex) { }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void bntimprimiringreso_Click(object sender, EventArgs e)
        {

        }

        private void CRUDIngresos_Load(object sender, EventArgs e)
        {
            dtpIngresodesde.Value = DateTime.Today;
            dtpIngresohasta.Value = DateTime.Today;
        }
    }
}
