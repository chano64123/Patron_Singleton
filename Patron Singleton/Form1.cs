using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patron_Singleton.datos;

namespace Patron_Singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal SqlConnection _conexion;
        internal variable _variable { get; set; }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            _conexion = conexion.getConnection();
            _conexion.Open();
            if (_conexion.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexion a la Base de Datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo conctar a la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            _conexion = conexion.getConnection();
            _conexion.Close();
            if (_conexion.State == ConnectionState.Closed)
            {
                MessageBox.Show("Desconexion de la Base de Datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo desconectar de la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frm02 _frm02 { get; set; }
        private void btnAbrirFrom02_Click(object sender, EventArgs e)
        {
            _frm02 = frm02.openForm();
            _frm02.Show(); 
        }
    

        public frm03 _frm03 { get; set; }
        private void btnAbrirFrom03_Click(object sender, EventArgs e)
        {
            _frm03 = new frm03();
            _frm03.Show();
        }

        private void btnConSingleton_Click(object sender, EventArgs e)
        {
            _variable = variable.getInstancia();
            variable v2 = variable.getInstancia();
            _variable.setNumero1(15);
            MessageBox.Show("Valor de la variable en el objeto 1: " + _variable.getNumero1() + "\nValor de la variable en el objeto 2: " + v2.getNumero1(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSinSingleton_Click(object sender, EventArgs e)
        {
            variable v1 = new variable();
            variable v2 = new variable();
            v1.setNumero1(15);
            MessageBox.Show("Valor de la variable en el objeto 1: " + v1.getNumero1() + "\nValor de la variable en el objeto 2: " + v2.getNumero1(),"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
