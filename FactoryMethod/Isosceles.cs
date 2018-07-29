using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Isosceles:Triangulo
    {
        public Isosceles(int ladoA, int ladoB, int ladoC): base(ladoA,ladoB,ladoC)
        { }

        override public string getDescripcion()
        {
            return "SOY ISOSCELES";
        }
    }
}
