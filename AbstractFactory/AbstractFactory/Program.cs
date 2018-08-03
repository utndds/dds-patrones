using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Coche coche;
            var tipo = "Toyota";

            if (tipo == "Toyota")
                coche = hacerCoche(new CocheToyotaFactory());
            else if (tipo == "Ford")
                coche = hacerCoche(new CocheFordFactory());
        }

        public static Coche hacerCoche(CocheFactory factoria)
        {
            Coche c = factoria.crearCoche();
            c.motor = factoria.crearMotor();
            c.chasis = factoria.crearChasis();
            return c;
        }
    }
}
