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
        public bool Buscado = false;

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
            Mostrar();
        }

        public void Mostrar()
        {
            try
            {
                tbcodigo.Text = MenuPrincipal.SelecciónDeCliente;
                ds = oper.ConsultaConResultado("SELECT nombre_cliente, apellido_cliente FROM cliente WHERE numero_cliente = '" + MenuPrincipal.SelecciónDeCliente + "';");
                tbnombre.Text = ds.Tables[0].Rows[0][0].ToString() + " " + ds.Tables[0].Rows[0][1].ToString();

                ds = oper.ConsultaConResultado("SELECT * FROM cabecera_factura WHERE id_cliente = '" + MenuPrincipal.SelecciónDeCliente + "' AND estado = 'ACTIVO';");
                CodigosFacturas = new string[1000000];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++) //Escribir las facturas factibles...
                {
                    CodigosFacturas[i] = ds.Tables[0].Rows[i][0].ToString();
                }

                ds = oper.ConsultaConResultado("SELECT * FROM cxc WHERE estado_cxc = 'ACTIVO';");//Escribir las que aplican
                int ContadorDeFilas = 0;
                dgvCuentasPorCobrar.Rows.Clear();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int k = 0; k < CodigosFacturas.Length; k++)
                    {
                        if(ds.Tables[0].Rows[i][1].ToString() == CodigosFacturas[k]) //Solo insertar las filas que aplican...
                        {
                            dgvCuentasPorCobrar.Rows.Add();
                            dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                            dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();
                            dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();
                            dgvCuentasPorCobrar.Rows[ContadorDeFilas].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString();
                            ContadorDeFilas++;
                            k = 1000001;
                        }
                        else {
                            if (CodigosFacturas[k] == null)
                            {
                                k = 1000001;
                            }
                            else {
                            }
                        }
                    }
                }

                dgvCuentasPorCobrar.Refresh();
                if(dgvCuentasPorCobrar.RowCount == 0)
                {
                    MessageBox.Show("El cliente No.: " + MenuPrincipal.SelecciónDeCliente + " no tiene cuentas por cobrar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { }

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
    }
}
