using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /** "Abstract Builder" */
    abstract class PizzaBuilder
    {
        protected Pizza pizza;

        public Pizza getPizza() { return pizza; }

        public abstract void buildMasa();
        public abstract void buildSalsa();
        public abstract void buildRelleno();
    }
}
