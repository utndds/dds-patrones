using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendible auto = new Auto("Fiat Uno", 12000);
            Console.WriteLine (auto.getDescripcion());
            Console.WriteLine(auto.getPrecio());

            Vendible auto2 = new Auto("Chevrolet", 8000);
            Console.WriteLine(auto2.getDescripcion());
            Console.WriteLine(auto2.getPrecio());

            Console.ReadKey();
        }
    }
}
