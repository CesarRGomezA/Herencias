using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    class Reptil : Animal
    {
        public string cambiarPiel()
        {
            return Nombre + " Cambia de piel";
        }

        override public string desplazar()
        {
            return Nombre + " Esta arastrando";
        }

    }
}
