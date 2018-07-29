using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class PrenderServer : Command 
    {
        private IServer servidor;

        public PrenderServer(IServer servidor)
        { this.servidor = servidor; }

        public void execute()
        {
            servidor.conectar();
            servidor.verificarConexion();
            servidor.prender();
            servidor.guardarLog();
            servidor.cerrarConexion();
        }

    }
}
