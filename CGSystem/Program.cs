using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static bool licenciavencida = false;
        public static operacion oper = new operacion();
        public static bool IniciarSistema = false;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Confirmar Licencia de 30 días
            DataSet ds = oper.ConsultaConResultado("SELECT * FROM licencia;");
            bool licenciainiciada = false;
            if (ds.Tables[0].Rows[0][0].ToString() != "PREPARADO")
            {
                licenciainiciada = true;
            }else
            {
                licenciainiciada = false;
            }

            if (licenciainiciada)
            {
                DateTime hoy = DateTime.Now;
                string fechavenci = ds.Tables[0].Rows[0][1].ToString();
                string TreintaMasFechaInstalacion = oper.SumarAlaFecha(fechavenci, 30);
                DateTime fechavencimiento = Convert.ToDateTime(TreintaMasFechaInstalacion);
                if (fechavencimiento > hoy)
                {
                    IniciarSistema = false;
                }
                else
                {
                    IniciarSistema = true;
                }
            }
            else
            {

            }

            if (IniciarSistema)
            {
                Application.Run(new MenuPrincipal());
            }
            else
            {

            }

            
        }
    }
}
