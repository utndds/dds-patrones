using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CocheFordFactory : CocheFactory
    {
        override public Coche crearCoche ()
        { return new CocheFord();  }

        override public Motor crearMotor ()
        { return new MotorFord(); }

        override public Chasis crearChasis()
        { return new ChasisFord(); }
    }
}
