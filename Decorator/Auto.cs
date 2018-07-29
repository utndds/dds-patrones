using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Auto : Vendible 
    {
        private string _descripcion;
        private double _precio;

        public Auto(string descripcion, double precio)
        {
            this._descripcion = descripcion;
            this._precio = precio;
        }

        public void dibujar()
        {
            Console.WriteLine("Estoy dibujando un auto");
        }

        public string getDescripcion()
        {
            return this._descripcion;
        }

        public double getPrecio()
        {
            return this._precio;
        }

        public void setDescripcion(string _descripcion)
        {
            this._descripcion = _descripcion;
        }

        public void setPrecio (double _precio)
        {
            this._precio = _precio;
        }
    }
}
