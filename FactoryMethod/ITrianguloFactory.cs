using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    interface ITrianguloFactory
    {
        Triangulo createTriangulo(int ladoA, int ladoB, int ladoC);            
    }
}
