using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Invoker
    {
        private Command command;

        public Invoker(Command command)
        { this.command = command; }

        public void run()
        { command.execute(); }
    }
}
