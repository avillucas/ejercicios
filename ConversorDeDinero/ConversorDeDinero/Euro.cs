using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda{

	class Euro{

		private const double cotizacionDefault = 0.733;
		private double cantidad;
		private static double cotizRespectoDolar;

		static Euro(){
			cotizRespectoDolar = cotizacionDefault;
		}

		public Euro(double cantidad){ 
			this.cantidad = cantidad;
		}

		public Euro(double cantidad, double cotizacion):this(cantidad){
            cotizRespectoDolar = cotizacion;
		}

		public static explicit operator Euro( Peso p){			
			Dolar d = (Dolar) p;
			double cantidad = d.GetCantidad()*Euro.GetCotizacion();
			return new Euro(cantidad);
		}

		public static explicit operator Euro( Dolar d){
			double cantidad = d.GetCantidad()* Euro.GetCotizacion();
			return new Euro(cantidad);
		}

		public static double GetCotizacion(){
			return cotizRespectoDolar;
		}

		public double GetCantidad(){
			return this.cantidad;
		}

		public static implicit operator Euro(double d){
			return new Euro(d);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return e != (Euro)p;
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return (e == (Euro)p);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return d != (Euro)e;
        }        

        public static Euro operator -(Euro e, Peso p)
        {
            return e - (Euro)p;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return e - (Euro)d;
        }

        public static Euro operator -(Euro e, Euro e2)
        {
            return new Euro(e.GetCantidad() - e2.GetCantidad());
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return e + (Euro)p;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e + (Euro)d;
        }

        public static Euro operator +(Euro e, Euro e2)
        {
            return new Euro(e.GetCantidad() + e2.GetCantidad());
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }

        public static bool operator ==(Euro e, Euro e2)
        {
            return (e.GetCantidad() == e2.GetCantidad());
        }

        public static bool operator !=(Euro e, Euro e2)
        {
            return (e.GetCantidad() != e2.GetCantidad());
        }

        public string ToString()
        {
            return "cantidad:" + this.cantidad;
        }
    }
}