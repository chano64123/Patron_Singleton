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
    public partial class frm02 : Form
    {
        private static frm02 form = null;

        private frm02()
        {
            InitializeComponent();
        }

        public static frm02 openForm()
        {
            if(form == null)
            {
                form = new frm02();
            }
            return form;
        }

        private void frm02_FormClosing(object sender, FormClosingEventArgs e)
        {
            form = null;
        }
    }
}
