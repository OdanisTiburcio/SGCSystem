﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class Visor_de_Datos_Sqlite : Form
    {
        //operacion oper = new operacion();
        //DataTable dt = new DataTable();
        //DataSet ds = new DataSet();

        public Visor_de_Datos_Sqlite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //operacion oper = new operacion();
            //DataSet ds = new DataSet();
            ////try
            ////{
            //    ds = oper.ConsultaConResultado("SELECT * FROM '" + tbnombretabla.Text + "'");
            //    dgvDatos.DataSource = dt;
            //    dgvDatos.Refresh();
            //}
            //catch
            //{
            //}
            operacion oper = new operacion();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
            cnx.Open();
            string consulta = "SELECT * FROM '" + tbnombretabla.Text + "'";
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, cnx);
            DataSet ds = new DataSet();
            ds.Reset();
            DataTable dt = new DataTable();
            db.Fill(ds);
            dt = ds.Tables[0];
            dgvDatos.DataSource = dt;
            cnx.Close();
        }

        private void Visor_de_Datos_Sqlite_Load(object sender, EventArgs e)
        {

        }
    }
}
