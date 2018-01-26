using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class CRUDClientes : Form
    {
        operacion oper = new operacion();
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
            string cedula;
            DateTime DTfechahoy = DateTime.Today;
            string fechaHoy = oper.FormatearFecha(DTfechahoy); ;

            DateTime Fechanac = dtpnacimientocliente.Value;
            string fechanacimiento = oper.FormatearFecha(dtpnacimientocliente.Value);
            DateTime Fechaini = dtpiniciofactura.Value;
            string fechainicio = oper.FormatearFecha(dtpiniciofactura.Value);
            DateTime Fechafin = dtpfinfactura.Value;
            string fechafinal = oper.FormatearFecha(dtpfinfactura.Value);
            DataSet ds = new DataSet();
            try
            {
            ds = oper.ConsultaConResultado("SELECT codigo_sector FROM sector WHERE descripcion_sector = '" + cbsectorcliente.Text + "'");
            codigosector = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_ciudad FROM ciudad WHERE descripcion_ciudad = '" + cbciudadcliente.Text + "'");
            codigociudad = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_estado FROM estado WHERE descripcion_estado = '" + cbestadocliente.Text + "'");
            codigoestado = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT cedula_cliente FROM cliente WHERE cedula_cliente = '" + tbcedulacliente.Text + "'");
            try
            {
                cedula = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                cedula = "Cliente Nuevo";
            }

            if (tbnombrecliente.Text != "" && tbapellidocliente.Text != "" && tbcedulacliente.Text != "" && dtpnacimientocliente.Text != "" && cbsexocliente.Text != "" && tbdireccioncliente.Text != "" && cbsectorcliente.Text != "" && cbciudadcliente.Text != "" && cbestadocliente.Text != "" && tbRutaFoto.Text != "" && dtpfinfactura.Text != "" && dtpiniciofactura.Text != "")
            {
                DialogResult Result = MessageBox.Show("Desea conservar las fechas de servicios para este cliente", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    if (cedula == tbcedulacliente.Text)
                    {
                        MessageBox.Show("Este número de cédula ya ha sido registrado anteriormente, favor revisar");
                        return;
                    }
                    else
                    {
                        oper.ConsultaSinResultado("INSERT INTO cliente (cedula_cliente, nombre_cliente, apellido_cliente, fecha_nacimiento, direccion_cliente, codigo_sector, codigo_ciudad, telefono, inicio_periodo, fin_periodo, codigo_estado, foto, sexo) VALUES ('" + tbcedulacliente.Text.ToString() + "','" + tbnombrecliente.Text.ToString().ToUpper() + "','" + tbapellidocliente.Text.ToString().ToUpper() + "','" + fechanacimiento + "','" + tbdireccioncliente.Text.ToString().ToUpper() + "','" + codigosector + "','" + codigociudad + "','" + tbtelefonocliente.Text.ToString() + "','" + fechainicio + "','" + fechafinal + "','" + codigoestado + "', '" + tbRutaFoto.Text.ToString() + "','" + cbsexocliente.Text.ToString().ToUpper() + "')");
                        limpiarcampos();
                        MessageBox.Show("Datos registrados satisfactoriamente!");
                    }
                }
                else
                {
                    if (cedula == tbcedulacliente.Text)
                    {
                        MessageBox.Show("Este número de cédula ya ha sido registrado anteriormente, favor revisar");
                        return;
                    }
                    else
                    {
                        oper.ConsultaSinResultado("INSERT INTO cliente (cedula_cliente, nombre_cliente, apellido_cliente, fecha_nacimiento, direccion_cliente, codigo_sector, codigo_ciudad, telefono, inicio_periodo, fin_periodo, codigo_estado, foto, sexo) VALUES ('" + tbcedulacliente.Text.ToString() + "','" + tbnombrecliente.Text.ToString().ToUpper() + "','" + tbapellidocliente.Text.ToString().ToUpper() + "','" + fechanacimiento + "','" + tbdireccioncliente.Text.ToString().ToUpper() + "','" + codigosector + "','" + codigociudad + "','" + tbtelefonocliente.Text.ToString() + "','" + fechaHoy + "','" + fechaHoy + "','" + codigoestado + "', '" + tbRutaFoto.Text.ToString() + "','" + cbsexocliente.Text.ToString().ToUpper() + "')");
                        limpiarcampos();
                        MessageBox.Show("Datos registrados satisfactoriamente!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos...");
            }
            }
            catch
            {
                MessageBox.Show("Rellene todos los campos...");
            }
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
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT descripcion_sector FROM sector ORDER BY descripcion_sector ", cnx);
            da.Fill(ds, "sector");
            cbsectorcliente.DataSource = ds.Tables[0].DefaultView;
            cbsectorcliente.ValueMember = "descripcion_sector";

            DataSet ds1 = new DataSet();
            SQLiteDataAdapter de = new SQLiteDataAdapter("SELECT descripcion_ciudad FROM ciudad ORDER BY descripcion_ciudad", cnx);
            de.Fill(ds1, "ciudad");
            cbciudadcliente.DataSource = ds1.Tables[0].DefaultView;
            cbciudadcliente.ValueMember = "descripcion_ciudad";

            DataSet ds2 = new DataSet();
            SQLiteDataAdapter df = new SQLiteDataAdapter("SELECT descripcion_estado FROM estado ORDER BY descripcion_estado DESC", cnx);
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
            cbciudadcliente.Text = "";
            cbsectorcliente.Text = "";
        }

        private void btnactualizarcliente_Click(object sender, EventArgs e)
        {
            DateTime Fechanac = dtpnacimientocliente.Value;
            string fechanacimiento = oper.FormatearFecha(dtpnacimientocliente.Value);
            string codigosector;
            string codigociudad;
            string codigoestado;
            DataSet ds = new DataSet();
            ds = oper.ConsultaConResultado("SELECT codigo_sector FROM sector WHERE descripcion_sector = '" + cbsectorcliente.Text + "'");
            codigosector = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_ciudad FROM ciudad WHERE descripcion_ciudad = '" + cbciudadcliente.Text + "'");
            codigociudad = ds.Tables[0].Rows[0][0].ToString();
            ds = oper.ConsultaConResultado("SELECT codigo_estado FROM estado WHERE descripcion_estado = '" + cbestadocliente.Text + "'");
            codigoestado = ds.Tables[0].Rows[0][0].ToString();
            if (tbnombrecliente.Text != "" && tbapellidocliente.Text != "" && tbcedulacliente.Text != "" && dtpnacimientocliente.Text != "" && cbsexocliente.Text != "" && tbdireccioncliente.Text != "" && cbsectorcliente.Text != "" && cbciudadcliente.Text != "" && cbestadocliente.Text != "" && tbRutaFoto.Text != "")
            {
                oper.ConsultaSinResultado("UPDATE cliente SET cedula_cliente = '" + tbcedulacliente.Text.ToString() + "', nombre_cliente = '" + tbnombrecliente.Text.ToString().ToUpper() + "', apellido_cliente = '" + tbapellidocliente.Text.ToString().ToUpper() + "', fecha_nacimiento = '" + fechanacimiento + "', direccion_cliente = '" + tbdireccioncliente.Text.ToString().ToUpper() + "', codigo_sector = '" + codigosector + "', codigo_ciudad = '" + codigociudad + "', telefono = '" + tbtelefonocliente.Text.ToString() + "', codigo_estado = '" + codigoestado + "', foto = '" + tbRutaFoto.Text.ToString() + "' WHERE numero_cliente = '" + tbnumerocliente.Text + "'");
                //limpiarcampos();
                MessageBox.Show("Datos actualizados satisfactoriamente!");
                this.Close();
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
            DataSet ds = new DataSet();
            string conregistro;
            if (tbnumerocliente.Text != "")
            {
                ds = oper.ConsultaConResultado("SELECT id_cliente FROM cabecera_factura WHERE id_cliente = '" + tbnumerocliente.Text + "'");
                try
                {
                    conregistro = ds.Tables[0].Rows[0][0].ToString();
                }
                catch
                {
                    conregistro = "No tiene registros";
                }
                if (conregistro == tbnumerocliente.Text)
                {
                    MessageBox.Show("Este cliente no puede ser eliminado, verifique el número", "Aviso!");
                    return;
                }
                else
                {
                    DialogResult Result = MessageBox.Show("¿Está seguro que desea eliminar este cliente de la base de datos?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (Result == DialogResult.OK)
                    {
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

        private void btnimprimircliente_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = oper.ConsultaConResultado("SELECT numero_cliente, nombre_cliente, apellido_cliente, telefono, fin_periodo, foto FROM cliente WHERE numero_cliente = '" + tbnumerocliente.Text + "'");
                ds.WriteXml("C:\\CGSystem\\CGSystem\\ListaClientes.xml");
                Form f = new VisorReportes("Reporte de Clientes.rpt");
                f.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
