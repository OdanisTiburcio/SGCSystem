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
            MostrarTodos();
            cbtipousuario.SelectedIndex = 0;

            //dt = oper.ConsultaDataTable("SELECT * FROM login;");
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
        }

        //private void btncrearingreso_Click(object sender, EventArgs e)
        //{
        //    CRUDUSUARIO f = new CRUDUSUARIO();
        //    f.cbtipocuentausuario.Enabled = true;
        //    f.cbnumeroempleado.Enabled = true;
        //    f.tbaliasusuario.Enabled = true;
        //    f.tbcontrasenausuario.Enabled = true;
        //    f.cbestadousuario.Enabled = true;
        //    f.btnguardarusuario.Enabled = false;
        //    f.ShowDialog();
        //}

        //public void BuscarUsuario()
        //{
        //    try
        //    {
        //        cnx.Open();
        //        if (rdbaliasusuario.Checked)
        //        {
        //            string consulta = "SELECT codigo_login AS Codigo, numero_empleado AS Num_Empleado, alias_usuario AS Alias, clave_usuario AS Clave, codigo_tipo_usuario AS Tipo, codigo_estado AS Estado FROM login WHERE alias_usuario LIKE '%" + tbbuscarusuarios.Text + "%'";
        //            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
        //            DataSet ds = new DataSet();
        //            ds.Reset();
        //            DataTable dt = new DataTable();
        //            db.Fill(ds);
        //            dt = ds.Tables[0];
        //            dataGridView1.DataSource = dt;
        //            cnx.Close();
        //            for (int i = 0; i < dataGridView1.RowCount; i++) //Ocultar Contraseña con asteriscos
        //            {
        //                dataGridView1.Rows[i].Cells[3].Value = "******";
        //            }
        //            dataGridView1.Refresh();

        //        }
        //        else if (rdbnumeroempleado.Checked)
        //        {
        //            string consulta = "SELECT emp.nombre AS Nombre, emp.apellido AS Apellido, l.alias_usuario AS Alias, l.clave_usuario AS Clave, t.descripcion_tipo_usuario AS Tipo FROM login l INNER JOIN tipo_usuario t ON t.codigo_tipo_usuario = l.codigo_tipo_usuario INNER JOIN empleado emp ON emp.numero_empleado = l.numero_empleado WHERE l.numero_empleado = '" + tbbuscarusuarios.Text + "'";
        //            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
        //            DataSet ds = new DataSet();
        //            ds.Reset();
        //            DataTable dt = new DataTable();
        //            db.Fill(ds);
        //            dt = ds.Tables[0];
        //            dataGridView1.DataSource = dt;
        //            cnx.Close();
        //            for (int i = 0; i < dataGridView1.RowCount; i++) //Ocultar Contraseña con asteriscos
        //            {
        //                dataGridView1.Rows[i].Cells[3].Value = "******";
        //            }
        //            dataGridView1.Refresh();
        //        }
        //        else if (rdbtipousuario.Checked)
        //        {
        //            string consulta = "SELECT emp.nombre AS Nombre, emp.apellido AS Apellido, l.alias_usuario AS Alias, l.clave_usuario AS Clave, t.descripcion_tipo_usuario AS Tipo FROM login l INNER JOIN tipo_usuario t ON t.codigo_tipo_usuario = l.codigo_tipo_usuario INNER JOIN empleado emp ON emp.numero_empleado = l.numero_empleado WHERE l.numero_empleado = '" + tbbuscarusuarios.Text + "'";
        //            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
        //            DataSet ds = new DataSet();
        //            ds.Reset();
        //            DataTable dt = new DataTable();
        //            db.Fill(ds);
        //            dt = ds.Tables[0];
        //            dataGridView1.DataSource = dt;
        //            cnx.Close();
        //            for (int i = 0; i < dataGridView1.RowCount; i++) //Ocultar Contraseña con asteriscos
        //            {
        //                dataGridView1.Rows[i].Cells[3].Value = "******";
        //            }
        //            dataGridView1.Refresh();
        //        }
        //        else if (rdbusuarios.Checked)
        //        {
        //            string consulta = "SELECT emp.nombre AS Nombre, emp.apellido AS Apellido, l.alias_usuario AS Alias, l.clave_usuario AS Clave, t.descripcion_tipo_usuario AS Tipo FROM login l INNER JOIN tipo_usuario t ON t.codigo_tipo_usuario = l.codigo_tipo_usuario INNER JOIN empleado emp ON emp.numero_empleado = l.numero_empleado";
        //            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
        //            DataSet ds = new DataSet();
        //            ds.Reset();
        //            DataTable dt = new DataTable();
        //            db.Fill(ds);
        //            dt = ds.Tables[0];
        //            dataGridView1.DataSource = dt;
        //            cnx.Close();
        //            for (int i = 0; i < dataGridView1.RowCount; i++) //Ocultar Contraseña con asteriscos
        //            {
        //                dataGridView1.Rows[i].Cells[3].Value = "******";
        //                //if(dataGridView1.Rows[i].Cells[4].Value.ToString() == "1")
        //                //{
        //                //    dataGridView1.Rows[i].Cells[4].Value = "Administrador";
        //                //}
        //                //else
        //                //{
        //                //    dataGridView1.Rows[i].Cells[4].Value = "Empleado";
        //                //}
        //            }
        //            dataGridView1.Refresh();
        //        }
        //        else MessageBox.Show("Favor seleccionar una de las opciones!");
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (dgvequipos.Columns[e.ColumnIndex].Index == 3 && e.Value != null)
            //{
            //    dgvequipos.Rows[e.RowIndex].Tag = e.Value;
            //    e.Value = new String('*', e.Value.ToString().Length);
            //}
        }

        public void MostrarTodos()
        {
            DataSet ds = oper.ConsultaConResultado("SELECT login.alias_usuario, login.numero_empleado, login.codigo_tipo_usuario FROM login;");

            dgvequipos.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvequipos.Rows.Add();

                dgvequipos.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                dgvequipos.Rows[i].Cells[1].Value = "*******";
                dgvequipos.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][1].ToString();
                dgvequipos.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][2].ToString();

            }

        }
    }

}
