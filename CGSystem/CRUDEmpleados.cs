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
    public partial class CRUDEmpleados : Form
    {
        operacion oper = new operacion();
        public CRUDEmpleados()
        {
            InitializeComponent();
        }
        public void limpiarcampos()
        {
            cbposicion.Text = "";
            cbdepartamento.Text = "";
            tbsueldo.Clear();
            tbcedulaempleado.Clear();
            tbnombreempleado.Clear();
            tbapellidoempleado.Clear();
            dtpingresoempleado.Value = DateTime.Now;
            dtpnacimientoempleado.Value = DateTime.Now;
            tbdireccionempleado.Clear();
            cbsector.Text = "";
            cbciudad.Text = "";
            tbtelefonoempleado.Clear();
            tbcelularempleado.Clear();
            cbestadoempleado.Text = "";
            cbsexoempleado.Text = "";
            pictureBox1.Image = null;
        }
        private void bncargarfotoempleado_Click(object sender, EventArgs e)
        {
            OpenFileDialog CargarFoto = new OpenFileDialog();
            CargarFoto.Filter = "Archivos de Imagen|*.jpg";
            CargarFoto.InitialDirectory = "C:\\CGSystem\\FotosEmpleados";
            if (CargarFoto.ShowDialog() == DialogResult.OK)
            {
                String Ruta = CargarFoto.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap Foto = new Bitmap(Ruta);
                tbRutaFoto.Text = Ruta;
                pictureBox1.Image = (Image)Foto;
            }
        }

        private void CRUDEmpleados_Load(object sender, EventArgs e)
        {
            tbnumeroempleado.ReadOnly = false;
            dtpingresoempleado.Value = DateTime.Now;
            dtpnacimientoempleado.Value = DateTime.Now;
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT descripcion_departamento FROM departamento", cnx);
            da.Fill(ds, "departamento");
            cbdepartamento.DataSource = ds.Tables[0].DefaultView;
            cbdepartamento.ValueMember = "descripcion_departamento";

            DataSet ds2 = new DataSet();
            SQLiteDataAdapter dd = new SQLiteDataAdapter("SELECT descripcion_posicion FROM posicion", cnx);
            dd.Fill(ds2, "posicion");
            cbposicion.DataSource = ds2.Tables[0].DefaultView;
            cbposicion.ValueMember = "descripcion_posicion";

            DataSet ds3 = new DataSet();
            SQLiteDataAdapter dc = new SQLiteDataAdapter("SELECT descripcion_sector FROM sector", cnx);
            dc.Fill(ds3, "sector");
            cbsector.DataSource = ds3.Tables[0].DefaultView;
            cbsector.ValueMember = "descripcion_sector";

            DataSet ds4 = new DataSet();
            SQLiteDataAdapter de = new SQLiteDataAdapter("SELECT descripcion_ciudad FROM ciudad", cnx);
            de.Fill(ds4, "ciudad");
            cbciudad.DataSource = ds4.Tables[0].DefaultView;
            cbciudad.ValueMember = "descripcion_ciudad";

            DataSet ds5 = new DataSet();
            SQLiteDataAdapter df = new SQLiteDataAdapter("SELECT descripcion_estado FROM estado", cnx);
            df.Fill(ds5, "estado");
            cbestadoempleado.DataSource = ds5.Tables[0].DefaultView;
            cbestadoempleado.ValueMember = "descripcion_estado";
            try
            {
                Bitmap Foto = new Bitmap(tbRutaFoto.Text);
                pictureBox1.Image = (Image)Foto;
            }
            catch (Exception)
            {

            }
        }

        public bool ReadOnly { get; set; }
        private void btnguardarempleado_Click(object sender, EventArgs e)
        {
            string codigodepart;
            string codigoposicion;
            string codigosector;
            string codigociudad;
            string codigoestado;
            DateTime Fechanac = dtpnacimientoempleado.Value;
            string fechanacimiento = oper.FormatearFecha(dtpnacimientoempleado.Value);
            DateTime FechaIng = dtpingresoempleado.Value;
            string fechaingreso = oper.FormatearFecha(dtpingresoempleado.Value);
            DataSet ds = new DataSet();
            ds = oper.ConsultaConResultado("SELECT codigo_posicion FROM posicion WHERE descripcion_posicion = '" + cbposicion.Text + "'");
            codigoposicion = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_departamento FROM departamento WHERE descripcion_departamento = '" + cbdepartamento.Text + "'");
            codigodepart = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_sector FROM sector WHERE descripcion_sector = '" + cbsector.Text + "'");
            codigosector = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_ciudad FROM ciudad WHERE descripcion_ciudad = '" + cbciudad.Text + "'");
            codigociudad = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_estado FROM estado WHERE descripcion_estado = '" + cbestadoempleado.Text + "'");
            codigoestado = ds.Tables[0].Rows[0][0].ToString();

            if (tbnombreempleado.Text != "" && tbapellidoempleado.Text != "" && tbcedulaempleado.Text != "" && dtpnacimientoempleado.Text != "" && cbsexoempleado.Text != "" && dtpingresoempleado.Text != "" && tbsueldo.Text != "" && cbposicion.Text != "" && cbdepartamento.Text != "" && cbestadoempleado.Text != "" && tbRutaFoto.Text != "")
            {
                oper.ConsultaSinResultado("INSERT INTO empleado (codigo_posicion, codigo_departamento, sueldo, cedula_empleado, nombre, apellido, fecha_nacimiento, fecha_ingreso, direccion, codigo_sector, codigo_ciudad, telefono_casa, celular, codigo_estado, foto, sexo) VALUES ('" + codigoposicion + "','" + codigodepart + "','" + tbsueldo.Text + "','" + tbcedulaempleado.Text.ToString() + "','" + tbnombreempleado.Text.ToString().ToUpper() + "','" + tbapellidoempleado.Text.ToString().ToUpper() + "','" + fechanacimiento + "','" + fechaingreso + "','" + tbdireccionempleado.Text.ToString().ToUpper() + "','" + codigosector + "','" + codigociudad + "','" + tbtelefonoempleado.Text.ToString() + "','" + tbcelularempleado.Text.ToString() + "','" + codigoestado + "','" + tbRutaFoto.Text.ToString() + "','" + cbsexoempleado.Text.ToString() + "')");
                limpiarcampos();
                MessageBox.Show("Datos registrados satisfactoriamente!");
            }
            else
            {
                MessageBox.Show("Faltan datos por registrar! ");
            }
        }

        private void btnactualizarempleado_Click(object sender, EventArgs e)
        {
            string codigodepart;
            string codigoposicion;
            string codigosector;
            string codigociudad;
            string codigoestado;
            DateTime Fechanac = dtpnacimientoempleado.Value;
            string fechanacimiento = oper.FormatearFecha(dtpnacimientoempleado.Value);
            DateTime FechaIng = dtpingresoempleado.Value;
            string fechaingreso = oper.FormatearFecha(dtpingresoempleado.Value);
            DataSet ds = new DataSet();
            ds = oper.ConsultaConResultado("SELECT codigo_posicion FROM posicion WHERE descripcion_posicion = '" + cbposicion.Text + "'");
            codigoposicion = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_departamento FROM departamento WHERE descripcion_departamento = '" + cbdepartamento.Text + "'");
            codigodepart = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_sector FROM sector WHERE descripcion_sector = '" + cbsector.Text + "'");
            codigosector = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_ciudad FROM ciudad WHERE descripcion_ciudad = '" + cbciudad.Text + "'");
            codigociudad = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_estado FROM estado WHERE descripcion_estado = '" + cbestadoempleado.Text + "'");
            codigoestado = ds.Tables[0].Rows[0][0].ToString();

            if (tbnombreempleado.Text != "" && tbapellidoempleado.Text != "" && tbcedulaempleado.Text != "" && dtpnacimientoempleado.Text != "" && cbsexoempleado.Text != "" && dtpingresoempleado.Text != "" && tbsueldo.Text != "" && cbposicion.Text != "" && cbdepartamento.Text != "" && cbestadoempleado.Text != "" && tbRutaFoto.Text != "")
            {
                oper.ConsultaSinResultado("UPDATE empleado SET codigo_posicion = '" + codigoposicion + "', codigo_departamento = '" + codigodepart + "', sueldo = '" + tbsueldo.Text + "', cedula_empleado = '" + tbcedulaempleado.Text.ToString() + "', nombre = '" + tbnombreempleado.Text.ToString().ToUpper() + "', apellido = '" + tbapellidoempleado.Text.ToString().ToUpper() + "', fecha_nacimiento = '" + fechanacimiento + "', fecha_ingreso = '" + fechaingreso + "', direccion = '" + tbdireccionempleado.Text.ToString().ToUpper() + "', codigo_sector = '" + codigosector + "', codigo_ciudad = '" + codigociudad + "', telefono_casa = '" + tbtelefonoempleado.Text.ToString() + "', celular = '" + tbcelularempleado.Text.ToString() + "', codigo_estado = '" + codigoestado + "', foto = '" + tbRutaFoto.Text.ToString() + "', sexo = '" + cbsexoempleado.Text.ToString() + "' WHERE numero_empleado = '" + tbnumeroempleado.Text + "'");
                limpiarcampos();
                MessageBox.Show("Datos actualizados satisfactoriamente!");
            }
            else
            {
                MessageBox.Show("Faltan datos por registrar! ");
            }
        }

        private void btneliminarempleado_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string conclave;
            if (tbnumeroempleado.Text != "")
            {
                ds = oper.ConsultaConResultado("SELECT numero_empleado FROM login WHERE  = '" + tbnumeroempleado.Text + "'");
                try
                {
                    conclave = ds.Tables[0].Rows[0][0].ToString();
                }
                catch
                {
                    conclave = "No tiene acceso";
                }
                if (conclave == tbnumeroempleado.Text)
                {
                    MessageBox.Show("Este empleado no puede ser eliminado, verifique el número", "Aviso!");
                    return;
                }
                else
                {
                    DialogResult Result = MessageBox.Show("¿Está seguro que desea eliminar este empleado de la base de datos?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (Result == DialogResult.OK)
                    {
                        oper.ConsultaSinResultado("DELETE FROM empleado WHERE numero_empleado ='" + tbnumeroempleado.Text + "'");
                        limpiarcampos();
                        MessageBox.Show("Empleado borrado correctamente! ");
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        private void btnnuevoempleado_Click(object sender, EventArgs e)
        {
            cbsexoempleado.Enabled = true;
            tbnombreempleado.Enabled = true;
            tbapellidoempleado.Enabled = true;
            tbcedulaempleado.Enabled = true;
            dtpnacimientoempleado.Enabled = true;
            cbdepartamento.Enabled = true;
            cbposicion.Enabled = true;
            tbsueldo.Enabled = true;
            dtpingresoempleado.Enabled = true;
            cbestadoempleado.Enabled = true;
            tbdireccionempleado.Enabled = true;
            cbsector.Enabled = true;
            cbciudad.Enabled = true;
            tbtelefonoempleado.Enabled = true;
            tbcelularempleado.Enabled = true;
            btnguardarempleado.Enabled = true;
            bncargarfotoempleado.Enabled = true;
        }
    }
}
