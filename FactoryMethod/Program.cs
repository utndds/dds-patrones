using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var tf = new TrianguloFactory();
            var eq = tf.createTriangulo(5, 4, 6);
            Console.WriteLine("LadoA: " + eq.getLadoA());
            Console.WriteLine("LadoB: " + eq.getLadoB());
            Console.WriteLine("LadoC: " + eq.getLadoC());
            Console.WriteLine(eq.getDescripcion());
            Console.WriteLine("");

            var tf2 = new TrianguloFactory();
            var eq2 = tf2.createTriangulo(4, 4, 6);
            Console.WriteLine("LadoA: " + eq2.getLadoA());
            Console.WriteLine("LadoB: " + eq2.getLadoB());
            Console.WriteLine("LadoC: " + eq2.getLadoC());
            Console.WriteLine(eq2.getDescripcion());
            Console.WriteLine("");

            var tf3 = new TrianguloFactory();
            var eq3 = tf3.createTriangulo(7, 7, 7);
            Console.WriteLine("LadoA: " + eq3.getLadoA());
            Console.WriteLine("LadoB: " + eq3.getLadoB());
            Console.WriteLine("LadoC: " + eq3.getLadoC());
            Console.WriteLine(eq3.getDescripcion());
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
