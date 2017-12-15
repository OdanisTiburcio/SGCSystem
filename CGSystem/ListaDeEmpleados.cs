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
                    string consulta = "SELECT emp.numero_empleado Numero, emp.nombre Nombre, emp.apellido Apellido, emp.cedula_empleado Cedula, pos.descripcion_posicion Cargo, dep.descripcion_departamento Departamentos, emp.sueldo Salario, emp.fecha_ingreso Fecha_Entrada, emp.celular Celular, est.descripcion_estado Estados FROM empleado emp INNER JOIN posicion pos on pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep on dep.codigo_departamento = emp.codigo_departamento INNER JOIN estado est ON est.codigo_estado = emp.codigo_estado WHERE nombre LIKE '%" + tbbuscar.Text + "%'";
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
                    string consulta = "SELECT emp.numero_empleado Numero, emp.nombre Nombre, emp.apellido Apellido, emp.cedula_empleado Cedula, pos.descripcion_posicion Cargo, dep.descripcion_departamento Departamentos, emp.sueldo Salario, emp.fecha_ingreso Fecha_Entrada, emp.celular Celular, est.descripcion_estado Estados FROM empleado emp INNER JOIN posicion pos on pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep on dep.codigo_departamento = emp.codigo_departamento INNER JOIN estado est ON est.codigo_estado = emp.codigo_estado WHERE numero_empleado = '" + tbbuscar.Text + "'";
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
                    string consulta = "SELECT emp.numero_empleado Numero, emp.nombre Nombre, emp.apellido Apellido, emp.cedula_empleado Cedula, pos.descripcion_posicion Cargo, dep.descripcion_departamento Departamentos, emp.sueldo Salario, emp.fecha_ingreso Fecha_Entrada, emp.celular Celular, est.descripcion_estado Estados FROM empleado emp INNER JOIN posicion pos on pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep on dep.codigo_departamento = emp.codigo_departamento INNER JOIN estado est ON est.codigo_estado = emp.codigo_estado WHERE apellido LIKE '%" + tbbuscar.Text + "%'";
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
                    string consulta = "SELECT emp.numero_empleado Numero, emp.nombre Nombre, emp.apellido Apellido, emp.cedula_empleado Cedula, pos.descripcion_posicion Cargo, dep.descripcion_departamento Departamentos, emp.sueldo Salario, emp.fecha_ingreso Fecha_Entrada, emp.celular Celular, est.descripcion_estado Estados FROM empleado emp INNER JOIN posicion pos on pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep on dep.codigo_departamento = emp.codigo_departamento INNER JOIN estado est ON est.codigo_estado = emp.codigo_estado WHERE cedula_empleado = '" + tbbuscar.Text + "'";
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
            string consulta = "SELECT emp.numero_empleado Numero, emp.nombre Nombre, emp.apellido Apellido, emp.cedula_empleado Cedula, pos.descripcion_posicion Cargo, dep.descripcion_departamento Departamentos, emp.sueldo Salario, emp.fecha_ingreso Fecha_Entrada, emp.celular Celular, est.descripcion_estado Estados FROM empleado emp INNER JOIN posicion pos on pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep on dep.codigo_departamento = emp.codigo_departamento INNER JOIN estado est ON est.codigo_estado = emp.codigo_estado";
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
            //try
            //{
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
                    DataSet ds = oper.ConsultaConResultado("SELECT emp.numero_empleado, emp.nombre, emp.apellido, emp.cedula_empleado, pos.descripcion_posicion, dep.descripcion_departamento, emp.sueldo, emp.foto FROM empleado emp INNER JOIN posicion pos on pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep on dep.codigo_departamento = emp.codigo_departamento WHERE cedula_empleado = '" + tbbuscar.Text + "'");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaEmpleado.xml");
                    Form f = new VisorReportes("Reporte de Empleados.rpt");
                    f.ShowDialog();
                }
                else if (tbbuscar.Text == "")
                {
                    DataSet ds = oper.ConsultaConResultado("SELECT emp.numero_empleado, emp.nombre, emp.apellido, emp.cedula_empleado, pos.descripcion_posicion, dep.descripcion_departamento, emp.sueldo, emp.foto FROM empleado emp INNER JOIN posicion pos on pos.codigo_posicion = emp.codigo_posicion INNER JOIN departamento dep on dep.codigo_departamento = emp.codigo_departamento");
                    ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaEmpleado.xml");
                    Form f = new VisorReportes("Todos los empleados.rpt");
                    f.ShowDialog();
                }
                else MessageBox.Show("Favor realizar una selección!");
            //}
            //catch
            //{
            //    MessageBox.Show("Antes debe seleccionar una de las opciones y digitar el valor a buscar!");
            //}
        }
    }
}
