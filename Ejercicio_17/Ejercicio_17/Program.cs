using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_17_Library;

namespace Ejercicio_17
{
    /// <summary>
    /// En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta
    /// de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo = "";
            string dibujo2 = "";
            //
            Boligrafo miBoligrafo = new Boligrafo(ConsoleColor.Blue, 100);
            miBoligrafo.Pintar(5,out dibujo);
            miBoligrafo.SetColor(ConsoleColor.Green);
            ImprimirDibujo(dibujo, miBoligrafo);            
            //
            Boligrafo miBoligrafo2 = new Boligrafo(ConsoleColor.Red, 50);
            miBoligrafo2.Recargar();            
            miBoligrafo2.Pintar(70, out dibujo2);            
            ImprimirDibujo(dibujo2, miBoligrafo2);
            //
            Console.ReadKey();
            
        }

        private static void ImprimirDibujo(string dibujo, Boligrafo boligrafo) {
            if (dibujo.Length > 0)
            {            
                Console.ForegroundColor = boligrafo.GetColor();
                Console.WriteLine("{0}",dibujo);
                Console.WriteLine("Queda {0} tinta en el boligrafo", boligrafo.GetTinta());

            }
        }
    }
}
