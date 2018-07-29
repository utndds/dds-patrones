using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Agregar observadores
            AlarmaLibro _a = new AlarmaLibro();
            _a.attach(new Compras());
            _a.attach(new Administracion());

            // Crear libro y setear el estado
            Console.WriteLine("LIBRO 1 - Estado Malo");
            Libro _libro = new Libro();
            _libro.setEstado("MALO");

            // Agregar devolucion del libro
            Biblioteca b = new Biblioteca();
            b.devuelveLibro(_libro, _a);

            // Crear libro 2 y setear el estado
            Console.WriteLine("LIBRO 2 - Estado Bueno");
            Libro _libro2 = new Libro();
            _libro2.setEstado("BUENO");

            // Agregar devolucion del libro
            b.devuelveLibro(_libro2, _a);

            Console.ReadKey();
        }
    }
}
