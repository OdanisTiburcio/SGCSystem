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
    public partial class Visor_de_Datos_Sqlite : Form
    {
        operacion oper = new operacion();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Visor_de_Datos_Sqlite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dt = oper.ConsultaDataTable("SELECT * FROM "+ tbnombretabla.Text +";");
                dgvDatos.DataSource = dt;
                dgvDatos.Refresh();
            }
            catch
            {             
            }
        }

        private void Visor_de_Datos_Sqlite_Load(object sender, EventArgs e)
        {

        }
    }
}
