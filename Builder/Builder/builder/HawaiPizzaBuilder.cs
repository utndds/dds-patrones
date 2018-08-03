using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /** "ConcreteBuilder" */
    class HawaiPizzaBuilder : PizzaBuilder
    {
    public HawaiPizzaBuilder() { base.pizza = new Pizza(); }
    override public void buildMasa() { pizza.setMasa("suave"); }
    override public void buildSalsa() { pizza.setSalsa("dulce"); }
    override public void buildRelleno() { pizza.setRelleno("chorizo+alcachofas"); }
    }
}
