using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class TrianguloFactory:ITrianguloFactory
    {
        public Triangulo createTriangulo(int ladoA, int ladoB, int ladoC)
        {
            if ((ladoA == ladoB) && (ladoA == ladoC))
            {
                return new Equilatero(ladoA, ladoB, ladoC);
            }
            else if ((ladoA == ladoB) || (ladoA == ladoC))
            {
                return new Isosceles(ladoA, ladoB, ladoC);
            }
            else
            {
                return new Escaleno(ladoA, ladoB, ladoC);
            }
        }
    }
}
