using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus_3
{
    class Calculador
    {
        private int acumulador;

        /// <summary>
        /// Constructor por defecto, el cual inicializará el acumulador = 0
        /// </summary>
        public Calculador() { 
            this.acumulador = 0 ;
        }

        /// <summary>
        ///  recibirá un binario en formato ASCII y lo acumulará como entero en el atributo acumulador
        /// </summary>
        /// <param name="numero"></param>
        public void Acumular(string binario) {
            this.acumulador += (int) Conversor.BinarioDecimal(binario);
        }

        /// <summary>
        ///  retornará la variable acumulador convertida a binario.
        /// </summary>
        /// <returns></returns>
        public string GetResultadoBinario()
        {
            return Conversor.EnteroBinario(this.acumulador);
        }

        /// <summary>
        /// retornará la variable acumulador.
        /// </summary>
        /// <returns></returns>
        public int GetResultadoEntero() {
            return this.acumulador;
        }        
         
    }
}
