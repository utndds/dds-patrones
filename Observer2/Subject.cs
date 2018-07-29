using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    abstract class Subject
    {
        private List<Observer> _observadores = new List<Observer>();

        public void attach (Observer _observer)
        {
            _observadores.Add(_observer);
        }
        
        public void dettach(Observer _observer)
        {
            _observadores.Remove(_observer);
        }

        public void notify()
        {
            for (int i = 0; i < _observadores.Count; i++)
                _observadores[i].update();
        }
    }
}
