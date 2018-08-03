using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /** "ConcreteBuilder" */
    class PicantePizzaBuilder: PizzaBuilder
    {
    public PicantePizzaBuilder() { base.pizza = new Pizza(); }
    override public void buildMasa() { pizza.setMasa("cocido"); }
    override public void buildSalsa() { pizza.setSalsa("picante"); }
    override public void buildRelleno() { pizza.setRelleno("pimienta+salchichón"); }
}
}
