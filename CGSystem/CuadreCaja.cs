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
    public partial class CuadreCaja : Form
    {
        //Clases y Variables Reutilizables
        operacion oper = new operacion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public CuadreCaja()
        {
            InitializeComponent();
        }

        private void CuadreCaja_Load(object sender, EventArgs e)
        {
            MostrarHoy();
        }

        public void MostrarHoy()
        {
            DateTime fechaDT = DateTime.Now;
            string fechaHoy = oper.FormatearFecha(fechaDT);

            dtvcuadrecaja.Rows.Clear();
            //Cargar la Tabla de todos los clientes activos
            ds = oper.ConsultaConResultado("SELECT id_factura, id_tipo_factura, total FROM cabecera_factura WHERE fecha between '" + fechaHoy + "' AND '" + fechaHoy + "';");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                dtvcuadrecaja.Rows.Add();
                for (int k = 0; k < 3; k++)
                {
                    dtvcuadrecaja.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                }

            }

        }
    }
}
