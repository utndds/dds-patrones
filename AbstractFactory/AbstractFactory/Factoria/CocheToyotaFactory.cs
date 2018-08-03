using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class CocheToyotaFactory:CocheFactory
    {
        override public Coche crearCoche()
        { return new CocheToyota(); }

        override public Motor crearMotor()
        { return new MotorToyota(); }

        override public Chasis crearChasis()
        { return new ChasisToyota(); }
    }
}
