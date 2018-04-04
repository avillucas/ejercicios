using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesDeMedida
{
    class Kelvin
    {
        private double cantidad;

        /// <summary>
        /// Inicializa en 1 el valor
        /// </summary>
        public Kelvin() : this(1) {
        }

        /// <summary>
        /// Inicializa en cantidad
        /// </summary>
        /// <param name="cantidad"></param>
        public Kelvin(double cantidad) {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Retorna la cantidad  
        /// </summary>
        /// <returns>cantidad de grados</returns>
        public double GetCantidad() {
            return this.cantidad;
        }

        /// <summary>
        /// Retorna los grados kelvin
        /// </summary>
        /// <param name="c"></param>
        public static explicit operator Kelvin(double c) {
            return new Kelvin(c);
        }

        /// <summary>
        /// Retorna la cantidad de grados
        /// </summary>
        /// <param name="k"></param>
        public static explicit operator double(Kelvin k)
        {
            return k.GetCantidad();
        }

        /// <summary>
        /// K = (F + 459.67) * 5/9
        /// </summary>
        public static explicit operator Kelvin(Fahrenheit f) {
            return new Kelvin(((double)f + 459.67) * 5/9);
        }

        /// <summary>
        /// K =  C + 491.67 * 5/9
        /// </summary>
        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin((double)c+491.67*5/9);
        }


        public static bool operator ==(Kelvin k, Kelvin k1)
        {
            return k.GetCantidad() == k1.GetCantidad();
        }

        public static bool operator !=(Kelvin k, Kelvin k1)
        {
            return k.GetCantidad() != k1.GetCantidad(); ;
        }

        public static Kelvin operator -(Kelvin k, Kelvin k1)
        {
            return new Kelvin(k.GetCantidad() - k1.GetCantidad());
        }

        public static Kelvin operator +(Kelvin k, Kelvin k1)
        {
            return new Kelvin(k.GetCantidad() + k1.GetCantidad());
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            Kelvin k1 = (Kelvin)f;
            return k.GetCantidad() == k1.GetCantidad();
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            Kelvin k1 = (Kelvin)f;
            return k.GetCantidad() != k1.GetCantidad();
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            Kelvin k1 = (Kelvin)f;
            return new Kelvin(k.GetCantidad() - k1.GetCantidad());
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            Kelvin k1 = (Kelvin)f;
            return new Kelvin(k.GetCantidad() + k1.GetCantidad());
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            Kelvin k1 = (Kelvin)c;
            return k.GetCantidad() == k1.GetCantidad();
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            Kelvin k1 = (Kelvin)c;
            return k.GetCantidad() != k1.GetCantidad();
        }

        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            Kelvin k1 = (Kelvin)c;
            return new Kelvin(k.GetCantidad() - k1.GetCantidad());
        }

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            Kelvin k1 = (Kelvin)c;
            return new Kelvin(k.GetCantidad() + k1.GetCantidad());
        }
    }
}
