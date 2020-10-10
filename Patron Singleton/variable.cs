using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patron_Singleton
{
    class variable
    {
        private static variable _variable;
        private int numero1;

        public int getNumero1()
        {
            return numero1;
        }

        public void setNumero1(int _numero1)
        {
            numero1 = _numero1;
        }

        public variable()
        {
        }

        public static variable getInstancia()
        {
            if (_variable == null)
            {
                _variable = new variable();
            }
            return _variable;
        }
    }
}
