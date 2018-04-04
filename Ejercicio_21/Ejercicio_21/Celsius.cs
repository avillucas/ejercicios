using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesDeMedida
{
    class Celsius
    {
        private double cantidad;

        /// <summary>
        /// Inicializa en 1 el valor
        /// </summary>
        public Celsius() : this(1)
        {
        }

        /// <summary>
        /// Inicializa en cantidad
        /// </summary>
        /// <param name="cantidad"></param>
        public Celsius(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Retorna la cantidad  
        /// </summary>
        /// <returns>cantidad de grados</returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// Retorna los grados kelvin
        /// </summary>
        /// <param name="c"></param>
        public static explicit operator Celsius(double c)
        {
            return new Celsius(c);
        }

        /// <summary>
        /// Retorna la cantidad de grados
        /// </summary>
        /// <param name="c"></param>
        public static explicit operator double(Celsius c)
        {
            return c.GetCantidad();
        }

        /// <summary>
        /// C = (F-32) * 5/9
        /// </summary>
        public static explicit operator Celsius(Fahrenheit f) {
            return new Celsius(((double)f - 32) * (5 / 9));
        }

        /// <summary>
        /// C =  K  – 491.67 * 5/9
        /// </summary>
        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius((double)k - 491.67 * (5 / 9));
        }

        public static bool operator ==(Celsius c, Celsius c1){
            return c.GetCantidad() == c1.GetCantidad();
        }

        public static bool operator !=(Celsius c, Celsius c1)
        {
            return c.GetCantidad() != c1.GetCantidad();
        }

        public static Celsius operator -(Celsius c, Celsius c1)
        {
            return new Celsius(c.GetCantidad() - c1.GetCantidad());
        }

        public static Celsius operator +(Celsius c, Celsius c1)
        {
            return new Celsius(c.GetCantidad() + c1.GetCantidad());
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            Celsius c1 = (Celsius)f;
            return c.GetCantidad() == c1.GetCantidad();
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            Celsius c1 = (Celsius)f;
            return c.GetCantidad() != c1.GetCantidad();
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            Celsius c1 = (Celsius)f;
            return new Celsius(c.GetCantidad() - c1.GetCantidad());
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            Celsius c1 = (Celsius)f;
            return new Celsius(c.GetCantidad() + c1.GetCantidad());
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            Celsius c1 = (Celsius)k;
            return c.GetCantidad() == c1.GetCantidad();
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            Celsius c1 = (Celsius)k;
            return c.GetCantidad() != c1.GetCantidad();
        }

        public static Celsius operator -(Celsius c, Kelvin k)
        {
            Celsius c1 = (Celsius)k;
            return new Celsius(c.GetCantidad() - c1.GetCantidad());
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            Celsius c1 = (Celsius)k;
            return new Celsius(c.GetCantidad() + c1.GetCantidad());
        }

    }
}
