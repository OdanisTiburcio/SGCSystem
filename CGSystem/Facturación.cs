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
        public static bool ModificarFactura = false; //Para confirmar si se seleccionó una factura para modificar...
        public static int FacturaModificarNum = 0;
        public int contador = 0; //Para controlar algunos métodos...
        public int DiasASumar = 0;
        public string[] PlusModificando = new string[100];
        public string[] EliminadosModificando = new string[100];
        public int CountDown = 0;
        public int CountPlus = 0;
        public int SavedRowCount = 0;
        public string SavedNombreCliente = "Cliente";
        public string SavedIdCliente = "";
        public bool SavedTipoFacturaCrédito = false;
        public string CódigoDetalleElim;
        public bool FacturaModificadaGuardada = true;
        public int ModDiasARestar = 0;
        public int ModDiasASumar = 0;
        public bool cargandofactura = false;

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
        public bool Actualizando = false;
        public static bool modificandofactura = false;

        //Para la fecha
        public DateTime fechaDT = DateTime.Now;
        public string fechaHoy = "";

        //Para el Guardado y Nueva Factura
        public bool FacturaGuardada = false;
        public string TipoFactura = "CONTADO";

        //Para el guardado del detalle
        public string codigodetalle = "";
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
            int ErrorControler = 0;
            try
            {
                //Método para actualizar el Data Grid View
                Actualizando = true;
                TotalFactura = 0;
                contador = 0;
                DiasASumar = 0;
                for (int i = 0; i < dgvListaServicios.RowCount; i++)
                {
                    dgvListaServicios.Rows[i].Cells[0].Value = (contador + 1).ToString(); //Asignar la numeración al detalle

                    contador++;
                    ErrorControler = i;
                    dgvListaServicios.Rows[i].Cells[6].Value = Convert.ToInt32(dgvListaServicios.Rows[i].Cells[3].Value) * Convert.ToInt32(dgvListaServicios.Rows[i].Cells[5].Value);//Precio por Cantidad =  Total
                    TotalFactura += Convert.ToInt32(dgvListaServicios.Rows[i].Cells[6].Value);
                    DiasASumar += (Convert.ToInt32(dgvListaServicios.Rows[i].Cells[4].Value) * Convert.ToInt32(dgvListaServicios.Rows[i].Cells[5].Value)); //días por cantidad = total dias a sumar del detalle actual...
                }
                tbtotal.Text = "RD$ " + TotalFactura.ToString();
                Actualizando = false;
            }
            catch
            {
                MessageBox.Show("Indique una cantidad válida para el detalle No.: " + (ErrorControler + 1).ToString() + "...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListaServicios.Rows[ErrorControler].Cells[5].Value = "1";
            }
        }

        private void Facturación_Load(object sender, EventArgs e)
        {
            ////string test1 = oper.SumarAlaFecha("2017-07-12", 55);
            //ds = oper.ConsultaConResultado("SELECT fin_periodo FROM cliente WHERE numero_cliente = '2';");
            //string FinPeriodoAnterior = ds.Tables[0].Rows[0][0].ToString();
            //FinPeriodoAnterior = oper.SumarAlaFecha(FinPeriodoAnterior, 55);

            NuevaFactura();
            dgvListaServicios.Columns[0].ReadOnly = true;
            dgvListaServicios.Columns[1].ReadOnly = true;
            dgvListaServicios.Columns[2].ReadOnly = true;
            dgvListaServicios.Columns[3].ReadOnly = true;
            dgvListaServicios.Columns[4].ReadOnly = true;
            dgvListaServicios.Columns[5].ReadOnly = false; //Esta columna se deja en modo escritura para que se pueda cambiar la "Cantidad" de Servicios...
            dgvListaServicios.Columns[6].ReadOnly = true;
        }

        public void AñadirServicioSeleccionado()
        {

            //Con este método se va a añadir a la factura el servicio buscado y seleccionado
            ds = oper.ConsultaConResultado("SELECT * FROM servicio WHERE codigo_servicio = '" + ServicioBuscarID + "';");

            NuevaFila = dgvListaServicios.RowCount; //Escribir sobre la última fila mas uno(+1)...

            dgvListaServicios.Rows.Add();
            for (int k = 0; k < 4; k++)
            {
                dgvListaServicios.Rows[NuevaFila].Cells[k + 1].Value = ds.Tables[0].Rows[0][k].ToString();
            }
            dgvListaServicios.Rows[NuevaFila].Cells[5].Value = "1"; //Asignar cantidad 1 como predeterminada...
            Actualizar();
            FacturaModificadaGuardada = false;

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
            //ActualizarCheckBox();
        }

        public void ActualizarCheckBox()
        {
            //Método Descontinuado
        }


        private void rdContado_CheckedChanged(object sender, EventArgs e)
        {
            //ActualizarCheckBox();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        public void BuscarCliente()
        {
            //Buscar un cliente mostrando el formulario de selección
            Form f = new SeleccionarCliente();
            f.ShowDialog();

            try
            {
                if (SelecciónDeCliente)
                {
                    tbcliente.Text = NombreCliente;
                    tbidcliente.Text = IdCliente;
                    SelecciónDeCliente = false;
                }
                else
                {
                }
            }
            catch
            {
            }

        }

        private void rdCredito_CheckedChanged(object sender, EventArgs e)
        {
            //ActualizarCheckBox();
        }

        private void btneliminiar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvListaServicios.Rows.RemoveAt(this.dgvListaServicios.SelectedRows[0].Index);
                
                Actualizar();
            }
            catch
            {
                MessageBox.Show("Hubo un error al intentar eliminar el detalle...", "Aviso", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
            }
        }

        private void dgvListaServicios_ControlRemoved(object sender, ControlEventArgs e)
        {

            if (!Actualizando) //Comprobar que no se esté actualizando ya...
            {
                Actualizar();
            }
            else
            {
            }

        }

        private void dgvListaServicios_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            dgvListaServicios.Refresh();
        }

        private void dgvListaServicios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (!Actualizando) //Comprobar que no se esté actualizando ya...
            {
                Actualizando = true;
                Actualizar();
                Actualizando = false;
            }
            else
            {
            }
        }


        public void NuevaFactura()
        {
            try
            {
                if (modificandofactura)
                {
                    if (!FacturaModificadaGuardada)
                    {
                        if (dgvListaServicios.RowCount != SavedRowCount || tbidcliente.Text != SavedIdCliente || SavedTipoFacturaCrédito != rdCredito.Checked)
                        {
                            bool ReiniciarFactura = oper.CajaDeMensaje("La factura actual no ha sido guardada ¿Desea desecharla?", "Aviso");
                            if (ReiniciarFactura)
                            {

                            }
                            else { return; }
                        }
                    }
                    else
                    {
                        //No ha sido guardada pero tampoco modificada...
                    }
                }
                else
                {
                    if (dgvListaServicios.RowCount > 0 && !FacturaGuardada)
                    {
                        bool ReiniciarFactura = oper.CajaDeMensaje("La factura actual no ha sido guardada ¿Desea desecharla?", "Aviso");
                        if (ReiniciarFactura)
                        {

                        }
                        else { return; }
                    }
                }

                //Devolver a la actividad los botones desactivados por el guardado de factura...
                dgvListaServicios.Columns[5].ReadOnly = false;
                btnsearch.Enabled = true;
                btbuscar.Enabled = true;
                rdContado.Enabled = true;
                rdCredito.Enabled = true;
                tbproducto.Enabled = true;
                btnguardar.Enabled = true;
                btnimprimir.Enabled = false;
                FacturaGuardada = false;
                btneliminiar.Enabled = true;
                modificandofactura = false;
                PlusModificando = new string[100];
                EliminadosModificando = new string[100];
                CountDown = 0;
                CountPlus = 0;
                SavedRowCount = 0;
                ModDiasARestar = 0;
                ModDiasASumar = 0;


                //Vaciar todo y dejar la factura como nueva...
                fechaDT = DateTime.Now;
                fechaHoy = oper.FormatearFecha(fechaDT);
                lbfecha.Text = fechaHoy;
                dgvListaServicios.Rows.Clear();
                rdContado.PerformClick();
                tbproducto.Clear();
                FacturaGuardada = false;
                tbcliente.Text = "Cliente";
                tbidcliente.Clear();
                contador = 0;
                Actualizar();

                //Conseguir el mayor número de factura y asignarlo a la factura actual
                ds = oper.ConsultaConResultado("SELECT MAX(id_factura) value FROM cabecera_factura;");
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
            if (modificandofactura)
            {
                //Comprobar que existan cambios en la factura...

                if (dgvListaServicios.RowCount != SavedRowCount || tbidcliente.Text != SavedIdCliente || SavedTipoFacturaCrédito != rdCredito.Checked)
                {
                    //Continuar...
                }
                else
                {
                    MessageBox.Show("No hay cambios para guardar en esta factura...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Confirmar que hay un cliente seleccionado
                if (tbidcliente.Text == "" && tbcliente.Text == "Cliente")
                {
                    BuscarCliente();
                    if (tbidcliente.Text == "" && tbcliente.Text == "Cliente")
                    {
                        MessageBox.Show("Debe seleccionar un cliente para poder procesar los servicios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else { }
                }
                else { }

                try
                {
                    //Método para realizar el guardado de la factura modificada...

                    //Actualizar DataGridView para Corroborar los valores...
                    Actualizar();

                    //Establecer si es a Crédito o al Contado
                    TipoFactura = SaberTipoFactura();

                    //Obtener el código del tipo de factura actual
                    ds = oper.ConsultaConResultado("SELECT codigo_tipo_factura FROM tipo_factura WHERE descripcion_tipo_factura = '" + TipoFactura + "';");
                    TipoFactura = ds.Tables[0].Rows[0][0].ToString();

                    //Primero Actualizamos la cabecera de la factura
                    oper.ConsultaSinResultado("UPDATE cabecera_factura SET id_tipo_factura = '" + TipoFactura + "', id_cliente = '" + IdCliente + "', " +
                        "total = '" + TotalFactura.ToString() + "' WHERE id_factura = '" + NumeroDeFactura + "';");

                    DiasASumar = 0;

                    //Ahora insertamos los detalles añadidos...
                    for (int i = 0; i < CountPlus; i++)
                    {
                        codigodetalle = dgvListaServicios.Rows[i].Cells[0].Value.ToString(); //Numeracion de la actual...

                        //Verificar que la fila analizada sea del grupo de las añadidas
                        for (int k = 0; k < 100; k++)
                        {
                            if (PlusModificando[k] == codigodetalle)
                            {
                                codigo = dgvListaServicios.Rows[i].Cells[1].Value.ToString();
                                descripcion = dgvListaServicios.Rows[i].Cells[2].Value.ToString();
                                precio = dgvListaServicios.Rows[i].Cells[3].Value.ToString();
                                dias = dgvListaServicios.Rows[i].Cells[4].Value.ToString();
                                cantidad = dgvListaServicios.Rows[i].Cells[5].Value.ToString();
                                total = dgvListaServicios.Rows[i].Cells[6].Value.ToString();

                                oper.ConsultaSinResultado("INSERT INTO detalle_factura (id_detalle, id_factura, codigo, descripcion, precio, dias, cantidad, total, estado) " +
                                    "VALUES ('" + codigodetalle + "', '" + NumeroDeFactura + "', '" + codigo + "', '" + descripcion + "', '" + precio + "'" +
                                    ", '" + dias + "', '" + cantidad + "', '" + total + "', 'ACTIVO');");

                                k = 101;
                                ModDiasASumar += (Convert.ToInt32(dias) * Convert.ToInt32(cantidad)); //Solo se sumaran los dias añadidos nuevos 
                            }
                            else
                            {

                            }
                        }
                    }

                    //Ahora Desactivamos los detalles eliminados...
                    for (int i = 0; i < CountDown; i++)
                    {
                        oper.ConsultaSinResultado("UPDATE detalle_factura SET estado = 'DESACTIVADO' WHERE detalle_factura.id_detalle = '" + EliminadosModificando[i] + "' AND detalle_factura.id_factura = '" + NumeroDeFactura + "';");
                    }

                    //Renovar Numeracion...                    
                    string ActualFilaCode = "0";
                    int NumeradorNuevo = 1;
                    for (int i = 0; i < dgvListaServicios.RowCount; i++)
                    {
                        ActualFilaCode = dgvListaServicios.Rows[i].Cells[0].Value.ToString();
                        oper.ConsultaSinResultado("UPDATE detalle_factura SET id_detalle = '" + NumeradorNuevo.ToString() + "' WHERE id_detalle = '" + ActualFilaCode + "';");
                        dgvListaServicios.Rows[i].Cells[0].Value = NumeradorNuevo.ToString();
                        NumeradorNuevo++;
                    }


                    if (rdCredito.Checked)//Si la factura es a crédito, generar una cuenta por cobrar de la factura actual al cliente correspondiente...
                    {
                        GenerarCXC(); //Actualizar el cxc...
                    }
                    else
                    {
                        if (SavedTipoFacturaCrédito) //Si la factura anteriormente era a credito; desactivar la cuenta por cobrar anteriormente generada...
                        {
                            oper.ConsultaSinResultado("UPDATE cxc SET estado_cxc = 'DESACTIVADO' WHERE id_factura = '" + NumeroDeFactura + "';");
                        }
                        else
                        {

                        }
                    }

                    MessageBox.Show("Dias a sumar: " + ModDiasASumar.ToString() + ". Y los dias a restar son: " + ModDiasARestar.ToString());
                    ActualizarPeriodoDeClienteModificado();//Sumarle los días facturados a la membresía del cliente y restarle los eliminados.
                    FacturaModificadaGuardada = true;
                    CerrarFactura(); //Método para activar y desactivar los botonoes necesarios hasta la próxima factura...
                }
                catch
                {
                    MessageBox.Show("Hubo un error al tratar de guardar la factura modificada, contacte al " +
                        "encargado de mantenimiento del sistema, disculpe los inconvenientes...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {

                //Validar que hallan datos para facturar
                if (dgvListaServicios.RowCount == 0)
                {
                    MessageBox.Show("No hay nada para guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else { }

                //Confirmar que hay un cliente seleccionado
                if (tbidcliente.Text == "" && tbcliente.Text == "Cliente")
                {
                    BuscarCliente();
                    if (tbidcliente.Text == "" && tbcliente.Text == "Cliente")
                    {
                        MessageBox.Show("Debe seleccionar un cliente para poder procesar los servicios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else { }
                }
                else { }

                try
                {
                    //Método para realizar el guardado de la factura...

                    //Actualizar DataGridView para Corroborar los valores...
                    Actualizar();

                    //Establecer si es a Crédito o al Contado
                    TipoFactura = SaberTipoFactura();

                    //Obtener el código del tipo de factura actual
                    ds = oper.ConsultaConResultado("SELECT codigo_tipo_factura FROM tipo_factura WHERE descripcion_tipo_factura = '" + TipoFactura + "';");
                    TipoFactura = ds.Tables[0].Rows[0][0].ToString();

                    //Primero Guardamos la cabecera de la factura
                    oper.ConsultaSinResultado("INSERT INTO cabecera_factura (id_factura, id_tipo_factura, id_cliente, id_empleado, fecha," +
                        "total, estado) VALUES ('" + NumeroDeFactura + "', '" + TipoFactura + "'," +
                        "'" + IdCliente + "', '" + MenuPrincipal.UsuarioID.ToString() + "', '" + fechaHoy + "', '" + TotalFactura.ToString() + "', 'ACTIVO');");

                    //Ahora guardamos el detalle de la facutra con el bucle siguiente
                    for (int i = 0; i < dgvListaServicios.RowCount; i++)
                    {

                        codigodetalle = dgvListaServicios.Rows[i].Cells[0].Value.ToString();
                        codigo = dgvListaServicios.Rows[i].Cells[1].Value.ToString();
                        descripcion = dgvListaServicios.Rows[i].Cells[2].Value.ToString();
                        precio = dgvListaServicios.Rows[i].Cells[3].Value.ToString();
                        dias = dgvListaServicios.Rows[i].Cells[4].Value.ToString();
                        cantidad = dgvListaServicios.Rows[i].Cells[5].Value.ToString();
                        total = dgvListaServicios.Rows[i].Cells[6].Value.ToString();

                        oper.ConsultaSinResultado("INSERT INTO detalle_factura (id_detalle, id_factura, codigo, descripcion, precio, dias, cantidad, total, estado) " +
                            "VALUES ('" + codigodetalle + "', '" + NumeroDeFactura + "', '" + codigo + "', '" + descripcion + "', '" + precio + "'" +
                            ", '" + dias + "', '" + cantidad + "', '" + total + "', 'ACTIVO');");
                    }

                    if (rdCredito.Checked)//Si la factura es a crédito, generar una cuenta por cobrar de la factura actual al cliente correspondiente...
                    {
                        GenerarCXC();
                    }
                    else { }

                    ActualizarPeriodoDeCliente();//Sumarle los días facturados a la membresía del cliente.
                    CerrarFactura(); //Método para activar y desactivar los botonoes necesarios hasta la próxima factura...
                }
                catch
                {
                    MessageBox.Show("Hubo un error al tratar de guardar la factura, contacte al " +
                        "encargado de mantenimiento del sistema, disculpe los inconvenientes...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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


        public void GenerarCXC()
        {
            try
            {
                if (modificandofactura)
                {
                    if (SavedTipoFacturaCrédito)//Si la factura era a credito, actualizar...
                    {
                        ds = oper.ConsultaConResultado("SELECT total_factura, restante FROM cxc WHERE id_factura = '" + NumeroDeFactura + "';");
                        double Diferencia = Convert.ToDouble(ds.Tables[0].Rows[0][0]) - Convert.ToDouble(ds.Tables[0].Rows[0][1]);
                        string Restante = (TotalFactura - Convert.ToDouble(Diferencia)).ToString();
                        oper.ConsultaSinResultado("UPDATE cxc SET total_factura = '" + TotalFactura.ToString() + "', restante = '" + Restante + "' WHERE id_factura = '" + NumeroDeFactura + "';");
                    }
                    else //Si era al contado, generar cuenta por cobrar nueva...
                    {
                        oper.ConsultaSinResultado("INSERT INTO cxc (id_factura, total_factura, restante, estado_cxc) VALUES ('" + NumeroDeFactura + "'," +
                        "'" + TotalFactura.ToString() + "', '" + TotalFactura.ToString() + "', 'ACTIVO');");
                    }
                }
                else
                {
                    oper.ConsultaSinResultado("INSERT INTO cxc (id_factura, total_factura, restante, estado_cxc) VALUES ('" + NumeroDeFactura + "'," +
                        "'" + TotalFactura.ToString() + "', '" + TotalFactura.ToString() + "', 'ACTIVO');");
                }
            }
            catch
            {
                MessageBox.Show("Hubo un problema al tratar de generar la Cuenta Por Cobrar de la factura actual", "Error");
            }

        }

        public void ActualizarPeriodoDeCliente()
        {
            try
            {
                //Sumar los días adquiridos al fin de periodo del cliente
                ds = oper.ConsultaConResultado("SELECT codigo_estado FROM cliente WHERE numero_cliente = '" + IdCliente + "'");
                string estado = ds.Tables[0].Rows[0][0].ToString();
                if (estado == "1") //Validar la vigencia del servicio... si no está vigente, se genera a partir de ahora...
                {
                    ds = oper.ConsultaConResultado("SELECT strftime('%Y-%m-%d', fin_periodo) FROM cliente WHERE numero_cliente = '" + IdCliente + "';");
                    string FinPeriodoAnterior = ds.Tables[0].Rows[0][0].ToString();
                    string FechaFinPeriodo = oper.SumarAlaFecha(FinPeriodoAnterior, DiasASumar);
                    oper.ConsultaSinResultado("UPDATE cliente SET fin_periodo = '" + FechaFinPeriodo + "' WHERE numero_cliente = '" + IdCliente + "';");
                }
                else //No Vigente, a partir del día de hoy...
                {
                    fechaDT = DateTime.Now;
                    fechaHoy = oper.FormatearFecha(fechaDT);

                    string FechaFinPeriodo = oper.SumarAlaFecha(fechaHoy, DiasASumar);
                    oper.ConsultaSinResultado("UPDATE cliente SET inicio_periodo = '" + fechaHoy + "', fin_periodo = '" + FechaFinPeriodo + "', codigo_estado = '1' WHERE numero_cliente = '" + IdCliente + "';");
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error al generar el mantenimiento al periodo del cliente, contacte al servicio técnico...", "Error");
            }

        }

        public void ActualizarPeriodoDeClienteModificado()
        {
            try
            {

                //Sumar los días añadidos al fin de periodo del cliente
                ds = oper.ConsultaConResultado("SELECT strftime('%Y-%m-%d', fin_periodo) FROM cliente WHERE numero_cliente = '" + IdCliente + "';");
                string FinPeriodoAnterior = ds.Tables[0].Rows[0][0].ToString();
                string FechaFinPeriodo = oper.SumarAlaFecha(FinPeriodoAnterior, DiasASumar);
                oper.ConsultaSinResultado("UPDATE cliente SET fin_periodo = '" + FechaFinPeriodo + "' WHERE numero_cliente = '" + IdCliente + "';");

            }
            catch
            {
                MessageBox.Show("Hubo un error al generar el mantenimiento al periodo del cliente, contacte al servicio técnico...", "Error");
            }

        }


        public void CerrarFactura()
        {
            //Cerrar la factura generada para que quede inmodificable, a excepción de los usuarios con permisos por medio del botón modificar...
            dgvListaServicios.Columns[5].ReadOnly = true;
            btnsearch.Enabled = false;
            btbuscar.Enabled = false;
            rdContado.Enabled = false;
            rdCredito.Enabled = false;
            tbproducto.Enabled = false;
            btnguardar.Enabled = false;
            btnimprimir.Enabled = true;
            btneliminiar.Enabled = false;

            FacturaGuardada = true;//Para afirmar que la factura actual ya ha sido guardada
            FacturaModificadaGuardada = true;

            bool aceptar = oper.CajaDeMensaje("¡Guardada Exitosamente! ¿Desea Imprimir la Factura Actual?", "Facturar"); //Ver si el cliente imprimirá el bolante...
            if (aceptar)
            {
                Imprimir();
            }
            else
            {
            }

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        public void Imprimir()
        {
            try
            {
                //Abrir el Formulario visor de reporte de Impresión de Factura....
                ds = oper.ConsultaConResultado("SELECT cabecera_factura.id_factura, tipo_factura.descripcion_tipo_factura as id_tipo_factura, cliente.nombre_cliente as id_cliente, empleado.nombre as id_empleado, cabecera_factura.fecha, cabecera_factura.total, cabecera_factura.estado FROM cabecera_factura left join tipo_factura, cliente, empleado on cabecera_factura.id_tipo_factura = tipo_factura.codigo_tipo_factura and cabecera_factura.id_cliente = cliente.numero_cliente and cabecera_factura.id_empleado = empleado.numero_empleado WHERE id_factura = '" + NumeroDeFactura + "'");
                ds.WriteXml("C:\\CGSystem\\CGSystem\\CabeceraFactura.xml");
                ds = oper.ConsultaConResultado("SELECT * FROM detalle_factura WHERE id_factura = '" + NumeroDeFactura + "'");
                ds.WriteXml("C:\\CGSystem\\CGSystem\\detalle_factura.xml");
                Form f = new VisorReportes("Factura.rpt");
                f.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Hubo un error al intentar Imprimir la factura", "Aviso");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //NuevaFactura();

            if (modificandofactura)
            {
                if (!FacturaModificadaGuardada)
                {
                    if (dgvListaServicios.RowCount != SavedRowCount || tbidcliente.Text != SavedIdCliente || SavedTipoFacturaCrédito != rdCredito.Checked)
                    {
                        bool ReiniciarFactura = oper.CajaDeMensaje("La factura actual no ha sido guardada ¿Desea desecharla?", "Aviso");
                        if (ReiniciarFactura)
                        {

                        }
                        else { return; }
                    }
                }
                else
                {
                    //No ha sido guardada pero tampoco modificada...
                }
            }
            else
            {
                if (dgvListaServicios.RowCount > 0 && !FacturaGuardada)
                {
                    bool ReiniciarFactura = oper.CajaDeMensaje("La factura actual no ha sido guardada ¿Desea desecharla?", "Aviso");
                    if (ReiniciarFactura)
                    {

                    }
                    else { return; }
                }
            }

            //Abrir el formulario para elegir la factura que se va a modificar...
            Form f = new SeleccionarNumeroDeFactura();
            f.ShowDialog();
            if (ModificarFactura)
            {
                modificandofactura = true;
                FacturaModificadaGuardada = true;
                //MessageBox.Show("La Factura seleccionada para modificar fue, la factura Número: " + FacturaModificarNum.ToString());
                CargarFacturaSeleccionada();
            }

            EliminadosModificando = new string[100];
            PlusModificando = new string[100];
            CountPlus = 0;
            CountDown = 0;

        }

        public void CargarFacturaSeleccionada()
        {

            //Cargar la factura seleccionada

            //Cargar el detalle
            ds = oper.ConsultaConResultado("SELECT id_detalle, codigo, descripcion, precio, dias, cantidad, total FROM detalle_factura WHERE detalle_factura.id_factura = '" + FacturaModificarNum.ToString() + "' AND detalle_factura.estado = 'ACTIVO';");

            dgvListaServicios.Rows.Clear();

            SavedRowCount = ds.Tables[0].Rows.Count;
            for (int i = 0; i < SavedRowCount; i++)
            {
                dgvListaServicios.Rows.Add();
                for (int k = 0; k < 7; k++)
                {
                    dgvListaServicios.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                }
            }

            //Cargar la cabecera de Factura
            ds = oper.ConsultaConResultado("SELECT * FROM cabecera_factura WHERE cabecera_factura.id_factura = '" + FacturaModificarNum.ToString() + "';");
            lbnumfactura.Text = "No. Factura: " + ds.Tables[0].Rows[0][0].ToString();
            if (ds.Tables[0].Rows[0][1].ToString() == "2") //Crédito o contado
            {
                rdCredito.PerformClick();
                SavedTipoFacturaCrédito = true;
            }
            else
            {
                rdContado.PerformClick();
                SavedTipoFacturaCrédito = false;
            }

            SavedIdCliente = ds.Tables[0].Rows[0][2].ToString();
            IdCliente = SavedIdCliente;
            tbidcliente.Text = SavedIdCliente;

            //Buscar el nombre
            ds = oper.ConsultaConResultado("SELECT nombre_cliente, apellido_cliente FROM cliente WHERE cliente.numero_cliente = '" + SavedIdCliente + "';");
            try
            {
                SavedNombreCliente = ds.Tables[0].Rows[0][0].ToString() + " " + ds.Tables[0].Rows[0][1].ToString();
                tbcliente.Text = SavedNombreCliente;
            }
            catch
            {
                MessageBox.Show("El cliente al que pertenecía esta factura fue eliminado", "Aviso", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
            }

            NumeroDeFactura = FacturaModificarNum.ToString();
            Actualizar();
        }

        private void dgvListaServicios_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void Facturación_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modificandofactura)
            {
                if (!FacturaModificadaGuardada)
                {
                    if (dgvListaServicios.RowCount != SavedRowCount || tbidcliente.Text != SavedIdCliente || SavedTipoFacturaCrédito != rdCredito.Checked)
                    {
                        bool ReiniciarFactura = oper.CajaDeMensaje("La factura actual no ha sido guardada ¿Desea desecharla?", "Aviso");
                        if (ReiniciarFactura)
                        {

                        }
                        else { e.Cancel = true; }
                    }
                }
                else
                {
                    //No ha sido guardada pero tampoco modificada...
                }
            }
            else
            {
                if (dgvListaServicios.RowCount > 0 && !FacturaGuardada)
                {
                    bool ReiniciarFactura = oper.CajaDeMensaje("La factura actual no ha sido guardada ¿Desea desecharla?", "Aviso");
                    if (ReiniciarFactura)
                    {

                    }
                    else { e.Cancel = true; }
                }
            }
        }

        private void dgvListaServicios_UserDeletedRow_1(object sender, DataGridViewRowEventArgs e)
        {
            Actualizar();
        }
    }

}
