using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class MotorDiesel:Motor
    {
        override public void ConsumirCombustible()
        {
            Console.WriteLine("FASE CONSUMO...");
            Console.WriteLine("El motor diesel consume combustible por combustión");
        }

        public override void BajarPiston()
        {
            Console.WriteLine("Bajando el pistón en motor diesel");
        }
    }
}
