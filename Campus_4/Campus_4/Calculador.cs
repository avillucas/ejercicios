using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus_4
{
    class Calculador
    {
        private int acumulador;

        /// <summary>
        /// Constructor por defecto, el cual inicializará el acumulador = 0
        /// </summary>
        public Calculador() :this(0){          
        }

        /// <summary>
        /// Toma un valor inicial para acumulador
        /// </summary>
        /// <param name="valorInicial"></param>
        public Calculador(int valorInicial) {
            this.acumulador = valorInicial;
        }

        /// <summary>
        /// inicializará el acumulador con el valor recibido. Este constructor no contendrá código y llamará al constructor del punto b
        /// </summary>
        /// <param name="numeroBinario"></param>
        public Calculador(string numeroBinario)
            : this((int)Conversor.BinarioDecimal(numeroBinario))
        {
        }

        /// <summary>
        ///  recibirá un binario en formato ASCII y lo acumulará como entero en el atributo acumulador
        /// </summary>
        /// <param name="numero"></param>
        public void Acumular(string numeroBinario)
        {
            this.Acumular( (int) Conversor.BinarioDecimal(numeroBinario));
        }

        /// <summary>
        ///  recibirá un entero y lo acumulará en acumulador
        /// </summary>
        /// <param name="numeroEntero"></param>
        public void Acumular(int numeroEntero)
        {
            this.acumulador += numeroEntero;
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
