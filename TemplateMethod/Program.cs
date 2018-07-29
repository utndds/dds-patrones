using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- MOTOR NAFTERO ----");
            Motor mNaftero = new MotorNaftero();
            mNaftero.RealizarFasesMotor();

            Console.WriteLine("");
            Console.WriteLine("---- MOTOR DIESEL ----");
            Motor mNaftero2 = new MotorDiesel();
            mNaftero2.RealizarFasesMotor();

            Console.ReadKey();
        }
    }
}
