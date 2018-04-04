using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas;

        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }

        public static bool operator | (Sumador s1, Sumador s2)
        {
            return (s1.cantidadSumas == s2.cantidadSumas);
        }

        public static long operator + (Sumador s1, Sumador s2) {
            return (long)(s1.cantidadSumas + s2.cantidadSumas);
        }

        /// <summary>
        /// Inicializa en 0 cantidadSumas
        /// </summary>
        public Sumador():this(0) {  }

        /// <summary>
        /// Define la cantidad de sumas
        /// </summary>
        /// <param name="cantidadSumas"></param>
        public Sumador(int cantidadSumas) { this.cantidadSumas = cantidadSumas; }

        /// <summary>
        /// Suma dos valores 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public long Suma(long a, long b) {
            this.cantidadSumas++;
            return a + b;
        }

        /// <summary>
        ///  Concatena dos strings
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Suma(string a, string b) {
            this.cantidadSumas++;
            return a + b;
        }
    }
}
