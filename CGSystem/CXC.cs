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
    public partial class CXC : Form
    {
        //Clases y Variables Reutilizables
        operacion oper = new operacion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public string[] CodigosFacturas = new string[1000000];
        public string[] FechasFacturas = new string[1000000];
        public bool Buscado = false;
        public long ValorAPagar = 0;
        public long ValorTotalAPagar = 0;
        public bool variasfacturas = false;

        public CXC()
        {
            InitializeComponent();
        }

        private void btbuscar1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {
            Form f = new SeleccionarCliente();
            if (!Buscado)
            {
                SeleccionarCliente.ClienteBuscado = tbnombre.Text;
            }
            f.ShowDialog();
            variasfacturas = false;
            Mostrar();
        }

        public void Mostrar()
        {
            try
            {
                if (variasfacturas) //si se pagó el total de facturas; limpiar el datagrid...
                {
                    dgvCuentasPorCobrar.Rows.Clear();
                    dgvCuentasPorCobrar.Refresh();
                }
                else
                {
                    tbcodigo.Text = MenuPrincipal.SelecciónDeCliente;
                    ds = oper.ConsultaConResultado("SELECT nombre_cliente, apellido_cliente FROM cliente WHERE numero_cliente = '" + MenuPrincipal.SelecciónDeCliente + "';");
                    tbnombre.Text = ds.Tables[0].Rows[0][0].ToString() + " " + ds.Tables[0].Rows[0][1].ToString();

                    ds = oper.ConsultaConResultado("SELECT * FROM cabecera_factura WHERE id_cliente = '" + MenuPrincipal.SelecciónDeCliente + "' AND estado = 'ACTIVO';");
                    CodigosFacturas = new string[1000000];
                    FechasFacturas = new string[1000000];

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++) //Escribir las facturas factibles...
                    {
                        CodigosFacturas[i] = ds.Tables[0].Rows[i][0].ToString();
                        FechasFacturas[i] = ds.Tables[0].Rows[i][4].ToString();
                    }

                    ds = oper.ConsultaConResultado("SELECT * FROM cxc WHERE estado_cxc = 'ACTIVO';");//Escribir las que aplican
                    int ContadorDeFilas = 0;
                    dgvCuentasPorCobrar.Rows.Clear();
                    double ValorTotalContador = 0;

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        for (int k = 0; k < CodigosFacturas.Length; k++)
                        {
                            if (ds.Tables[0].Rows[i][1].ToString() == CodigosFacturas[k]) //Solo insertar las filas que aplican...
                            {
                                dgvCuentasPorCobrar.Rows.Add();
                                dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                                dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();
                                dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();
                                dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString();
                                dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[4].Value = tbnombre.Text;
                                FechasFacturas[k] = FechasFacturas[k].Remove(10, (FechasFacturas[k].Length - 10));
                                dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[5].Value = FechasFacturas[k].ToString();
                                ValorTotalContador += Convert.ToDouble(dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[3].Value); //Calcular el Total...
                                ContadorDeFilas++;
                                k = 1000001;
                            }
                            else
                            {
                                if (CodigosFacturas[k] == null)
                                {
                                    k = 1000001;
                                }
                                else
                                {
                                }
                            }
                        }
                    }

                    lbtotal.Text = oper.ConvertirAMoneda(unchecked((int)ValorTotalContador));
                    ValorTotalAPagar = unchecked((int)ValorTotalContador);

                    dgvCuentasPorCobrar.Refresh();
                    btnimpingreso.Enabled = false;

                    if (dgvCuentasPorCobrar.RowCount == 0)
                    {
                        MessageBox.Show("El cliente No.: " + MenuPrincipal.SelecciónDeCliente + " no tiene cuentas por cobrar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        btnpagarfactura.Enabled = true;
                        btnimpingreso.Enabled = true;
                        btnimprimirestado.Enabled = true;
                        btnpagartotal.Enabled = true;
                        tbvalorapagar.Enabled = true;
                    }

                    Buscado = true;
                }

            }
            catch
            {
                MessageBox.Show("El cliente No.: " + MenuPrincipal.SelecciónDeCliente + " no tiene cuentas por cobrar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public void MostrarTodo()
        {
            try
            {

                tbcodigo.Clear();

                ds = oper.ConsultaConResultado("SELECT * FROM cabecera_factura WHERE id_cliente = '" + MenuPrincipal.SelecciónDeCliente + "' AND estado = 'ACTIVO';");
                CodigosFacturas = new string[1000000];
                FechasFacturas = new string[1000000];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++) //Escribir las facturas factibles...
                {
                    CodigosFacturas[i] = ds.Tables[0].Rows[i][0].ToString();
                    FechasFacturas[i] = ds.Tables[0].Rows[i][4].ToString();
                }

                ds = oper.ConsultaConResultado("SELECT * FROM cxc WHERE estado_cxc = 'ACTIVO';");//Escribir las que aplican
                int ContadorDeFilas = 0;
                dgvCuentasPorCobrar.Rows.Clear();
                double ValorTotalContador = 0;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int k = 0; k < CodigosFacturas.Length; k++)
                    {
                        if (ds.Tables[0].Rows[i][1].ToString() == CodigosFacturas[k]) //Solo insertar las filas que aplican...
                        {
                            dgvCuentasPorCobrar.Rows.Add();
                            dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                            dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();
                            dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();
                            dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString();
                            dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[4].Value = tbnombre.Text;
                            FechasFacturas[k] = FechasFacturas[k].Remove(10, (FechasFacturas[k].Length - 10));
                            dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[5].Value = FechasFacturas[k].ToString();
                            ValorTotalContador += Convert.ToDouble(dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[3].Value); //Calcular el Total...
                            ContadorDeFilas++;
                            k = 1000001;
                        }
                        else
                        {
                            if (CodigosFacturas[k] == null)
                            {
                                k = 1000001;
                            }
                            else
                            {
                            }
                        }
                    }
                }

                lbtotal.Text = oper.ConvertirAMoneda(unchecked((int)ValorTotalContador));
                ValorTotalAPagar = unchecked((int)ValorTotalContador);

                dgvCuentasPorCobrar.Refresh();
                btnimpingreso.Enabled = false;

                if (dgvCuentasPorCobrar.RowCount == 0)
                {
                    MessageBox.Show("El cliente No.: " + MenuPrincipal.SelecciónDeCliente + " no tiene cuentas por cobrar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnpagarfactura.Enabled = true;
                    btnimpingreso.Enabled = true;
                    btnimprimirestado.Enabled = true;
                    btnpagartotal.Enabled = true;
                    tbvalorapagar.Enabled = true;
                }

                Buscado = true;
            }


            catch
            {
                MessageBox.Show("El cliente No.: " + MenuPrincipal.SelecciónDeCliente + " no tiene cuentas por cobrar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbnombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
            else
            {
                //Seguir escribiendo...
            }
        }

        private void CXC_Load(object sender, EventArgs e)
        {
            Buscado = false;
        }

        private void tbnombre_TextChanged(object sender, EventArgs e)
        {
            Buscado = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            PagarFactura();
        }

        public void PagarFactura()
        {
            try
            {
                //Verificar que halla una factura seleccionada...
                if (dgvCuentasPorCobrar.SelectedRows.Count == 1)
                {
                    //Verificar que halla digitado algun valor a pagar...
                    bool numerovalido = oper.ValidarNumero(ValorAPagar.ToString());
                    if (!numerovalido)
                    {
                        MessageBox.Show("Ingrese una cantidad válida...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbvalorapagar.Select();
                    }
                    else
                    {
                        //Validar que la cantidad a pagar no sea mayor a la cantidad en deuda
                        double ValorEnDeuda = Convert.ToDouble(dgvCuentasPorCobrar.CurrentRow.Cells[3].Value);

                        if (ValorAPagar > ValorEnDeuda)
                        {
                            MessageBox.Show("El valor a pagar es mayor que la cantidad en deuda, por favor ingrese una cantidad menor o igual...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbvalorapagar.Select();
                            return;
                        }
                        else
                        {
                            //continuar...
                        }

                        //continuar si es valido
                        string numerodefacturaapagar = dgvCuentasPorCobrar.CurrentRow.Cells[1].Value.ToString();
                        bool pagarfactura = oper.CajaDeMensaje("¿Va a pargar la cantidad de " + tbvalorapagar.Text + " a la factura No.: " + numerodefacturaapagar + " ?", "Pagar Factura");
                        if (pagarfactura)
                        {
                            //Relizar cambios en la CXC
                            string cxcmodificar = dgvCuentasPorCobrar.CurrentRow.Cells[0].Value.ToString();
                            double RestanteActual = Convert.ToDouble(dgvCuentasPorCobrar.CurrentRow.Cells[3].Value);
                            string nuevorestante = (RestanteActual - ValorAPagar).ToString();
                            bool cuentasaldada = false;

                            if (nuevorestante == "0" || nuevorestante == "0.0" || nuevorestante == "0.00") // Pasarla al estado de Saldadas...
                            {
                                oper.ConsultaSinResultado("UPDATE cxc SET restante = '" + nuevorestante + "', estado_cxc = 'SALDADA' WHERE id_cxc = '" + cxcmodificar + "';");
                                cuentasaldada = true;
                            }
                            else
                            {
                                oper.ConsultaSinResultado("UPDATE cxc SET restante = '" + nuevorestante + "' WHERE id_cxc = '" + cxcmodificar + "';");
                            }

                            //Generar ingreso
                            string TipoIngreso = (Convert.ToInt32(cbingreso.SelectedIndex + 1)).ToString();
                            string fechahoy = oper.FormatearFecha(DateTime.Now);
                            oper.ConsultaSinResultado("INSERT INTO ingreso (codigo_tipo_ingreso, numero_factura, monto_ingreso, fecha, estado) VALUES ('" + TipoIngreso + "','" + numerodefacturaapagar + "','" + ValorAPagar.ToString() + "','" + fechahoy + "', 'ACTIVO');");


                            bool imprimiringreso = oper.CajaDeMensaje("Pago realizado exitosamente ¿Desea imprimir el recibo de ingreso?", "Pago Exitoso");
                            if (imprimiringreso)
                            {
                                //Imprimir recibo de ingreso...
                            }
                            else
                            {
                                //No imprimir recibo de ingreso
                            }

                            if (cuentasaldada)
                            {
                                MessageBox.Show("La factura ha sido pagada en su totalidad, ahora ha pasado a \"Cuentas Saldadas\"...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                //continuar...
                            }

                            btnimpingreso.Enabled = true;
                            Mostrar();

                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione la factura que desea pagar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
        }

        public void PagarTodasLasFacturaDelClienteActual()
        {
            try
            {
                //Verificar que el cliente tenga cuentas por cobrar...
                if (dgvCuentasPorCobrar.RowCount > 0)
                {
                    //Validar la cantidad a pagar...
                    bool numerovalido = oper.ValidarNumero(ValorTotalAPagar.ToString());
                    if (!numerovalido)
                    {
                        MessageBox.Show("La Cantidad Total no es válida, contacte a mantenimiento...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Validar que la cantidad a pagar no sea mayor a la cantidad en deuda
                        double ValorEnDeuda = 0;

                        for (int i = 0; i < dgvCuentasPorCobrar.RowCount; i++)
                        {
                            ValorEnDeuda += Convert.ToDouble(dgvCuentasPorCobrar.Rows[i].Cells[3].Value);
                        }


                        if (ValorTotalAPagar > ValorEnDeuda)
                        {
                            MessageBox.Show("El valor a pagar es mayor que la cantidad en deuda, por favor ingrese una cantidad menor o igual...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbvalorapagar.Select();
                            return;
                        }
                        else
                        {
                            //continuar...
                        }

                        bool pagarfactura = oper.CajaDeMensaje("¿Va a pargar la cantidad de " + lbtotal.Text + " al total de las cuentas por cobrar del cliente No.: " + MenuPrincipal.SelecciónDeCliente + " ?", "Pagar Factura");
                        if (pagarfactura)
                        {

                            //Guardar todos los recibos de ingreso y modificar todas las cxc presentes...
                            string[] numerodefacturasapagar = new string[100000];
                            string cxcmodificar = "0";
                            double RestanteActual = 0;
                            string nuevorestante = "0";
                            string TipoIngreso = (Convert.ToInt32(cbingreso.SelectedIndex + 1)).ToString();
                            string fechahoy = fechahoy = oper.FormatearFecha(DateTime.Now);

                            for (int i = 0; i < dgvCuentasPorCobrar.RowCount; i++)
                            {
                                numerodefacturasapagar[i] = dgvCuentasPorCobrar.Rows[i].Cells[1].Value.ToString(); //Obtener número de factura
                                RestanteActual = Convert.ToDouble(dgvCuentasPorCobrar.Rows[i].Cells[3].Value); //Obtener Restante actual
                                cxcmodificar = dgvCuentasPorCobrar.Rows[i].Cells[0].Value.ToString(); //Obtener Primary Key de la CXC

                                //Relizar cambios en la CXC
                                oper.ConsultaSinResultado("UPDATE cxc SET restante = '" + nuevorestante + "', estado_cxc = 'SALDADA' WHERE id_cxc = '" + cxcmodificar + "';");

                                //Generar ingreso                             
                                oper.ConsultaSinResultado("INSERT INTO ingreso (codigo_tipo_ingreso, numero_factura, monto_ingreso, fecha, estado) VALUES ('" + TipoIngreso + "','" + numerodefacturasapagar[i] + "','" + RestanteActual.ToString() + "','" + fechahoy + "', 'ACTIVO');");
                            }

                            bool imprimiringreso = oper.CajaDeMensaje("Pago total realizado exitosamente ¿Desea imprimir el recibo de ingreso?", "Pago Exitoso");
                            if (imprimiringreso)
                            {
                                //Imprimir recibo de ingreso total...
                            }
                            else
                            {
                                //No imprimir recibo de ingreso total
                            }

                            btnimpingreso.Enabled = true;
                            variasfacturas = true;
                            btnpagartotal.Enabled = false;
                            lbtotal.Text = "RD$ 0.00";
                            Mostrar();
                        }
                        else
                        {

                        }


                    }
                }
                else
                {
                    MessageBox.Show("El cliente actual no tiene cuentas por cobrar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
        }

        private void tbvalorapagar_Enter(object sender, EventArgs e)
        {
            if (ValorAPagar == 0)
            {
                tbvalorapagar.Text = "";
            }
            else
            {
                tbvalorapagar.Text = ValorAPagar.ToString();
            }
        }

        private void tbvalorapagar_Leave(object sender, EventArgs e)
        {
            bool numerovalido = oper.ValidarNumero(tbvalorapagar.Text);
            if (numerovalido)
            {
                ValorAPagar = Int64.Parse(tbvalorapagar.Text);
            }
            else
            {
                ValorAPagar = 0;
            }

            if (ValorAPagar == 0)
            {
                tbvalorapagar.Text = "RD$ 0.00";
            }
            else
            {
                tbvalorapagar.Text = oper.ConvertirAMoneda(unchecked((int)ValorAPagar));
            }
        }

        private void tbvalorapagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnpagarfactura.Select();
                e.Handled = true;
            }
            else { }
        }

        private void tbvalorapagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
            else { }
        }

        private void dgvCuentasPorCobrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbvalorapagar.Select();
        }

        private void tbnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
            else { }
        }

        private void tbtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
            else { }
        }

        private void btcsave_Click(object sender, EventArgs e)
        {
            PagarTodasLasFacturaDelClienteActual();
        }

        private void tbpagartotal_Enter(object sender, EventArgs e)
        {
            if (ValorTotalAPagar == 0)
            {
                tbpagartotal.Text = "";
            }
            else
            {
                tbpagartotal.Text = ValorTotalAPagar.ToString();
            }
        }

        private void tbpagartotal_Leave(object sender, EventArgs e)
        {
            bool numerovalido = oper.ValidarNumero(tbpagartotal.Text);
            if (numerovalido)
            {
                ValorTotalAPagar = Int64.Parse(tbpagartotal.Text);
            }
            else
            {
                ValorTotalAPagar = 0;
            }

            if (ValorTotalAPagar == 0)
            {
                tbpagartotal.Text = "RD$ 0.00";
            }
            else
            {
                tbpagartotal.Text = oper.ConvertirAMoneda(unchecked((int)ValorTotalAPagar));
            }
        }

        private void tbpagartotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnpagarfactura.Select();
                e.Handled = true;
            }
            else { }
        }

        private void btnimpingreso_Click(object sender, EventArgs e)
        {
            ImprimirUltmoIngreso();
        }

        public void ImprimirUltmoIngreso()
        {
            try
            {
                if (variasfacturas)
                {
                    //Imprimir Ingreso Total...
                }
                else
                {
                    //Imprimir último ingreso particular de la última factura pagada...
                }
            }
            catch
            {
            }
        }
    }
}