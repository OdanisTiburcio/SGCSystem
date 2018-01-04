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
    public partial class SeleccionarNumeroDeFactura : Form
    {
        public int FacturaModificar = 0;
        public bool TeclaEnter = false;
        DataSet ds = new DataSet();
        operacion oper = new operacion();

        public SeleccionarNumeroDeFactura()
        {
            InitializeComponent();
            Facturación.ModificarFactura = false;
        }

        private void SeleccionarNumeroDeFactura_Load(object sender, EventArgs e)
        {
            tbnumfactura.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturación.ModificarFactura = false;
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        public void Aceptar()
        {
            //Validar que el número de factura sea un número bien escrito...
            if (tbnumfactura.Text != "" && tbnumfactura.Text != "0")
            {
                try
                {
                    FacturaModificar = Convert.ToInt32(tbnumfactura.Text);
                    if (FacturaModificar <= 0)
                    {
                        MessageBox.Show("Escriba un número de factura válido");
                        tbnumfactura.Select();
                        return;
                    }
                    else {
                        //Si el código corrió hasta aquí significa que el número de factura es válido...
                        //Ahora validamos que la factura escrita exista
                        ds = oper.ConsultaConResultado("SELECT * FROM cabecera_factura WHERE cabecera_factura.id_factura = '"+ tbnumfactura.Text.ToString() + "' AND cabecera_factura.estado = 'ACTIVO';");
                        try
                        {
                            string SELECT = ds.Tables[0].Rows[0][0].ToString();
                            MessageBox.Show("Factura encontrada exitosamente");
                            tbnumfactura.Select();
                        }
                        catch
                        {
                            MessageBox.Show("Esta factura no existe o fue eliminada");
                            tbnumfactura.Select();
                            return;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Escriba un número de factura válido");
                    tbnumfactura.Select();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Escriba un número de factura válido");
                tbnumfactura.Select();
                return;
            }

            Facturación.ModificarFactura = true;
            Facturación.FacturaModificarNum = FacturaModificar;
            this.Close();
        }

        private void tbnumfactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (!TeclaEnter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TeclaEnter = true;
                    e.Handled = true;
                    Aceptar();
                    TeclaEnter = false;
                }
            }else
            {

            }
        }
    }
}
