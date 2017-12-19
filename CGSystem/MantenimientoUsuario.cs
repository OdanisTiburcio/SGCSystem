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
    public partial class MantenimientoUsuario : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        operacion oper = new operacion();

        public MantenimientoUsuario()
        {
            InitializeComponent();
        }

        private void MantenimientoUsuario_Load(object sender, EventArgs e)
        {
            dt = oper.ConsultaDataTable("SELECT * FROM login;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
