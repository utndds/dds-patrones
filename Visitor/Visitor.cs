using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface Visitor
    {
        double visit(ProductoNormal producto);
        double visit(ProductoDescuento producto);
    }
}
