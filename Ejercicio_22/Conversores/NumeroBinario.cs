using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero) {
            this.numero = numero;
        }

        public static implicit operator NumeroBinario(string nb) {
            return new NumeroBinario(nb);
        }

        public static explicit operator NumeroBinario(NumeroDecimal nd) {
            return new NumeroBinario(Conversor.EnteroBinario((int)nd));
        }

        public static explicit operator string(NumeroBinario nb)
        {
            return nb.numero;
        }

         /// <summary>
        ///i. string + (NumeroBinario, NumeroDecimal)
        /// </summary>
        /// <param name="nb"></param>
        /// <param name="nd"></param>
        /// <returns></returns>
        public static string operator +(NumeroBinario nb, NumeroDecimal nd){
            NumeroDecimal nd1 = (NumeroDecimal) nb;
            NumeroBinario numeroBinario = (NumeroBinario) (NumeroDecimal)(nd1 + nd);
            return (string)numeroBinario;
        }

        /// <summary>
        /// ii. string - (NumeroBinario, NumeroDecimal
        /// </summary>
        /// <param name="nb"></param>
        /// <param name="nd"></param>
        /// <returns></returns>
        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            NumeroDecimal nd1 = (NumeroDecimal)nb;
            NumeroBinario numeroBinario = (NumeroBinario)(NumeroDecimal)(nd1 - nd);
            return (string)numeroBinario;
        }

        /// <summary>
        /// iii. bool == (NumeroBinario, NumeroDecimal)
        /// </summary>
        /// <param name="nb"></param>
        /// <param name="nd"></param>
        /// <returns></returns>
        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            NumeroBinario nb1 = (NumeroBinario)nd;
            return (nb.numero == nb1.numero);
        }

        /// <summary>
        /// iv. bool != (NumeroBinario, NumeroDecimal)
        /// </summary>
        /// <param name="nb"></param>
        /// <param name="nd"></param>
        /// <returns></returns>
        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            NumeroBinario nb1 = (NumeroBinario)nd;
            return (nb.numero != nb1.numero);
        }

        public static bool operator ==(NumeroBinario nb, NumeroBinario nb1)
        {
            return (nb.numero == nb1.numero);
        }

        public static bool operator !=(NumeroBinario nb, NumeroBinario nb1)
        {
            return (nb.numero != nb1.numero);
        }

    }
}
