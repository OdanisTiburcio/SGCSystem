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
    public partial class CRUDClientes : Form
    {
        public CRUDClientes()
        {
            InitializeComponent();
        }
        public void limpiarcampos()
        {
            cbsectorcliente.Text = "";
            tbnombrecliente.Clear();
            tbapellidocliente.Clear();
            tbcedulacliente.Clear();
            dtpnacimientocliente.Value = DateTime.Now;
            tbdireccioncliente.Clear();
            cbsectorcliente.Text = "";
            cbciudadcliente.Text = "";
            tbtelefonocliente.Clear();
            cbestadocliente.Text = "";
            pictureBox1.Image = null;
        }
        private void btnguardarcliente_Click(object sender, EventArgs e)
        {
            string codigosector;
            string codigociudad;
            string codigoestado;
            operacion oper = new operacion();
            DataSet ds = new DataSet();
            ds = oper.ConsultaConResultado("SELECT codigo_sector FROM sector WHERE descripcion_sector = '" + cbsectorcliente.Text + "'");
            codigosector = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_ciudad FROM ciudad WHERE descripcion_ciudad = '" + cbciudadcliente.Text + "'");
            codigociudad = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_estado FROM estado WHERE descripcion_estado = '" + cbestadocliente.Text + "'");
            codigoestado = ds.Tables[0].Rows[0][0].ToString();

            if (tbnombrecliente.Text != "" && tbapellidocliente.Text != "" && tbcedulacliente.Text != "" && dtpnacimientocliente.Text != "" && cbsexocliente.Text != "" && tbdireccioncliente.Text != "" && cbsectorcliente.Text != "" && cbciudadcliente.Text != "" && cbestadocliente.Text != "" && tbRutaFoto.Text != "" && dtpfinfactura.Text != "" && dtpiniciofactura.Text != "")
            {
                DialogResult Result = MessageBox.Show("Desea conservar las fechas de servicios para este cliente", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    oper.ConsultaSinResultado("INSERT INTO cliente (cedula_cliente, nombre_cliente, apellido_cliente, fecha_nacimiento, direccion_cliente, codigo_sector, codigo_ciudad, telefono, inicio_periodo, fin_periodo, codigo_estado, foto) VALUES ('" + tbcedulacliente.Text.ToString() + "','" + tbnombrecliente.Text.ToString().ToUpper() + "','" + tbapellidocliente.Text.ToString().ToUpper() + "','" + dtpnacimientocliente.Text.ToString() + "','" + tbdireccioncliente.Text.ToString().ToUpper() + "','" + codigosector + "','" + codigociudad + "','" + tbtelefonocliente.Text.ToString() + "','" + dtpiniciofactura.Text + "','" + dtpfinfactura.Text + "','" + codigoestado + "', '" + tbRutaFoto.Text.ToString() + "')");
                    limpiarcampos();
                    MessageBox.Show("Datos registrados satisfactoriamente!");
                }
                else
                {
                    oper.ConsultaSinResultado("INSERT INTO cliente (cedula_cliente, nombre_cliente, apellido_cliente, fecha_nacimiento, direccion_cliente, codigo_sector, codigo_ciudad, telefono, inicio_periodo, fin_periodo, codigo_estado, foto) VALUES ('" + tbcedulacliente.Text.ToString() + "','" + tbnombrecliente.Text.ToString().ToUpper() + "','" + tbapellidocliente.Text.ToString().ToUpper() + "','" + dtpnacimientocliente.Text.ToString() + "','" + tbdireccioncliente.Text.ToString().ToUpper() + "','" + codigosector + "','" + codigociudad + "','" + tbtelefonocliente.Text.ToString() + "','" + null + "','" + null + "','" + codigoestado + "', '" + tbRutaFoto.Text.ToString() + "')");
                    limpiarcampos();
                    MessageBox.Show("Datos registrados satisfactoriamente!");
                } 
            }else MessageBox.Show("Faltan datos por registrar! ");
        }
private void btncargarfotocliente_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog CargarFoto = new OpenFileDialog();
            CargarFoto.Filter = "Archivos de Imagen|*.jpg";
            CargarFoto.InitialDirectory = "C:\\CGSystem\\FotosClientes";
            if (CargarFoto.ShowDialog() == DialogResult.OK)
            {
                String Ruta = CargarFoto.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap Foto = new Bitmap(Ruta);
                tbRutaFoto.Text = Ruta;
                pictureBox1.Image = (Image)Foto;
            }
        }

        private void CRUDClientes_Load(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT descripcion_sector FROM sector", cnx);
            da.Fill(ds, "sector");
            cbsectorcliente.DataSource = ds.Tables[0].DefaultView;
            cbsectorcliente.ValueMember = "descripcion_sector";

            DataSet ds1 = new DataSet();
            SQLiteDataAdapter de = new SQLiteDataAdapter("SELECT descripcion_ciudad FROM ciudad", cnx);
            de.Fill(ds1, "ciudad");
            cbciudadcliente.DataSource = ds1.Tables[0].DefaultView;
            cbciudadcliente.ValueMember = "descripcion_ciudad";

            DataSet ds2 = new DataSet();
            SQLiteDataAdapter df = new SQLiteDataAdapter("SELECT descripcion_estado FROM estado", cnx);
            df.Fill(ds2, "estado");
            cbestadocliente.DataSource = ds2.Tables[0].DefaultView;
            cbestadocliente.ValueMember = "descripcion_estado";
            try
            {
                Bitmap Foto = new Bitmap(tbRutaFoto.Text);
                pictureBox1.Image = (Image)Foto;
            }
            catch (Exception)
            {

            }
        }

        private void btnactualizarcliente_Click(object sender, EventArgs e)
        {
            string codigosector;
            string codigociudad;
            string codigoestado;
            operacion oper = new operacion();
            DataSet ds = new DataSet();
            ds = oper.ConsultaConResultado("SELECT codigo_sector FROM sector WHERE descripcion_sector = '" + cbsectorcliente.Text + "'");
            codigosector = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_ciudad FROM ciudad WHERE descripcion_ciudad = '" + cbciudadcliente.Text + "'");
            codigociudad = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_estado FROM estado WHERE descripcion_estado = '" + cbestadocliente.Text + "'");
            codigoestado = ds.Tables[0].Rows[0][0].ToString();
            if (tbnombrecliente.Text != "" && tbapellidocliente.Text != "" && tbcedulacliente.Text != "" && dtpnacimientocliente.Text != "" && cbsexocliente.Text != "" && tbdireccioncliente.Text != "" && cbsectorcliente.Text != "" && cbciudadcliente.Text != "" && cbestadocliente.Text != "" && tbRutaFoto.Text != "")
            {
                    oper.ConsultaSinResultado("UPDATE cliente SET cedula_cliente = '" + tbcedulacliente.Text.ToString() + "', nombre_cliente = '" + tbnombrecliente.Text.ToString().ToUpper() + "', apellido_cliente = '" + tbapellidocliente.Text.ToString().ToUpper() + "', fecha_nacimiento = '" + dtpnacimientocliente.Text.ToString() + "', direccion_cliente = '" + tbdireccioncliente.Text.ToString().ToUpper() + "', codigo_sector = '" + codigosector + "', codigo_ciudad = '" + codigociudad + "', telefono = '" + tbtelefonocliente.Text.ToString() + "', codigo_estado = '" + codigoestado + "', foto = '" + tbRutaFoto.Text.ToString() + "' WHERE numero_cliente = '" + tbnumerocliente.Text + "'");
                    limpiarcampos();
                    MessageBox.Show("Datos actualizados satisfactoriamente!");
                }
                else MessageBox.Show("Debe completar todos los datos! ");
        }

        private void btnnuevocliente_Click(object sender, EventArgs e)
        {
            tbcedulacliente.Enabled = true;
            tbnombrecliente.Enabled = true;
            tbapellidocliente.Enabled = true;
            dtpnacimientocliente.Enabled = true;
            tbdireccioncliente.Enabled = true;
            cbsectorcliente.Enabled = true;
            cbciudadcliente.Enabled = true;
            tbtelefonocliente.Enabled = true;
            dtpiniciofactura.Enabled = true;
            dtpfinfactura.Enabled = true;
            cbestadocliente.Enabled = true;
            rbserviciovencido.Enabled = true;
            rbservicionovencido.Enabled = true;
            cbsexocliente.Enabled = true;
            btncargarfotocliente.Enabled = true;
            btnguardarcliente.Enabled = true;
        }

        private void btneliminarcliente_Click(object sender, EventArgs e)
        {
            if (tbnumerocliente.Text != "")
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("DELETE FROM cliente WHERE numero_cliente ='" + tbnumerocliente.Text + "'");
                limpiarcampos();
                MessageBox.Show("Cliente eliminado correctamente!");
            }
            else
            {
                MessageBox.Show("Por favor colocar un número de cliente válido!");
                tbnumerocliente.Select();
            }
        }
    }
}
