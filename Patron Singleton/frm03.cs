using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patron_Singleton
{
    public partial class frm03 : Form
    {

        private static frm03 frm = null; 

        public frm03()
        {
            InitializeComponent();
        }

        private void frm03_Load(object sender, EventArgs e)
        {

        }
    }
}
