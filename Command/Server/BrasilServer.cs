using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class BrasilServer : IServer
    {
        public void apagar()
        { Console.WriteLine("Apagando Brasil"); }

        public void prender()
        { Console.WriteLine("Prendiendo Brasil"); }

        public void conectar()
        { Console.WriteLine("Conectar Brasil"); }

        public void verificarConexion()
        { Console.WriteLine("Verificar conexion Brasil"); }

        public void guardarLog()
        { Console.WriteLine("Guardar log Brasil"); }

        public void cerrarConexion()
        { Console.WriteLine("Cerrar conexion Brasil"); }
    }
}
