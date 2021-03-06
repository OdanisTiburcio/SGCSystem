﻿using System;
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

            DialogResult Result = MessageBox.Show(cuerpo, titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
            int año = Convert.ToInt32(fecha.Substring(0, 4));
            int mes = Convert.ToInt32(fecha.Substring(5, 2));
            int dia = Convert.ToInt32(fecha.Substring(8, 2));

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


        public string RestarALaFecha(string fecha, int diasarestar)
        {
            string fecharestada = fecha;
            //Método para quitarle las Sumarle dias a una fecha (0, 10 = ejemplo: "2017-12-07")
            int año = Convert.ToInt32(fecha.Substring(0, 4));
            int mes = Convert.ToInt32(fecha.Substring(5, 2));
            int dia = Convert.ToInt32(fecha.Substring(8, 2));

            for (int i = 0; i < diasarestar; i++)
            {
                if (mes == 3)
                {
                    if ((año % 4) == 0)//Año bisiesto de 29 días
                    {
                        if (dia == 1)
                        {
                            mes--;//reduce un mes
                            dia = 29;

                        }
                        else
                        {
                            dia--;//Solo deruce un día
                        }
                    }
                    else //año normal de 28 días
                    {
                        if (dia == 1)
                        {
                            mes--;//reduce un mes
                            dia = 28;
                        }
                        else
                        {
                            dia++;//Solo reduce un día
                        }
                    }
                }
                else
                {
                    if (mes == 1 || mes == 2 || mes == 4 || mes == 6 || mes == 8 || mes == 9 || mes == 11) //Meses anteriores a los de 31 días
                    {
                        if (dia == 1)
                        {
                            if (mes == 1)
                            {
                                año--;//reduce un año
                                mes = 12;
                                dia = 31;
                            }
                            else
                            {
                                mes--;//reduce un mes
                                dia = 31;
                            }
                        }
                        else
                        {
                            dia--;//Solo reduce un día
                        }
                    }
                    else
                    {
                        //Meses Anteriores de 30 días
                        if (dia == 1)
                        {
                            mes--;//Reduce un mes
                            dia = 30;
                        }
                        else
                        {
                            dia--;//Solo reduce un día
                        }
                    }
                }
            }

            //Formatear fecha a tipo DATE
            string Mmes;
            string Ddia;

            if (mes < 10) { Mmes = "0" + mes.ToString(); } else { Mmes = mes.ToString(); }
            if (dia < 10) { Ddia = "0" + dia.ToString(); } else { Ddia = dia.ToString(); }
            fecharestada = año.ToString() + "-" + Mmes + "-" + Ddia;

            return fecharestada;
        }

        public bool ValidarNumero(string cantidad)
        {
            try //Validar que sea un numero
            {
                long number = Int64.Parse(cantidad);

                if (number > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public string ConvertirAMoneda(int entero)
        {
            try
            {
                //Contar dgitos.
                int digitos = Convert.ToInt32((entero.ToString().Length));
                string reflejo = entero.ToString();
                int cantidaddecomas = 0;

                if (entero > 999)//Si el entero es mayor que 999 Contar las comas a poner...
                {
                    
                    while (reflejo.Length > 3) //Siempre que el numero tenga mas de tres digitos...
                    {
                        reflejo = reflejo.Remove(0, 3);
                        cantidaddecomas++;
                    }

                }

                string comatizado = entero.ToString();
                int sumante = 3;
                int IndexPosicion = 0;

                for (int i = 0; i < cantidaddecomas; i++)
                {
                    sumante = (3+(4*i));
                    IndexPosicion = (comatizado.Length - (sumante));

                    comatizado = comatizado.Insert(IndexPosicion,",");
                }

                string formateado = "RD$ " + comatizado + ".00";

                return formateado;
            }
            catch
            {
                return "RD$ 0.00";
            }

        }

        public string ObtenerHoraActual(string hora, string minutos)
        {
            //Formatear la Hora
            string hour;
            if (DateTime.Now.Hour > 12)
            {
                hour = (DateTime.Now.Hour - 12).ToString();
            }
            else { hour = DateTime.Now.Hour.ToString(); }

            //Formatear los minutos
            string minutes;
            if (DateTime.Now.Minute > 9)
            {
                minutes = DateTime.Now.Minute.ToString();
            }
            else { minutes = "0" + DateTime.Now.Minute.ToString(); }

            return (" " + hour + ":" + minutes);
        }

    }
}