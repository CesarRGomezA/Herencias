using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    class Pez : Animal
    {
         override public string desplazar()
        {
            return Nombre + " Esta nadando";
        }
    }
}
