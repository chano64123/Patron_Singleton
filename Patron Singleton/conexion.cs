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
        private int numero1;
        private static conexion conn;

        public int getNumero1()
        {
            return numero1;
        }

        public void setNumero1(int _numero1)
        {
            numero1 = _numero1;
        }

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