using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    class Ave : Animal
    {
        public string ponerHuevo()
        {
            return Nombre + " Puso un huevo";
        }

        override public string desplazar()
        {
            return Nombre + " Esta volando";
        }
    }
}
