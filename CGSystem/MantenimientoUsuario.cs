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
            //dt = oper.ConsultaDataTable("SELECT * FROM login;");
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
        }

        private void btncrearingreso_Click(object sender, EventArgs e)
        {
            CRUDUSUARIO f = new CRUDUSUARIO();
            f.cbtipocuentausuario.Enabled = true;
            f.cbnumeroempleado.Enabled = true;
            f.tbaliasusuario.Enabled = true;
            f.tbcontrasenausuario.Enabled = true;
            f.cbestadousuario.Enabled = true;
            f.btnguardarusuario.Enabled = false;
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
                    string consulta = "SELECT codigo_login AS Codigo, numero_empleado AS Num_Empleado, alias_usuario AS Alias, clave_usuario AS Clave, codigo_tipo_usuario AS Tipo, codigo_estado AS Estado FROM login WHERE alias_usuario LIKE '%" + tbbuscarusuarios.Text + "%'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    cnx.Close();
                    for (int i = 0; i < dataGridView1.RowCount; i++) //Ocultar Contraseña con asteriscos
                    {
                        dataGridView1.Rows[i].Cells[3].Value = "******";
                    }
                    dataGridView1.Refresh();

                }
                else if (rdbnumeroempleado.Checked)
                {
                    string consulta = "SELECT codigo_login AS Codigo, numero_empleado AS Num_Empleado, alias_usuario AS Alias, clave_usuario AS Clave, codigo_tipo_usuario AS Tipo, codigo_estado AS Estado FROM login WHERE numero_empleado = '" + tbbuscarusuarios.Text + "'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    cnx.Close();
                    for (int i = 0; i < dataGridView1.RowCount; i++) //Ocultar Contraseña con asteriscos
                    {
                        dataGridView1.Rows[i].Cells[3].Value = "******";
                    }
                    dataGridView1.Refresh();
                }
                else if (rdbtipousuario.Checked)
                {
                    string consulta = "SELECT codigo_login AS Codigo, numero_empleado AS Num_Empleado, alias_usuario AS Alias, clave_usuario AS Clave, codigo_tipo_usuario AS Tipo, codigo_estado AS Estado FROM login WHERE codigo_tipo_usuario = '" + tbbuscarusuarios.Text + "'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    cnx.Close();
                    for (int i = 0; i < dataGridView1.RowCount; i++) //Ocultar Contraseña con asteriscos
                    {
                        dataGridView1.Rows[i].Cells[3].Value = "******";
                    }
                    dataGridView1.Refresh();
                }
                else if (rdbusuarios.Checked)
                {
                    string consulta = "SELECT codigo_login AS Codigo, numero_empleado AS Num_Empleado, alias_usuario AS Alias, clave_usuario AS Clave, codigo_tipo_usuario AS Tipo, codigo_estado AS Estado FROM login";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    cnx.Close();
                    for (int i = 0; i < dataGridView1.RowCount; i++) //Ocultar Contraseña con asteriscos
                    {
                        dataGridView1.Rows[i].Cells[3].Value = "******";
                        if(dataGridView1.Rows[i].Cells[4].Value.ToString() == "1")
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "Administrador";
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "Empleado";
                        }
                    }
                    dataGridView1.Refresh();
                }
                else MessageBox.Show("Favor seleccionar una de las opciones!");
            }
            catch (Exception)
            {

            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Index == 3 && e.Value != null)
            {
                dataGridView1.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUDUSUARIO frmusuarios = new CRUDUSUARIO();
            string tipousuario;
            string estadousuario;
            ds = oper.ConsultaConResultado("SELECT descripcion_tipo_usuario FROM tipo_usuario WHERE codigo_tipo_usuario = '" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "'");
            tipousuario = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT descripcion_estado FROM estado WHERE codigo_estado = '" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "'");
            estadousuario = ds.Tables[0].Rows[0][0].ToString();
            frmusuarios.cbnumeroempleado.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmusuarios.tbaliasusuario.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmusuarios.tbcontrasenausuario.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmusuarios.cbtipocuentausuario.Text = tipousuario;
            frmusuarios.cbestadousuario.Text = estadousuario;
            frmusuarios.Show();
            BuscarUsuario();
            frmusuarios.btnactualizarusuario.Enabled = true;
            frmusuarios.cbtipocuentausuario.Enabled = true;
            frmusuarios.tbaliasusuario.Enabled = true;
            frmusuarios.tbcontrasenausuario.Enabled = true;
            frmusuarios.cbestadousuario.Enabled = true;
        }
    }
}
