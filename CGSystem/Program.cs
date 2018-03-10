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
                string fechavenc = ds.Tables[0].Rows[0][1].ToString();
                DateTime fechavenci = Convert.ToDateTime(fechavenc);
                string formatedfechavencida = oper.FormatearFecha(fechavenci);
                string TreintaMasFechaInstalacion = oper.SumarAlaFecha(formatedfechavencida, 30);
                DateTime fechavencimiento = Convert.ToDateTime(TreintaMasFechaInstalacion);
                if (fechavencimiento > hoy)
                {
                    IniciarSistema = true;
                }
                else
                {
                    IniciarSistema = false;
                }
            }
            else
            {
                DateTime hoy = DateTime.Now;
                string fechahoy = oper.FormatearFecha(hoy);
                oper.ConsultaSinResultado("UPDATE licencia SET estado = 'INICIADO', fechaini = '"+fechahoy+"';");
                IniciarSistema = true;
            }

            if (IniciarSistema)
            {
                Application.Run(new MenuPrincipal());
            }
            else
            {
                Form f = new insertarLicencia();
                f.ShowDialog();
                if (IniciarSistema)
                {
                    Application.Run(new MenuPrincipal());
                }
                else
                {
                    //Seguir sin abrir el programa
                }
            }

            
        }
    }
}
