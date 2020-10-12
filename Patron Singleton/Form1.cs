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

        internal conexion _conexion { get; set; }
        internal variable _variable { get; set; }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            _conexion = conexion.getInstancia();
            _conexion.conectar();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            _conexion = conexion.getInstancia();
            _conexion.desconectar();
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
