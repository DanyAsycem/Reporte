using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteH.methods
{
    class usoVariables
    {
        public int abrirForm(int dato, int retorno)
        {
            if(dato == 1)
            {
                System.Windows.Forms.Form a = new System.Windows.Forms.Form();
                a.Show();
            }
            return retorno;
        }
    }
}
