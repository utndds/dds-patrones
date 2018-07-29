using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class MotorNaftero:Motor
    {
        override public void ConsumirCombustible()
        {
            Console.WriteLine("FASE CONSUMO...");
            Console.WriteLine("El motor naftero consume combustible por explosión");
        }

        public override void BajarPiston()
        {
            Console.WriteLine("Bajando el pistón en motor naftero");
        }
    }
}
