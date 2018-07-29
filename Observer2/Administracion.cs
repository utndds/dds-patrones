using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class Administracion : Observer 
    {
        public void update()
        {
            Console.WriteLine("Administración: ");
            Console.WriteLine("Envío una queja formal...");
        }
    }
}
