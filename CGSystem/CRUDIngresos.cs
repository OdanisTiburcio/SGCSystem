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
                //string seleccion = cbTipoBusqueda.SelectedItem.ToString();
                operacion oper = new operacion();
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
                cnx.Open();
                if (rbtodosingresos.Checked)
                {
                    string consulta = "SELECT codigo_ingreso,codigo_tipo_ingreso,numero_factura,monto_ingreso FROM ingreso";
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
                    string consulta = "SELECT codigo_ingreso,codigo_tipo_ingreso,numero_factura,monto_ingreso FROM ingreso WHERE codigo_ingreso = '" + tbseleccion.Text + "'";
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
                    string consulta = "SELECT codigo_ingreso,codigo_tipo_ingreso,numero_factura,monto_ingreso FROM ingreso WHERE numero_factura = '" + tbseleccion.Text + "'";
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
                    string consulta = "SELECT codigo_ingreso,codigo_tipo_ingreso,numero_factura,monto_ingreso, fecha FROM ingreso WHERE fecha BETWEEN '" + dtpIngresodesde.Text + "' AND '" + dtpIngresohasta + "'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dgvdetalleingresos.DataSource = dt;
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
