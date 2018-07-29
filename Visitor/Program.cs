using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoDescuento producto1 = new ProductoDescuento();
            producto1.setPrecio(200);
            IVA iva = new IVA();
            Console.WriteLine("Producto Normal");
            Console.WriteLine(producto1.getPrecio() + producto1.accept(iva));

            ProductoNormal producto2 = new ProductoNormal();
            producto2.setPrecio(200);
            Console.WriteLine("Producto con descuento");
            Console.WriteLine(producto2.getPrecio() + producto2.accept(iva));

            Console.ReadKey();
        }
    }
}
