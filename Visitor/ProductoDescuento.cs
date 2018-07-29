using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ProductoDescuento: Visitable
    {
        private double _precio;

        public double accept(Visitor _visitor)
        { 
            return _visitor.visit(this);
        }

        public void setPrecio(double precio)
        { this._precio = precio; }

        public double getPrecio()
        { return this._precio; }


    }
}
