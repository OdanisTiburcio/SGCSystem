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
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\SGCSystem\\SGCSystemBD.db;Version=3;");
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

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\SGCSystem\\SGCSystemBD.db;Version=3;");
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

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\SGCSystem\\SGCSystemBD.db;Version=3;");
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

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\SGCSystem\\SGCSystemBD.db;Version=3;");
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

    }
}