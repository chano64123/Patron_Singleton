using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Patron_Singleton.datos
{
    class conexion
    {
        private static conexion conn;

        private conexion()
        {
        }

        public static conexion getInstancia()
        {
            if (conn == null)
            {
                conn = new conexion();
            }
            return conn;
        }

        public void conectar()
        {
            MessageBox.Show("Conexion a la Base de Datos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void desconectar()
        {
            MessageBox.Show("Desconexion de la Base de Datos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}