using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class CocheFactory
    {
        public abstract Coche crearCoche();

        public abstract Motor crearMotor();

        public abstract Chasis crearChasis();
    }
}
