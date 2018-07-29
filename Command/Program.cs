using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Command command = new PrenderServer(new ArgentinaServer());
            Invoker serverAdmin = new Invoker(command);
            serverAdmin.run();
            Console.ReadKey();
        }
    }
}
