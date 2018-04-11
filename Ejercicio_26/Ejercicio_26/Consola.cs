using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Consola
    {

        /// <summary>
        /// Muestra un vector con formato 
        /// </summary>
        /// <param name="vector">Vector de valores a mostrar</param>
        /// <param name="formato">formato en el que mostrarlo</param>
        public static void MostrarVector(int[] vector, string formato) 
        {            
            for (var i = 0; i < vector.Length; i++)
            {                
                Console.Write(formato, vector[i]);
            }            
            CongelarPantalla();
        }

        /// <summary>
        /// Muestra un vector con formato default  {0,10}
        /// </summary>
        /// <param name="vector">vector de valores a mostrar</param>
        public static void MostrarVector(int[] vector)
        {
            MostrarVector(vector, "\n{0,10}");
        }

        /// <summary>
        /// Frena la pantalla a la espera del ingreso de respuesta
        /// </summary>
        private static void CongelarPantalla()
        {
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
