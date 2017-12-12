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
        public CRUDEmpleados()
        {
            InitializeComponent();
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
            tbnumeroempleado.ReadOnly = true;
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

        public bool ReadOnly {get; set;}
        private void btnguardarempleado_Click(object sender, EventArgs e)
        {
            string codigodepart;
            string codigoposicion;
            string codigosector;
            string codigociudad;
            string codigoestado;
            operacion oper = new operacion();
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
                oper.ConsultaSinResultado("INSERT INTO empleado (codigo_posicion, codigo_departamento, sueldo, cedula_empleado, nombre, apellido, fecha_nacimineto, fecha_ingreso, direccion, codigo_sector, codigo_ciudad, telefono_casa, celular, codigo_estado, foto, sexo) VALUES ('" + codigoposicion + "','" + codigodepart + "','" + tbsueldo.Text + "','" + tbcedulaempleado.Text.ToString() + "','" + tbnombreempleado.Text.ToString().ToUpper() + "','" + tbapellidoempleado.Text.ToString().ToUpper() + "','" + dtpnacimientoempleado.Text.ToString() + "','" + dtpingresoempleado.Text.ToString() + "','" + tbdireccionempleado.Text.ToString().ToUpper() + "','" + codigosector + "','" + codigociudad + "','" + tbtelefonoempleado.Text.ToString() + "','" + tbcelularempleado.Text.ToString() + "','" + codigoestado + "','" + tbRutaFoto.Text.ToString() + "','" + cbsexoempleado.Text.ToString() + "')");
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
                MessageBox.Show("Datos registrados satisfactoriamente!");
            }
            else
            {
                MessageBox.Show("Faltan datos por registrar! ");
            }
        }
    }
}
