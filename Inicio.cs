using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApaganeiForm
{
    class Inicio: System.Windows.Forms.ApplicationContext
    {
        /*Clase inicio para iniciar la aplicación y poder cerrar formularios independientemente*/
        public Inicio() 
        {
            FrmPrincipal miform = new FrmPrincipal();
            miform.Show();
        }
    }
}
