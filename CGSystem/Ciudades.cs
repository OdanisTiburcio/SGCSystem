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
    public partial class Ciudades : Form
    {
        public Ciudades()
        {
            InitializeComponent();
        }

        private void btnguardarciudad_Click(object sender, EventArgs e)
        {
            if (tbdescripciudad.Text == "")
            {
                MessageBox.Show("Favor digitar un nombre de ciudad válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("INSERT INTO ciudad (descripcion_ciudad) VALUES ('" + tbdescripciudad.Text.ToString().ToUpper() + "')");
                tbdescripciudad.Clear();
                MessageBox.Show("Datos registrados satisfactoriamente!");
            }

        }

        private void btnactualizarciudad_Click(object sender, EventArgs e)
        {
            if (tbcodigociudad.Text == "")
            {
                MessageBox.Show("Favor digitar un código de ciudad válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("UPDATE ciudad SET descripcion_ciudad ='" + tbdescripciudad.Text.ToString().ToUpper() + "' WHERE codigo_ciudad = '" + tbcodigociudad.Text.ToString() + "'");
                tbcodigociudad.Clear();
                tbdescripciudad.Clear();
                MessageBox.Show("Datos actualizados correctamente!");
            }


        }

        private void btneliminarciudad_Click(object sender, EventArgs e)
        {
            if (tbcodigociudad.Text == "")
            {
                MessageBox.Show("Favor digitar un código de ciudad válido!");
            }
            else
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado("DELETE FROM ciudad WHERE codigo_ciudad ='" + tbcodigociudad.Text.ToString() + "'");
                tbcodigociudad.Clear();
                tbdescripciudad.Clear();
                MessageBox.Show("Ciudad eliminada correctamente!");
            }

        }

        private void Ciudades_Load(object sender, EventArgs e)
        {

        }
    }
}
