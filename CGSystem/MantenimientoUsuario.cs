using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class MantenimientoUsuario : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        operacion oper = new operacion();
        SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
   
        public MantenimientoUsuario()
        {
            InitializeComponent();
        }

        private void MantenimientoUsuario_Load(object sender, EventArgs e)
        {
            dt = oper.ConsultaDataTable("SELECT * FROM login;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void btncrearingreso_Click(object sender, EventArgs e)
        {
            CRUDUSUARIO f = new CRUDUSUARIO();
            f.ShowDialog();
        }

        private void btnbuscarusuario_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        public void BuscarUsuario()
        {
            try
            {
                cnx.Open();
                if (rdbaliasusuario.Checked)
                {
                    string consulta = "SELECT * FROM login WHERE alias_usuario LIKE '%" + tbbuscarusuarios.Text + "%'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    cnx.Close();
                }
                else if (rdbnumeroempleado.Checked)
                {
                    string consulta = "SELECT * FROM login WHERE numero_empleado = '" + tbbuscarusuarios.Text + "'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    cnx.Close();
                }
                else if (rdbtipousuario.Checked)
                {
                    string consulta = "SELECT * FROM login WHERE codigo_tipo_usuario = '" + tbbuscarusuarios.Text + "'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    cnx.Close();
                }
                else if (rdbusuarios.Checked)
                {
                    string consulta = "SELECT * FROM login";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    cnx.Close();
                }
                else MessageBox.Show("Favor seleccionar una de las opciones!");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
