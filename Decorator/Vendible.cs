using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    interface Vendible
    {
        string getDescripcion();
        double getPrecio();
        void dibujar();
    }
}
