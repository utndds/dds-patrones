using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ArgentinaServer : IServer 
    {
        public void apagar()
        { Console.WriteLine("Apagando Argentina"); }

        public void prender()
        { Console.WriteLine("Prendiendo Argentina"); }

        public void conectar()
        { Console.WriteLine("Conectar Argentina"); }

        public void verificarConexion()
        { Console.WriteLine("Verificar conexion Argentina"); }

        public void guardarLog()
        { Console.WriteLine("Guardar log Argentina"); }

        public void cerrarConexion()
        { Console.WriteLine("Cerrar conexion Argentina");  }
    }
}
