using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    interface IServer
    {
        void apagar();
        void prender();
        void conectar();
        void verificarConexion();
        void guardarLog();
        void cerrarConexion();
    }
}
