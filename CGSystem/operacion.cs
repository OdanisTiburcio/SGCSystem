using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CGSystem
{
    public class operacion
    {

        public string Conectar()
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
            try
            {
                cnx.Open();

                return "Conexión exitosa!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }
        }

        public string ConsultaSinResultado(string sql)
        {

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }

        }

        public DataSet ConsultaConResultado(string sql)
        {

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
            try
            {
                cnx.Open();
                DataSet ds = new DataSet();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, cnx);
                adapter.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                cnx.Close();
            }

        }

        public DataTable ConsultaDataTable(string sql)
        {

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\CGSystem\\SGCSystemBD.db;Version=3;");
            try
            {
                cnx.Open();
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, cnx);
                adapter.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                cnx.Close();
            }

        }

        public string FormatearFecha(DateTime fechaDT)
        {
            string fechaform;
            int mes = fechaDT.Month;
            int dia = fechaDT.Day;
            string Ddia = "";
            string Mmes = "";
            string Aaño = fechaDT.Year.ToString();

            //Comprobar que el més o el día sea mayor que 10 para si no agregarle el cero delante
            if (mes < 10) { Mmes = "0" + mes.ToString(); } else { Mmes = mes.ToString(); }
            if (dia < 10) { Ddia = "0" + dia.ToString(); } else { Ddia = dia.ToString(); }
            fechaform = Aaño + "-" + Mmes + "-" + Ddia;

            return fechaform; //Retornar al la llamada del método; la fecha formateada
        }

        public bool CajaDeMensaje(string cuerpo, string titulo)
        {
            bool aceptar = false;

            DialogResult Result = MessageBox.Show(cuerpo, titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                aceptar = true;
            }

            return aceptar;
        }

        public string SumarAlaFecha(string fecha, int diassumar)
        {
            string fechasumada = fecha;
            //Método para quitarle las Sumarle dias a una fecha (0, 10 = ejemplo: "2017-12-07")
            int año = Convert.ToInt32(fecha.Substring(6, 4));
            int mes = Convert.ToInt32(fecha.Substring(3, 2));
            int dia = Convert.ToInt32(fecha.Substring(0, 2));

            for (int i = 0; i < diassumar; i++)
            {
                if (mes == 2)
                {
                    if ((año % 4) == 0)//Año bisiesto de 29 días
                    {
                        if (dia == 29)
                        {
                            if (mes == 12)
                            {
                                año++;//aumenta un año
                                mes = 1;
                                dia = 1;
                            }
                            else
                            {
                                mes++;//aumenta un mes
                                dia = 1;
                            }
                        }
                        else
                        {
                            dia++;//Solo aumenta un día
                        }
                    }
                    else //año normal de 28 días
                    {
                        if (dia == 28)
                        {
                            if (mes == 12)
                            {
                                año++;//aumenta un año
                                mes = 1;
                                dia = 1;
                            }
                            else
                            {
                                mes++;//aumenta un mes
                                dia = 1;
                            }
                        }
                        else
                        {
                            dia++;//Solo aumenta un día
                        }
                    }
                }
                else
                {
                    if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) //Meses de 31 días
                    {
                        if (dia == 31)
                        {
                            if (mes == 12)
                            {
                                año++;//aumenta un año
                                mes = 1;
                                dia = 1;
                            }
                            else
                            {
                                mes++;//aumenta un mes
                                dia = 1;
                            }
                        }
                        else
                        {
                            dia++;//Solo aumenta un día
                        }
                    }
                    else
                    {
                        //Meses restantes de 30 días
                        if (dia == 30)
                        {
                            if (mes == 12)
                            {
                                año++;//aumenta un año
                                mes = 1;
                                dia = 1;
                            }
                            else
                            {
                                mes++;//aumenta un mes
                                dia = 1;
                            }
                        }
                        else
                        {
                            dia++;//Solo aumenta un día
                        }
                    }
                }
            }

            //Formatear fecha a tipo DATE
            string Mmes;
            string Ddia;

            if (mes < 10) { Mmes = "0" + mes.ToString(); } else { Mmes = mes.ToString(); }
            if (dia < 10) { Ddia = "0" + dia.ToString(); } else { Ddia = dia.ToString(); }
            fechasumada = año.ToString() + "-" + Mmes + "-" + Ddia;

            return fechasumada;
        }

    }
}