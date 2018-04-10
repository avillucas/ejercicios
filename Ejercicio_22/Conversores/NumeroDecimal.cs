using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static implicit operator NumeroDecimal(int nd)
        {
            return new NumeroDecimal(nd);
        }

        public static explicit operator NumeroDecimal(NumeroBinario nb)
        {
            return new NumeroDecimal(Conversor.BinarioDecimal((string)nb));
        }

        public static explicit operator double(NumeroDecimal nd) {
            return nd.numero;
        }

        public static explicit operator int(NumeroDecimal nd) {
            return (int) nd.numero;
        }

        public static explicit operator string(NumeroDecimal nd)
        {
            return (nd.numero).ToString();
        }

        public static double operator +(NumeroDecimal nd, NumeroDecimal nd1)
        {
           return nd1.numero + nd.numero;
        }

        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            return (NumeroDecimal)nb + nd;
        }

        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            NumeroDecimal nd1 = (NumeroDecimal)nb;
            return nd1 - nd;
        }

        public static double operator -(NumeroDecimal nd, NumeroDecimal nd1)
        {
            return nd1.numero - nd.numero;
        }

        public static bool operator ==(NumeroDecimal nd, NumeroDecimal nd1)
        {           
            return (nd.numero == nd1.numero);
        }

        public static bool operator !=(NumeroDecimal nd, NumeroDecimal nd1)
        {
            return (nd.numero != nd1.numero);
        }

        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            NumeroDecimal nd1 = (NumeroDecimal)nb;
            return (nd.numero == nd1.numero);
        }
      
        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            NumeroDecimal nd1 = (NumeroDecimal)nb;
            return (nd.numero != nd1.numero);
        }
    }
}
