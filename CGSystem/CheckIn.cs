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
    public partial class CheckIn : Form
    {
        //Variables necesarias
        public static string IdEmpleado = "0";

        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {
            //Buscar un empleado mostrando el formulario de selección
            ListaDeClientes.Seleccionando = true;
            Form f = new ListaDeClientes();
            f.ShowDialog();
            Actualizar();
        }

        public void Actualizar()
        {
            //Actualizar el formulario de CheckIn con el empleado seleccionado

        }
    }
}
