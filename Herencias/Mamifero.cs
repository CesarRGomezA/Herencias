using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    class Mamifero : Animal
    {
        public string hivernando()
        {
            return Nombre + " Esta durmiendo";
        }

        override public string desplazar()
        {
            return Nombre + " Esta caminando";
        }
    }
}
