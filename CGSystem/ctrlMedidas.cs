﻿using System;
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
    public partial class CtrlMedidas : Form
    {
        public CtrlMedidas()
        {
            InitializeComponent();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            SeleccionarCliente frm = new SeleccionarCliente();
            frm.ShowDialog();
            btnguardar.Enabled = true;
        }
    }
}
