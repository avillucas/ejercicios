using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicion_11
{
    class Validacion
    {
        /// <summary>
        /// Verifica si un entero valor se encuentra entre min y max
        /// </summary>
        /// <param name="valor"> valor ingresado</param>
        /// <param name="min">minimo valor requerido</param>
        /// <param name="max">maximo valor aceptado</param>
        /// <returns>En caso de que sea valido </returns>
        public static bool Validar(int valor, int min, int max) {
            return (valor > min && valor < max);
        }
    }
}
