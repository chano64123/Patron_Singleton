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

        private frm03()
        {
            InitializeComponent();
        }

        public static frm03 openForm() 
        {
            if (frm == null)
            {
                frm = new frm03();
            }
            return frm;
        }
    }
}
