using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class Biblioteca
    {
        public void devuelveLibro(Libro _libro, AlarmaLibro _alarma)
        {
            if (_libro.getEstado() == "MALO")
            {
                _alarma.notify();                       
            }
            else
            {
                Console.WriteLine("Sin acción definida");
            }
        }
    }
}
