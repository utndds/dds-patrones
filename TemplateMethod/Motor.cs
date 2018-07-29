using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class Motor
    {
        // Fase 1
        // Primera Fase: Admisión
        protected void Admision()
        {
            Console.WriteLine("FASE ADMISION...");
            Console.WriteLine("Acciones comunes para la admisión");
            // Se baja el pistón. Esta operación será distinta en el motor diesel (que
            // inyectará aire) o gasolina (que inyectará una mezcla de aire y combustible)
            BajarPiston();
            Console.WriteLine("Acciones comunes para la admisión");
        }

        abstract public void BajarPiston();

        // Fase 2
        public void Compresion()
        {
            Console.WriteLine("FASE COMPRESION...");
            Console.WriteLine("Compresión válida para cualquier motor");
        }

        // Fase 3
        abstract public void ConsumirCombustible();

        // Fase 4
        public void Escape()
        {
            Console.WriteLine("FASE ESCAPE...");
            Console.WriteLine("Escape válido para cualquier motor");
        }

        // Método público que ejecutará el algoritmo completo
        public void RealizarFasesMotor()
        {
            Admision();             // Parcialmente implementado en la clase base
            Compresion();           // Implementado en la clase base
            ConsumirCombustible();  // Delegado en las clases hijas
            Escape();               // Implementado en la clase base
        }
    }
}
