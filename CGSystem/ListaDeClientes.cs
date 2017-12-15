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
    public partial class ListaDeClientes : Form
    {
        //Variables necesarias
        public static string codigosector;
        public static string codigociudad;
        public static string codigoestadoo;
        public static bool Seleccionando = false;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        operacion oper = new operacion();
        SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
        public ListaDeClientes()
        {
            InitializeComponent();
        }

        private void ListaDeClientes_Load(object sender, EventArgs e)
        {
            if (Seleccionando)
            {
                btnimprimir.Text = "Seleccionar";
                btnimprimir.Enabled = true;
            }
            else { btnimprimir.Text = "Imprimir"; }

            MostrarTodo();

        }

        public void ImprimirSel()
        {
            if (Seleccionando)
            {
                try
                {
                    //Seleccionar el id de la columna seleccionada.
                    CheckIn.IdEmpleado = dgvListaClientes.CurrentRow.Cells[0].Value.ToString();
                    Facturación.NombreCliente = dgvListaClientes.CurrentRow.Cells[1].Value.ToString() + " " + dgvListaClientes.CurrentRow.Cells[2].Value.ToString(); //Nombre más apellido
                    Facturación.IdCliente = dgvListaClientes.CurrentRow.Cells[0].Value.ToString(); //código del cliente
                    Facturación.SelecciónDeCliente = true;
                    Seleccionando = false;
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Hubo un error al seleccionar el cliente, inténtelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {

                try
                {
                    //Codigo para imprimir Reporte Presentado en el DataGridView de Lista de Empleados
                }
                catch
                {
                    MessageBox.Show("Hubo un error al intentar imprimir el reporte actual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            ImprimirSel();
        }

        private void dgvListaEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Seleccionando)
            {
                ImprimirSel();
            }
            else
            {

            }
        }

        public void MostrarTodo()
        {
            //Este método muestra todos los clientes existentes en la base de datos
            try
            {
                dgvListaClientes.Rows.Clear();
                //Cargar la Tabla de todos los empleados activos
                ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, inicio_periodo, fin_periodo FROM cliente;"); //WHERE codigo_estado = '1' o Activo

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    dgvListaClientes.Rows.Add();
                    for (int k = 0; k < 6; k++)
                    {
                        dgvListaClientes.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                    }

                }

            }
            catch
            {

            }
        }

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            MostrarTodo();
            //cnx.Open();
            //    string consulta = "SELECT numero_cliente Numero, nombre_cliente Nombre, apellido_cliente Apellido, cedula_cliente Cedula, fecha_nacimiento Nacimiento, telefono Telefonos, inicio_periodo Desde, fin_periodo Hasta FROM cliente";
            //    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
            //    DataSet ds = new DataSet();
            //    ds.Reset();
            //    DataTable dt = new DataTable();
            //    db.Fill(ds);
            //    dt = ds.Tables[0];
            //    dataGridView1.DataSource = dt;
            //    cnx.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            BuscarPor();

            //try
            //{
            //    cnx.Open();
            //    if (rdbnombre.Checked)
            //    {
            //        string consulta = "SELECT numero_cliente Numero, nombre_cliente Nombre, apellido_cliente Apellido, cedula_cliente Cedula, fecha_nacimiento Nacimiento, telefono Telefono, inicio_periodo Desde, fin_periodo Hasta FROM cliente WHERE nombre_cliente LIKE '%" + tbbuscar.Text + "%'";
            //        SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
            //        DataSet ds = new DataSet();
            //        ds.Reset();
            //        DataTable dt = new DataTable();
            //        db.Fill(ds);
            //        dt = ds.Tables[0];
            //        dataGridView1.DataSource = dt;
            //        cnx.Close();
            //    }
            //    else if (rdbid.Checked)
            //    {
            //        string consulta = "SELECT numero_cliente Numero, nombre_cliente Nombre, apellido_cliente Apellido, cedula_cliente Cedula, fecha_nacimiento Nacimiento, telefono Telefonos, inicio_periodo Desde, fin_periodo Hasta FROM cliente WHERE numero_cliente = '" + tbbuscar.Text + "'";
            //        SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
            //        DataSet ds = new DataSet();
            //        ds.Reset();
            //        DataTable dt = new DataTable();
            //        db.Fill(ds);
            //        dt = ds.Tables[0];
            //        dataGridView1.DataSource = dt;
            //        cnx.Close();
            //    }
            //    else if (rdbapellido.Checked)
            //    {
            //        string consulta = "SELECT numero_cliente Numero, nombre_cliente Nombre, apellido_cliente Apellido, cedula_cliente Cedula, fecha_nacimiento Nacimiento, telefono Telefonos, inicio_periodo Desde, fin_periodo Hasta FROM cliente WHERE apellido_cliente LIKE '%" + tbbuscar.Text + "%'";
            //        SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
            //        DataSet ds = new DataSet();
            //        ds.Reset();
            //        DataTable dt = new DataTable();
            //        db.Fill(ds);
            //        dt = ds.Tables[0];
            //        dataGridView1.DataSource = dt;
            //        cnx.Close();
            //    }
            //    else if (rdbcedula.Checked)
            //    {
            //        string consulta = "SELECT numero_cliente Numero, nombre_cliente Nombre, apellido_cliente Apellido, cedula_cliente Cedula, fecha_nacimiento Nacimiento, telefono Telefonos, inicio_periodo Desde, fin_periodo Hasta FROM cliente WHERE cedula_cliente = '" + tbbuscar.Text + "'";
            //        SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
            //        DataSet ds = new DataSet();
            //        ds.Reset();
            //        DataTable dt = new DataTable();
            //        db.Fill(ds);
            //        dt = ds.Tables[0];
            //        dataGridView1.DataSource = dt;
            //        cnx.Close();
            //    }

            //    else MessageBox.Show("Favor seleccionar una de las opciones!");
            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            CRUDClientes f = new CRUDClientes();
            f.Show();
        }

        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void BuscarPor()
        {
            //Este método muestra todos los clientes Filtrados adecuadamente, según la opción seleccionada
            try
            {
                dgvListaClientes.Rows.Clear();
                //Cargar la Tabla de todos los empleados activos
                if (rdbnombre.Checked)
                {
                    ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, inicio_periodo, fin_periodo FROM cliente WHERE nombre_cliente LIKE '%" + tbbuscar.Text + "%';"); //Filtro establecido por nombre
                }
                else
                {
                    if (rdbid.Checked)
                    {
                        ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, inicio_periodo, fin_periodo FROM cliente WHERE numero_cliente LIKE '%" + tbbuscar.Text + "%';"); //Filtro establecido por id
                    }
                    else
                    {
                        if (rdbapellido.Checked)
                        {
                            ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, inicio_periodo, fin_periodo FROM cliente WHERE apellido_cliente LIKE '%" + tbbuscar.Text + "%';"); //Filtro establecido por apellido
                        }
                        else
                        {
                            ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, inicio_periodo, fin_periodo FROM cliente WHERE cedula_cliente LIKE '%" + tbbuscar.Text + "%';"); //Filtro establecido por cédula
                        }
                    }
                }

                //Pasar los datos del DataSet al DataGridView
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    dgvListaClientes.Rows.Add();
                    for (int k = 0; k < 6; k++)
                    {
                        dgvListaClientes.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                    }

                }

            }
            catch
            {

            }
        }

        private void tbbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                BuscarPor();
            }
            else { }
        }

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarPor();
        }
    }
}
