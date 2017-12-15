using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Xml;
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
            //ImprimirSel();
            try
            {
                if (rdbnombre.Checked)
                {
                    DataSet ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, fin_periodo, foto FROM cliente WHERE nombre_cliente LIKE '%" + tbbuscar.Text + "%'");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaClientes.xml");
                    Form f = new VisorReportes("Reporte de Clientes.rpt");
                    f.ShowDialog();
                }
                else if (rdbid.Checked)
                {
                    DataSet ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, fin_periodo, foto FROM cliente WHERE numero_cliente = '" + tbbuscar.Text + "'");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaClientes.xml");
                    Form f = new VisorReportes("Reporte de Clientes.rpt");
                    f.ShowDialog();
                }
                else if (rdbapellido.Checked)
                {
                    DataSet ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, fin_periodo, foto FROM cliente WHERE apellido_cliente LIKE '%" + tbbuscar.Text + "%'");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaClientes.xml");
                    Form f = new VisorReportes("Reporte de Clientes.rpt");
                    f.ShowDialog();
                }
                else if (rdbcedula.Checked)
                {
                    DataSet ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, fin_periodo, foto FROM cliente WHERE cedula_empleado = '" + tbbuscar.Text + "'");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaClientes.xml");
                    Form f = new VisorReportes("Reporte de Clientes.rpt");
                    f.ShowDialog();
                }
                else if (tbbuscar.Text == "")
                {
                    DataSet ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, fin_periodo, foto FROM cliente");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaClientes.xml");
                    Form f = new VisorReportes("Todos los clientes.rpt");
                    f.ShowDialog();
                }
                else MessageBox.Show("Favor realizar una selección!");
            }
            catch
            {
                MessageBox.Show("Antes debe seleccionar una de las opciones y digitar el valor a buscar!");
            }
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
            //MostrarTodo();
            //cnx.Open();
            string consulta = "SELECT numero_cliente Numero, nombre_cliente Nombre, apellido_cliente Apellido, cedula_cliente Cedula, fecha_nacimiento Nacimiento, telefono Telefonos, inicio_periodo Desde, fin_periodo Hasta FROM cliente";
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
            DataSet ds = new DataSet();
            ds.Reset();
            DataTable dt = new DataTable();
            db.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            //BuscarPor();

            try
            {
                cnx.Open();
                if (rdbnombre.Checked)
                {
                    string consulta = "SELECT cte.numero_cliente Numero, cte.nombre_cliente Nombre, cte.apellido_cliente Apellido, cte.cedula_cliente Cedula, cte.fecha_nacimiento Nacimiento, cte.direccion_cliente Direccion, sec.descripcion_sector Sectores, ciu.descripcion_ciudad Ciudades, cte.telefono Telefono, inicio_periodo Desde, fin_periodo Hasta, est.descripcion_estado Estados, cte.sexo, cte.foto FROM cliente cte INNER JOIN sector sec ON sec.codigo_sector = cte.codigo_sector INNER JOIN ciudad ciu ON ciu.codigo_ciudad = cte.codigo_ciudad INNER JOIN estado est ON est.codigo_estado = cte.codigo_estado WHERE cte.nombre_cliente LIKE '%" + tbbuscar.Text + "%'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    cnx.Close();
                }
                else if (rdbid.Checked)
                {
                    string consulta = "SELECT cte.numero_cliente Numero, cte.nombre_cliente Nombre, cte.apellido_cliente Apellido, cte.cedula_cliente Cedula, cte.fecha_nacimiento Nacimiento, cte.direccion_cliente Direccion, sec.descripcion_sector Sectores, ciu.descripcion_ciudad Ciudades, cte.telefono Telefono, inicio_periodo Desde, fin_periodo Hasta, est.descripcion_estado Estados, cte.sexo, cte.foto FROM cliente cte INNER JOIN sector sec ON sec.codigo_sector = cte.codigo_sector INNER JOIN ciudad ciu ON ciu.codigo_ciudad = cte.codigo_ciudad INNER JOIN estado est ON est.codigo_estado = cte.codigo_estado WHERE cte.numero_cliente = '" + tbbuscar.Text + "'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    cnx.Close();
                }
                else if (rdbapellido.Checked)
                {
                    string consulta = "SELECT cte.numero_cliente Numero, cte.nombre_cliente Nombre, cte.apellido_cliente Apellido, cte.cedula_cliente Cedula, cte.fecha_nacimiento Nacimiento, cte.direccion_cliente Direccion, sec.descripcion_sector Sectores, ciu.descripcion_ciudad Ciudades, cte.telefono Telefono, inicio_periodo Desde, fin_periodo Hasta, est.descripcion_estado Estados, cte.sexo, cte.foto FROM cliente cte INNER JOIN sector sec ON sec.codigo_sector = cte.codigo_sector INNER JOIN ciudad ciu ON ciu.codigo_ciudad = cte.codigo_ciudad INNER JOIN estado est ON est.codigo_estado = cte.codigo_estado WHERE cte.apellido_cliente LIKE '%" + tbbuscar.Text + "%'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    cnx.Close();
                }
                else if (rdbcedula.Checked)
                {
                    string consulta = "SELECT cte.numero_cliente Numero, cte.nombre_cliente Nombre, cte.apellido_cliente Apellido, cte.cedula_cliente Cedula, cte.fecha_nacimiento Nacimiento, cte.direccion_cliente Direccion, sec.descripcion_sector Sectores, ciu.descripcion_ciudad Ciudades, cte.telefono Telefono, inicio_periodo Desde, fin_periodo Hasta, est.descripcion_estado Estados, cte.sexo, cte.foto FROM cliente cte INNER JOIN sector sec ON sec.codigo_sector = cte.codigo_sector INNER JOIN ciudad ciu ON ciu.codigo_ciudad = cte.codigo_ciudad INNER JOIN estado est ON est.codigo_estado = cte.codigo_estado WHERE cte.cedula_cliente = '" + tbbuscar.Text + "'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUDClientes forclientes = new CRUDClientes();
            forclientes.tbnumerocliente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            forclientes.tbnombrecliente.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            forclientes.tbapellidocliente.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            forclientes.tbcedulacliente.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            forclientes.dtpnacimientocliente.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            forclientes.tbdireccioncliente.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            forclientes.cbsectorcliente.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            forclientes.cbciudadcliente.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            forclientes.tbtelefonocliente.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            forclientes.dtpiniciofactura.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            forclientes.dtpfinfactura.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            forclientes.cbestadocliente.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            forclientes.cbsexocliente.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            forclientes.tbRutaFoto.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            forclientes.Show();
            forclientes.tbnombrecliente.Enabled = true;
            forclientes.tbapellidocliente.Enabled = true;
            forclientes.tbcedulacliente.Enabled = true;
            forclientes.dtpnacimientocliente.Enabled = true;
            forclientes.tbdireccioncliente.Enabled = true;
            forclientes.cbsectorcliente.Enabled = true;
            forclientes.cbciudadcliente.Enabled = true;
            forclientes.tbtelefonocliente.Enabled = true;
            forclientes.cbestadocliente.Enabled = true;
            forclientes.cbsexocliente.Enabled = true;
            forclientes.btnguardarcliente.Enabled = false;
            forclientes.btnnuevocliente.Enabled = false;
            forclientes.btnactualizarcliente.Enabled = true;
            forclientes.btneliminarcliente.Enabled = true;
            forclientes.btnimprimircliente.Enabled = true;
            forclientes.btncargarfotocliente.Enabled = true;
        }
    }
}
