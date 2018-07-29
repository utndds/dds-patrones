using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class Libro
    {
        private string _estado;

        public void setEstado(string _estado)
        {
            this._estado = _estado;
        }

        public string getEstado()
        {
            return this._estado;
        }
    }
}
