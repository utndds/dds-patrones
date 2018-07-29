using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Triangulo
    {
        private int _ladoA;
        private int _ladoB;
        private int _ladoC;

        public Triangulo(int ladoA, int ladoB, int ladoC)
        {
            setLadoA(ladoA);
            setLadoB(ladoB);
            setLadoC(ladoC);
        }

        public abstract string getDescripcion();

        public int getLadoA()
        { return this._ladoA; }

        public int getLadoB()
        { return this._ladoB; }

        public int getLadoC()
        { return this._ladoC; }

        public void setLadoA(int lado)
        { this._ladoA = lado; }

        public void setLadoB(int lado)
        { this._ladoB = lado; }

        public void setLadoC(int lado)
        { this._ladoC = lado; }
    }
}
