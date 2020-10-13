using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.CSharp.RuntimeBinder;

namespace Patron_Singleton.datos
{
    class conexion
    {
        private static SqlConnection conn;
        private static String user = "";
        private static String password = "";
        private static String servidor = @"localhost"; //(localhost) (host) .;
        private static String basedatos = "bdJeaNet";

        private conexion()
        {
        }

        public static SqlConnection getConnection()
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = "server=" + servidor + ";" + "database=" + basedatos + ";uid=" + user + ";" + "pwd=" + password + ";integrated security = true";
                }
                return conn;
            }
            catch (SqlException e)
            {
                throw new RuntimeBinderException("Conexion fallida", e);
            }
        }

        public void conectar()
        {
            try
            {
                conn.Open();
                MessageBox.Show("Conexion a la Base de Datos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void desconectar()
        {
            try
            {
                conn.Close();
                MessageBox.Show("Desconexion de la Base de Datos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

        }
    }
}