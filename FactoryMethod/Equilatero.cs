using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Equilatero: Triangulo
    {
        public Equilatero(int ladoA, int ladoB, int ladoC): base(ladoA,ladoB,ladoC)
        {}

        override public string getDescripcion()
        {
            return "SOY EQUILATERO";
        }
    }
}
