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
    public partial class Posiciones : Form
    {
        public Posiciones()
        {
            InitializeComponent();
        }

        private void btnguardarposicion_Click(object sender, EventArgs e)
        {
            if (tbdescripposición.Text == "")
            {
                MessageBox.Show("Favor digitar un nombre de posición válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("INSERT INTO posicion (descripcion_posicion) VALUES ('" + tbdescripposición.Text.ToString().ToUpper() + "')");
                tbdescripposición.Clear();
                MessageBox.Show("Datos registrados satisfactoriamente!");
            }

        }

        private void btnactualizarposicion_Click(object sender, EventArgs e)
        {
            if (tbcodigoposicion.Text == "")
            {
                MessageBox.Show("Favor digitar un código de posición válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("UPDATE posicion SET descripcion_posicion ='" + tbdescripposición.Text.ToString().ToUpper() + "' WHERE codigo_posicion = '" + tbcodigoposicion.Text.ToString() + "'");
                tbcodigoposicion.Clear();
                tbdescripposición.Clear();
                MessageBox.Show("Datos actualizados correctamente!");
            }

        }

        private void btneliminarposicion_Click(object sender, EventArgs e)
        {
            if (tbcodigoposicion.Text == "")
            {
                MessageBox.Show("Favor digitar un código de posición válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("DELETE FROM posicion WHERE codigo_posicion ='" + tbcodigoposicion.Text.ToString() + "'");
                tbcodigoposicion.Clear();
                tbdescripposición.Clear();
                MessageBox.Show("Posición eliminada correctamente!");
            }

        }
    }
}
