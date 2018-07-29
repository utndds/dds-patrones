using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AutoDecorador : Vendible
    {
        private string _descripcion;
        private double _precio;
        private Vendible _componente;

        public AutoDecorador(Auto auto)
        {
            setComponente(auto);
        }

        public AutoDecorador() // Se agrega para que no salte el error de que ningún argumento corresponde al parámetro formal
        // get-set Componente
        { }

        public Vendible getComponente()
        {
            return _componente;
        }

        public void setComponente(Vendible componente)
        {
            this._componente = componente;
        }

        // Métodos a implementar en subclases

        public string getDescripcion()
        {
            return this._descripcion;
        }

        public double getPrecio()
        {
            return this._precio;
        }

        public void dibujar()
        {
        }
    }
}
