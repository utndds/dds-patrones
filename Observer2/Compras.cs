﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class Compras : Observer
    {
        public void update()
        {
            Console.WriteLine("Compras: ");
            Console.WriteLine("Acciones desde compras...");
        }
    }
}
