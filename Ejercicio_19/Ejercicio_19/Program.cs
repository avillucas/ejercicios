using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    /// <summary>
    /// c. Generar una conversión explícita que retorne cantidadSumas.
    /// d.Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long
    /// con dicho valor.
    /// e.Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual
    ///  cantidadSumas.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //c. Generar una conversión explícita que retorne cantidadSumas.
            Sumador sc = new Sumador(4);
            int cantidadSumas = (int) sc;
            Console.WriteLine("CantidadSumas {0} ", cantidadSumas);
            //d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long  con dicho valor.
            Sumador sd1 = new Sumador(4);
            Sumador sd2 = new Sumador(5);
            long total = sd1 + sd2;
            Console.WriteLine("Total {0} ", total);
            //e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual cantidadSumas.
            Sumador se1 = new Sumador(4);
            Sumador se2 = new Sumador(5);
            Sumador se3 = new Sumador(4);
            if (se1 | se2) {
                Console.WriteLine("Son iguales 1 y 2");
            }
            if (se1 | se3)
            {
                Console.WriteLine("Son iguales 1 y 3");
            }
            Console.ReadLine();
        }
    }
}
