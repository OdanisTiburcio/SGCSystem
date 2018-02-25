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
    public partial class CRUDIngresos : Form
    {
        operacion oper = new operacion();
        public CRUDIngresos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btbuscaringreso_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
                cnx.Open();
                if (rbtodosingresos.Checked)
                {
                    string consulta = "SELECT ing.codigo_ingreso Código, tip.descripcion_tipo_ingreso Tipo, cab.id_factura No_Factura, ing.monto_ingreso Monto, ing.fecha Fecha FROM ingreso ing INNER JOIN tipo_ingreso tip ON tip.codigo_tipo_ingreso = ing.codigo_tipo_ingreso INNER JOIN cabecera_factura cab ON cab.id_factura = ing.numero_factura WHERE ing.estado = 'ACTIVO';";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dgvdetalleingresos.DataSource = dt;
                    cnx.Close();
                }
                else if (rbcodigoingreso.Checked)
                {
                    string consulta = "SELECT ing.codigo_ingreso Código, tip.descripcion_tipo_ingreso Tipo, cab.id_factura No_Factura, ing.monto_ingreso Monto, ing.fecha Fecha FROM ingreso ing INNER JOIN tipo_ingreso tip ON tip.codigo_tipo_ingreso = ing.codigo_tipo_ingreso INNER JOIN cabecera_factura cab ON cab.id_factura = ing.numero_factura WHERE ing.codigo_ingreso = '" + tbseleccion.Text + "' AND ing.estado = 'ACTIVO';";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dgvdetalleingresos.DataSource = dt;
                    cnx.Close();
                }
                else if (rbnumerofact.Checked)
                {
                    string consulta = "SELECT ing.codigo_ingreso Código, tip.descripcion_tipo_ingreso Tipo, cab.id_factura No_Factura, ing.monto_ingreso Monto, ing.fecha Fecha FROM ingreso ing INNER JOIN tipo_ingreso tip ON tip.codigo_tipo_ingreso = ing.codigo_tipo_ingreso INNER JOIN cabecera_factura cab ON cab.id_factura = ing.numero_factura WHERE ing.numero_factura = '" + tbseleccion.Text + "' AND ing.estado = 'ACTIVO'";
                    SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dgvdetalleingresos.DataSource = dt;
                    cnx.Close();
                }
                else
                {
                    DateTime desde = dtpIngresodesde.Value;
                    DateTime hasta = dtpIngresohasta.Value;
                    string fechadesde = oper.FormatearFecha(dtpIngresodesde.Value);
                    string fechahasta = oper.FormatearFecha(dtpIngresohasta.Value);
                    try
                    {
                        string consulta = "SELECT ing.codigo_ingreso Código, tip.descripcion_tipo_ingreso Tipo, cab.id_factura No_Factura, ing.monto_ingreso Monto, ing.fecha Fecha FROM ingreso ing INNER JOIN tipo_ingreso tip ON tip.codigo_tipo_ingreso = ing.codigo_tipo_ingreso INNER JOIN cabecera_factura cab ON cab.id_factura = ing.numero_factura WHERE ing.fecha BETWEEN '" + fechadesde + "' AND '" + fechahasta + "' AND ing.estado = 'ACTIVO';;";
                        SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
                        DataSet ds = new DataSet();
                        ds.Reset();
                        DataTable dt = new DataTable();
                        db.Fill(ds);
                        dt = ds.Tables[0];
                        dgvdetalleingresos.DataSource = dt;
                        cnx.Close();
                    }
                    catch (Exception) { }
                }
            }
            catch (Exception)
            {

            }
        }

        private void bntimprimiringreso_Click(object sender, EventArgs e)
        {

        }

        public void ImprimirIngresoSeleccionado()
        {
            try
            {
                if (dgvdetalleingresos.SelectedRows.Count == 1) //Validar que se halla selecionado un (1) ingreso...
                {
                    //Imprimir este ingreso...
                }
                else
                {
                    MessageBox.Show("Seleccione el ingreso que desea imprimir...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
        }

        private void CRUDIngresos_Load(object sender, EventArgs e)
        {
            dtpIngresodesde.Value = DateTime.Today;
            dtpIngresohasta.Value = DateTime.Today;
            if (MenuPrincipal.TipoUsuario == 1)
            {
                btneliminaringreso.Enabled = true;
            }
            else
            {
                btneliminaringreso.Enabled = false;
            }

        }

        private void btneliminaringreso_Click(object sender, EventArgs e)
        {
            string ingresoid = "";
            try
            {   
                
                if (dgvdetalleingresos.SelectedRows.Count == 1)
                {
                    bool EliminarIngreso = oper.CajaDeMensaje("¿Desea eliminar el ingreso seleccionado?", "Eliminar Ingreso");
                    if (EliminarIngreso)
                    {
                        string ingresonumfactura = dgvdetalleingresos.CurrentRow.Cells[2].Value.ToString();
                        ingresoid = dgvdetalleingresos.CurrentRow.Cells[0].Value.ToString();
                        string ingresomonto = dgvdetalleingresos.CurrentRow.Cells[3].Value.ToString();

                        //Buscar el valor actual de la fctura cxc seleccionada
                        DataSet ds = oper.ConsultaConResultado("SELECT cxc.restante FROM cxc WHERE cxc.id_factura = '" + ingresonumfactura + "' AND cxc.estado_cxc != 'DESACTIVADO';");
                        string viejomonto = ds.Tables[0].Rows[0][0].ToString();

                        //Desactivar el ingreso
                        oper.ConsultaSinResultado("UPDATE ingreso SET estado = 'DESACTIVADO' WHERE codigo_ingreso = '" + ingresoid + "';");

                        //Sumarle al valor restante actual el valor del ingreso
                        string nuevomonto = (Convert.ToDouble(ingresomonto) + Convert.ToDouble(viejomonto)).ToString();
                        oper.ConsultaConResultado("UPDATE cxc SET restante = '" + nuevomonto + "' WHERE id_factura = '" + ingresonumfactura + "';");

                        //Si la cuenta estaba saldada; devolverla a cuentas por cobrar...
                        if (viejomonto == "0")
                        {
                            oper.ConsultaConResultado("UPDATE cxc SET estado_cxc = 'ACTIVO' WHERE id_factura = '" + ingresonumfactura + "';");
                            MessageBox.Show("La factura afectada fue devuelta a \"Cuentas por Cobrar\"...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                        }

                        dgvdetalleingresos.Rows.RemoveAt(dgvdetalleingresos.CurrentRow.Index);

                    }
                    else
                    {
                        
                    }
                }


            }
            catch
            {
                MessageBox.Show("La factura enlazada fue eliminada, se desactivará el ingreso de todas formas...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oper.ConsultaSinResultado("UPDATE ingreso SET estado = 'DESACTIVADO' WHERE codigo_ingreso = '" + ingresoid + "';");
                dgvdetalleingresos.Rows.RemoveAt(dgvdetalleingresos.CurrentRow.Index);
            }

        }
    }
}
