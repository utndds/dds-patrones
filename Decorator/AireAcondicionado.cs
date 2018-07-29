using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AireAcondicionado : AutoDecorador
    {
        private string _descripcion;
        private double _precio;
        private Auto _auto;

        public AireAcondicionado(Auto auto)
        {
            this._auto = auto;
        }   
         
        public void dibujar()
        {
            Console.WriteLine("Estoy dibujando el aire acondicionado");
        }

        public string getDescripcion()
        {
            return getComponente().getDescripcion() + " - Aire Acondicionado: " +  this._descripcion;
        }

        public double getPrecio()
        {
            return getComponente().getPrecio() + this._precio;
        }

        public void setDescripcion(string _descripcion)
        {
            this._descripcion = _descripcion;
        }

        public void setPrecio(double _precio)
        {
            this._precio = _precio;
        }
    }
}
