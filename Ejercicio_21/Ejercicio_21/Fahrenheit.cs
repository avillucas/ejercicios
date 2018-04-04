using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesDeMedida
{
    class Fahrenheit
    {
        private double cantidad;

        /// <summary>
        /// Inicializa en 1 el valor
        /// </summary>
        public Fahrenheit() : this(1)
        {
        }

        /// <summary>
        /// Inicializa en cantidad
        /// </summary>
        /// <param name="cantidad"></param>
        public Fahrenheit(double cantidad)
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
        public static explicit operator Fahrenheit(double c)
        {
            return new Fahrenheit(c);
        }

        /// <summary>
        /// Retorna la cantidad de grados
        /// </summary>
        /// <param name="f"></param>
        public static explicit operator double(Fahrenheit f)
        {
            return f.GetCantidad();
        }

        /// <summary>
        /// F = C * (9/5) + 32
        /// </summary>
        /// <param name="c"></param>
        public static explicit operator Fahrenheit(Celsius c) {
            return new Fahrenheit((double) c * (9 / 5) + 32);
        }

        /// <summary>
        /// F = K * 9/5 – 459.67
        /// </summary>
        /// <param name="k"></param>
        public static explicit operator Fahrenheit(Kelvin k) {
            return new Fahrenheit((double)k * 9 / 5 - 459.67);
        }

        public static bool operator ==(Fahrenheit f, Fahrenheit f1)
        {
            return f.GetCantidad() == f1.GetCantidad();
        }

        public static bool operator !=(Fahrenheit f, Fahrenheit f1)
        {
            return f.GetCantidad() != f1.GetCantidad();
        }

        public static Fahrenheit operator -(Fahrenheit f, Fahrenheit f1)
        {
            return new Fahrenheit(f.GetCantidad() - f1.GetCantidad());
        }

        public static Fahrenheit operator +(Fahrenheit f, Fahrenheit f1)
        {
            return new Fahrenheit(f.GetCantidad() + f1.GetCantidad());
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            Fahrenheit f1 = (Fahrenheit)c;
            return f.GetCantidad() == f1.GetCantidad();
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            Fahrenheit f1 = (Fahrenheit)c;
            return f.GetCantidad() != f1.GetCantidad();
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            Fahrenheit f1 = (Fahrenheit)c;
            return new Fahrenheit(f.GetCantidad() - f1.GetCantidad());
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            Fahrenheit f1 = (Fahrenheit)c;
            return new Fahrenheit(f.GetCantidad() + f1.GetCantidad());
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            Fahrenheit f1 = (Fahrenheit)k;
            return f.GetCantidad() == f1.GetCantidad();
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            Fahrenheit f1 = (Fahrenheit)k;
            return f.GetCantidad() != f1.GetCantidad();
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            Fahrenheit f1 = (Fahrenheit)k;
            return new Fahrenheit(f.GetCantidad() - f1.GetCantidad());
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            Fahrenheit f1 = (Fahrenheit)k;
            return new Fahrenheit(f.GetCantidad() + f1.GetCantidad());
        }
    }
}
