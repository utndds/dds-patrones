using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /** "Producto" */
    class Pizza
    {
        private string masa = "";
        private string salsa = "";
        private string relleno = "";

        public void setMasa(string masa)
        {
            this.masa = masa;
            Console.WriteLine("La masa es " + masa);
        }

        public void setSalsa(string salsa)
        {
            this.salsa = salsa;
            Console.WriteLine("La salsa es " + salsa);
        }

        public void setRelleno(string relleno)
        {
            this.relleno = relleno;
            Console.WriteLine("El relleno es " + relleno);
        }
    }
}
