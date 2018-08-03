using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Cocina cocina = new Cocina();
            PizzaBuilder hawai_pizzabuilder = new HawaiPizzaBuilder();
            PizzaBuilder picante_pizzabuilder = new PicantePizzaBuilder();

            Console.WriteLine("Con Hawai:");
            cocina.setPizzaBuilder(hawai_pizzabuilder);
            cocina.construirPizza();
            Pizza pizza = cocina.getPizza();

            Console.WriteLine("Con Picante:");
            cocina.setPizzaBuilder(picante_pizzabuilder);
            cocina.construirPizza();
            Pizza pizza2 = cocina.getPizza();

            Console.ReadKey();
        }
    }
}
