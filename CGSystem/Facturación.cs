using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class Facturación : Form
    {

        //Variables Estáticas necesarias
        public static string ServicioBuscarID = "0";
        public static bool SeleccionDeServicio = false; //Para confirmar si se seleccionó un servicio o si solo se cerró el formulario...
        public static bool SelecciónDeCliente = false; //Para confirmar si se seleccionó un cliente o si solo se cerró el formulario...
        public int contador = 0; //Para controlar algunos métodos...

        //Clases Reutilizables
        operacion oper = new operacion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public int NuevaFila = 0;
        public double TotalFactura = 0;
        public bool ClienteSeleccionado = false;
        public static string NombreCliente = "";
        public static string IdCliente = "";
        public static string NumeroDeFactura = "";

        //Para la fecha
        public DateTime fechaDT = DateTime.Now;
        public string fechaHoy = "";

        //Para el Guardado y Nueva Factura
        public bool FacturaGuardada = false;
        public string TipoFactura = "CONTADO";

        //Para el guardado del detalle
        public string codigo = "";
        public string descripcion = "";
        public string precio = "";
        public string dias = "";
        public string cantidad = "";
        public string total = "";

        public Facturación()
        {
            InitializeComponent();
            NuevaFactura();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Actualizar()
        {
            //Método para actualizar el Data Grid View
            TotalFactura = 0;
            for (int i = 0; i < dgvListaServicios.RowCount; i++)
            {
                dgvListaServicios.Rows[i].Cells[5].Value = Convert.ToInt32(dgvListaServicios.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvListaServicios.Rows[i].Cells[4].Value);
                TotalFactura += Convert.ToInt32(dgvListaServicios.Rows[i].Cells[5].Value);
            }
            tbtotal.Text = "RD$ " + TotalFactura.ToString();
        }

        private void Facturación_Load(object sender, EventArgs e)
        {
            dgvListaServicios.Columns[0].ReadOnly = true;
            dgvListaServicios.Columns[1].ReadOnly = true;
            dgvListaServicios.Columns[2].ReadOnly = true;
            dgvListaServicios.Columns[3].ReadOnly = true;
            dgvListaServicios.Columns[4].ReadOnly = false;
            dgvListaServicios.Columns[5].ReadOnly = true;
        }

        public void AñadirServicioSeleccionado()
        {
            //Con este método se va a añadir a la factura el servicio buscado y seleccionado
            //Cargar la Tabla de todos los servicios activos
            ds = oper.ConsultaConResultado("SELECT * FROM servicio WHERE codigo_servicio = '" + ServicioBuscarID + "';");


            NuevaFila = dgvListaServicios.RowCount; //Escribir sobre la última fila mas uno(+1)...

            dgvListaServicios.Rows.Add();
            for (int k = 0; k < 4; k++)
            {
                dgvListaServicios.Rows[NuevaFila].Cells[k].Value = ds.Tables[0].Rows[0][k].ToString();
            }
            dgvListaServicios.Rows[NuevaFila].Cells[4].Value = "1"; //Asignar cantidad 1 como predeterminada...
            Actualizar();
        }

        private void tbproducto_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    Buscar();
            //}
            //else { }
        }

        public void Buscar()
        {
            //Llamar al formulario de Seleccionar Servicio
            Form f = new SeleccionarServicio();
            SeleccionarServicio.NombreABuscar = tbproducto.Text;//Asignar la palabra clave a buscar/filtrar
            f.ShowDialog();

            if (SeleccionDeServicio)//Comprobar si se seleccionó un servicio...
            {
                AñadirServicioSeleccionado();
                tbproducto.Text = "";
                tbproducto.Focus();
            }
            else { }
        }

        private void tbproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                Buscar();
            }
            else { }

        }

        private void chkbcontado_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCheckBox();
        }

        public void ActualizarCheckBox()
        {
            if (contador < 1)
            {
                if (rdContado.Checked)
                {
                    tbcliente.Enabled = true;
                    tbcliente.Text = "";
                    tbidcliente.Text = "";
                    ClienteSeleccionado = false;
                }
                else
                {
                    //Validar si hay un cliente válido seleccionado, en caso contrario abrir el formulario de selección de cliente.
                    try
                    {
                        if (tbidcliente.Text != "0" && Convert.ToInt32(tbidcliente.Text) < 1)
                        {
                            tbcliente.Text = "";
                            tbidcliente.Text = "";
                            BuscarCliente();
                        }
                        else
                        {
                        }
                    }
                    catch
                    {
                        tbcliente.Text = "";
                        tbidcliente.Text = "";
                        BuscarCliente();
                    }



                    tbcliente.Enabled = false;
                }
                contador++;
            }
            else
            {
                contador = 0; //Para reiniciar el contador y así funcione la próxima vez...
            }
        }


        private void rdContado_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCheckBox();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        public void BuscarCliente()
        {
            //Buscar un cliente mostrando el formulario de selección
            ListaDeClientes.Seleccionando = true;
            Form f = new ListaDeClientes();
            f.ShowDialog();

            try
            {
                if (SelecciónDeCliente || tbidcliente.Text != "0" || tbidcliente.Text != "")
                {
                    tbcliente.Text = NombreCliente;
                    tbidcliente.Text = IdCliente;
                    SelecciónDeCliente = false;
                }
                else
                {
                    rdContado.PerformClick();
                }
            }
            catch
            {
            }
        }

        private void rdCredito_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCheckBox();
        }

        private void btneliminiar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvListaServicios.Rows.RemoveAt(dgvListaServicios.CurrentRow.Index);
                Actualizar();
            }
            catch
            {
            }
        }

        private void dgvListaServicios_ControlRemoved(object sender, ControlEventArgs e)
        {
            Actualizar();
        }

        private void dgvListaServicios_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Actualizar();
        }

        private void dgvListaServicios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Actualizar();
        }


        public void NuevaFactura()
        {
            try
            {
                if (dgvListaServicios.RowCount > 0 && !FacturaGuardada)
                {
                    bool ReiniciarFactura = oper.CajaDeMensaje("La factura actual no ha sido guardada ¿Desea desecharla?", "Aviso");
                    if (ReiniciarFactura)
                    {

                    }
                    else { return; }
                }


                //Vaciar todo y dejar la factura como nueva...
                fechaDT = DateTime.Now;
                fechaHoy = oper.FormatearFecha(fechaDT);
                lbfecha.Text = fechaHoy;
                dgvListaServicios.Rows.Clear();
                rdContado.PerformClick();
                tbproducto.Clear();
                FacturaGuardada = false;
                Actualizar();

                //Conseguir el mayor número de factura y asignarlo a la factura actual
                ds = oper.ConsultaConResultado("SELECT MAX(numero_factura) value FROM factura;");
                NumeroDeFactura = (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                lbnumfactura.Text = "No. Factura: " + NumeroDeFactura;
            }
            catch
            {
                MessageBox.Show("Error al crear nueva factura, contacte al técnico del sistema, disculpe los inconvenientes", "Aviso");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevaFactura();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            GuardarFactura();
        }

        public void GuardarFactura()
        {
            try
            {
                //Método para realizar el guardado de la factura...

                //Establecer si es a Crédito o al Contado
                TipoFactura = SaberTipoFactura();
                //Obtener el código del tipo de factura actual
                ds = oper.ConsultaConResultado("SELECT codigo_tipo_factura FROM tipo_factura WHERE descripcion_tipo_factura = '" + TipoFactura + "';");
                TipoFactura = ds.Tables[0].Rows[0][0].ToString();

                //Primero Guardamos la cabecera de la factura
                oper.ConsultaSinResultado("INSERT INTO factura (id_factura, id_tipo_factura, id_cliente, fecha," +
                    "total, id_tipo_ingreso) VALUES ('" + NumeroDeFactura + "', '" + TipoFactura + "'," +
                    "'" + IdCliente + "', '" + fechaHoy + "', '" + TotalFactura.ToString() + "', 'EFECTIVO');");

                //Ahora guardamos el detalle de la facutra con el bucle siguiente
                for (int i = 0; i < dgvListaServicios.RowCount; i++)
                {

                    codigo = dgvListaServicios.Rows[i].Cells[0].Value.ToString();
                    descripcion = dgvListaServicios.Rows[i].Cells[1].Value.ToString();
                    precio = dgvListaServicios.Rows[i].Cells[2].Value.ToString();
                    dias = dgvListaServicios.Rows[i].Cells[3].Value.ToString();
                    cantidad = dgvListaServicios.Rows[i].Cells[4].Value.ToString();
                    total = dgvListaServicios.Rows[i].Cells[5].Value.ToString();

                    oper.ConsultaSinResultado("INSERT INTO detalle_factura (id_factura, codigo, descripcion, precio, dias, cantidad, total) " +
                        "VALUES ('" + NumeroDeFactura + "', '" + codigo + "', '" + descripcion + "', '" + precio + "'" +
                        ", '" + dias + "', '" + cantidad + "', '" + total + "');");
                }

            }
            catch
            {
                MessageBox.Show("Hubo un error al tratar de guardar la factura, contacte al " +
                    "encargado de mantenimiento del sistema, disculpe los inconvenientes...", "Aviso");
            }
        }

        public string SaberTipoFactura()
        {
            string tipo;

            if (rdContado.Checked)
            {
                tipo = "CONTADO";
            }
            else
            {
                tipo = "CREDITO";
            }

            return tipo;
        }

    }

}
