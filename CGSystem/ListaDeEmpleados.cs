using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class ListaDeEmpleados : Form
    {
        operacion oper = new operacion();
        SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
        public ListaDeEmpleados()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            CRUDEmpleados f = new CRUDEmpleados();
            f.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                if (rdbnombre.Checked)
                {
                    string consulta = "SELECT emp.numero_empleado Numero, emp.nombre Nombre, emp.apellido Apellido, emp.cedula_empleado Cedula, pos.descripcion_posicion Cargo, dep.descripcion_departamento Departamentos, emp.sueldo Salario, emp.fecha_ingreso Fecha_Entrada, emp.fecha_nacimiento Nacimiento, emp.celular Celular, emp.direccion Direcciones, sec.descripcion_sector Sectores, ciu.descripcion_ciudad Ciudades, emp.telefono_casa Tel_Casa, emp.sexo Genero, est.descripcion_estado Estados, emp.foto FROM empleado emp INNER JOIN posicion pos ON pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep ON dep.codigo_departamento = emp.codigo_departamento INNER JOIN estado est ON est.codigo_estado = emp.codigo_estado INNER JOIN sector sec ON sec.codigo_sector = emp.codigo_sector INNER JOIN ciudad ciu ON ciu.codigo_ciudad = emp.codigo_ciudad WHERE emp.nombre LIKE '%" + tbbuscar.Text + "%'";
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
                    string consulta = "SELECT emp.numero_empleado Numero, emp.nombre Nombre, emp.apellido Apellido, emp.cedula_empleado Cedula, pos.descripcion_posicion Cargo, dep.descripcion_departamento Departamentos, emp.sueldo Salario, emp.fecha_ingreso Fecha_Entrada, emp.fecha_nacimiento Nacimiento, emp.celular Celular, emp.direccion Direcciones, sec.descripcion_sector Sectores, ciu.descripcion_ciudad Ciudades, emp.telefono_casa Tel_Casa, emp.sexo Genero, est.descripcion_estado Estados, emp.foto FROM empleado emp INNER JOIN posicion pos ON pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep ON dep.codigo_departamento = emp.codigo_departamento INNER JOIN estado est ON est.codigo_estado = emp.codigo_estado INNER JOIN sector sec ON sec.codigo_sector = emp.codigo_sector INNER JOIN ciudad ciu ON ciu.codigo_ciudad = emp.codigo_ciudad WHERE numero_empleado = '" + tbbuscar.Text + "'";
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
                    string consulta = "SELECT emp.numero_empleado Numero, emp.nombre Nombre, emp.apellido Apellido, emp.cedula_empleado Cedula, pos.descripcion_posicion Cargo, dep.descripcion_departamento Departamentos, emp.sueldo Salario, emp.fecha_ingreso Fecha_Entrada, emp.fecha_nacimiento Nacimiento, emp.celular Celular, emp.direccion Direcciones, sec.descripcion_sector Sectores, ciu.descripcion_ciudad Ciudades, emp.telefono_casa Tel_Casa, emp.sexo Genero, est.descripcion_estado Estados, emp.foto FROM empleado emp INNER JOIN posicion pos ON pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep ON dep.codigo_departamento = emp.codigo_departamento INNER JOIN estado est ON est.codigo_estado = emp.codigo_estado INNER JOIN sector sec ON sec.codigo_sector = emp.codigo_sector INNER JOIN ciudad ciu ON ciu.codigo_ciudad = emp.codigo_ciudad WHERE apellido LIKE '%" + tbbuscar.Text + "%'";
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
                    string consulta = "SELECT emp.numero_empleado Numero, emp.nombre Nombre, emp.apellido Apellido, emp.cedula_empleado Cedula, pos.descripcion_posicion Cargo, dep.descripcion_departamento Departamentos, emp.sueldo Salario, emp.fecha_ingreso Fecha_Entrada, emp.fecha_nacimiento Nacimiento, emp.celular Celular, emp.direccion Direcciones, sec.descripcion_sector Sectores, ciu.descripcion_ciudad Ciudades, emp.telefono_casa Tel_Casa, emp.sexo Genero, est.descripcion_estado Estados, emp.foto FROM empleado emp INNER JOIN posicion pos ON pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep ON dep.codigo_departamento = emp.codigo_departamento INNER JOIN estado est ON est.codigo_estado = emp.codigo_estado INNER JOIN sector sec ON sec.codigo_sector = emp.codigo_sector INNER JOIN ciudad ciu ON ciu.codigo_ciudad = emp.codigo_ciudad";
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

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT emp.numero_empleado Numero, emp.nombre Nombre, emp.apellido Apellido, emp.cedula_empleado Cedula, pos.descripcion_posicion Cargo, dep.descripcion_departamento Departamentos, emp.sueldo Salario, emp.fecha_ingreso Fecha_Entrada, emp.fecha_nacimiento Nacimiento, emp.celular Celular, emp.direccion Direcciones, sec.descripcion_sector Sectores, ciu.descripcion_ciudad Ciudades, emp.telefono_casa Tel_Casa, emp.sexo Genero, est.descripcion_estado Estados, emp.foto FROM empleado emp INNER JOIN posicion pos ON pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep ON dep.codigo_departamento = emp.codigo_departamento INNER JOIN estado est ON est.codigo_estado = emp.codigo_estado INNER JOIN sector sec ON sec.codigo_sector = emp.codigo_sector INNER JOIN ciudad ciu ON ciu.codigo_ciudad = emp.codigo_ciudad";
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
            DataSet ds = new DataSet();
            ds.Reset();
            DataTable dt = new DataTable();
            db.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUDEmpleados forempleados = new CRUDEmpleados();
            forempleados.tbnumeroempleado.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            forempleados.tbnombreempleado.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            forempleados.tbapellidoempleado.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            forempleados.tbcedulaempleado.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            forempleados.cbposicion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            forempleados.cbdepartamento.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            forempleados.tbsueldo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            forempleados.dtpingresoempleado.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            forempleados.dtpnacimientoempleado.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            forempleados.tbcelularempleado.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            forempleados.tbdireccionempleado.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            forempleados.cbsector.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            forempleados.cbciudad.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            forempleados.tbtelefonoempleado.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            forempleados.cbsexoempleado.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            forempleados.cbestadoempleado.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            forempleados.tbRutaFoto.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            forempleados.Show();
            forempleados.tbnumeroempleado.Enabled = false;
            forempleados.btnguardarempleado.Enabled = false;
        }

        private void ListaDeEmpleados_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbnombre.Checked)
                {
                    DataSet ds = oper.ConsultaConResultado("SELECT emp.numero_empleado, emp.nombre, emp.apellido, emp.cedula_empleado, pos.descripcion_posicion, dep.descripcion_departamento, emp.sueldo, emp.foto FROM empleado emp INNER JOIN posicion pos on pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep on dep.codigo_departamento = emp.codigo_departamento WHERE nombre LIKE '%" + tbbuscar.Text + "%'");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaEmpleado.xml");
                    Form f = new VisorReportes("Reporte de Empleados.rpt");
                    f.ShowDialog();
                }
                else if (rdbid.Checked)
                {
                    DataSet ds = oper.ConsultaConResultado("SELECT emp.numero_empleado, emp.nombre, emp.apellido, emp.cedula_empleado, pos.descripcion_posicion, dep.descripcion_departamento, emp.sueldo, emp.foto FROM empleado emp INNER JOIN posicion pos on pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep on dep.codigo_departamento = emp.codigo_departamento WHERE numero_empleado = '" + tbbuscar.Text + "'");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaEmpleado.xml");
                    Form f = new VisorReportes("Reporte de Empleados.rpt");
                    f.ShowDialog();
                }
                else if (rdbapellido.Checked)
                {
                    DataSet ds = oper.ConsultaConResultado("SELECT emp.numero_empleado, emp.nombre, emp.apellido, emp.cedula_empleado, pos.descripcion_posicion, dep.descripcion_departamento, emp.sueldo, emp.foto FROM empleado emp INNER JOIN posicion pos on pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep on dep.codigo_departamento = emp.codigo_departamento WHERE apellido LIKE '%" + tbbuscar.Text + "%'");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaEmpleado.xml");
                    Form f = new VisorReportes("Reporte de Empleados.rpt");
                    f.ShowDialog();
                }
                else if (rdbcedula.Checked)
                {
                    DataSet ds = oper.ConsultaConResultado("SELECT emp.numero_empleado, emp.nombre, emp.apellido, emp.cedula_empleado, pos.descripcion_posicion, dep.descripcion_departamento, emp.sueldo, emp.foto FROM empleado emp INNER JOIN posicion pos on pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep on dep.codigo_departamento = emp.codigo_departamento");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaEmpleado.xml");
                    Form f = new VisorReportes("C:\\CGSystem\\CGSystem\\Todos los empleados.rpt");
                    f.ShowDialog();
                }
                else MessageBox.Show("Favor realizar una selección!");
            }
            catch
            {
                MessageBox.Show("Antes debe seleccionar una de las opciones y digitar el valor a buscar!");
            }
        }
    }
}
