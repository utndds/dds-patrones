using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ApagarServer : Command 
    {
        private IServer servidor;

        public ApagarServer(IServer servidor)
        { this.servidor = servidor;  }

        public void execute()
        {
            servidor.conectar();
            servidor.verificarConexion();
            servidor.guardarLog();
            servidor.apagar();
            servidor.cerrarConexion();
        }
    }
}
