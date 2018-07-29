using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class IVA:Visitor
    {
        public double visit(ProductoNormal producto)
        {
            return producto.getPrecio() * 0.21;
        }

        public double visit(ProductoDescuento producto)
        {
            return producto.getPrecio() * 0.1;
        }
    }
}
