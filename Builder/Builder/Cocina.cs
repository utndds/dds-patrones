using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /** "Director" */
    class Cocina
    {
        private PizzaBuilder pizzaBuilder;

        public void setPizzaBuilder(PizzaBuilder pb) { pizzaBuilder = pb; }
        public Pizza getPizza() { return pizzaBuilder.getPizza(); }

        public void construirPizza()
        {
            pizzaBuilder.buildMasa();
            pizzaBuilder.buildSalsa();
            pizzaBuilder.buildRelleno();
        }
    }
}
