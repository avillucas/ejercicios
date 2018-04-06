using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda{

	public class Peso{
		private const double cotizacionDefault = 17.55;
		private double cantidad;
		private static double cotizRespectoDolar;

		static Peso(){
			cotizRespectoDolar = cotizacionDefault;
		}

		public Peso(double cantidad){ 
			this.cantidad = cantidad;
		}

		public Peso(double cantidad, double cotizacion):this(cantidad){
			cotizRespectoDolar  = cotizacion;
		}

		public static explicit operator Peso(Euro e){
            double cantidad = e.GetCantidad() / Euro.GetCotizacion() * GetCotizacion();
			return new Peso(cantidad);
		}

		public static explicit operator Peso(Dolar d){
			double cantidad = d.GetCantidad() * GetCotizacion();
			return new Peso(cantidad);
		}

		public static double GetCotizacion(){
			return cotizRespectoDolar;
		}

		public double GetCantidad(){
			return this.cantidad;
		}

		public static implicit operator Peso(double d){
			return new Peso(d);
		}

        public static bool operator  !=(Peso p, Euro e) { 
			return p != (Peso) e;
		}

        public static bool operator ==(Peso p, Euro e){
			return (p == (Peso) e);
        }

        public static bool  operator !=(Peso p, Dolar d){
			return p != (Peso) d;
		}
		
		public static bool  operator != (Peso p, Peso p2){
			return ( p.GetCantidad() != p2.GetCantidad());
		}

		public static Peso operator - (Peso p, Euro e){		
			return p - (Peso) e;
		}

		public static Peso operator - (Peso p, Dolar d){
			return p - (Peso) d;
		}
		
		public static Peso operator - (Peso p, Peso p2){
			double cantidad =  p.GetCantidad() - p2.GetCantidad();	
			return new Peso(cantidad);
		}

		public static Peso operator + (Peso p, Euro e){		
			return p + (Peso) e;
		}

		public static Peso operator + (Peso p, Dolar d){
			return p + (Peso) d;
		}
		
		public static Peso operator + (Peso p, Peso p2){
			double cantidad =  p.GetCantidad() + p2.GetCantidad();	
			return new Peso(cantidad);
		}		
		
		public static bool  operator == (Peso p, Dolar d){
			return (p == (Peso) d);
		}
		
		public static bool  operator == (Peso p, Peso p2){
			return ( p.GetCantidad() == p2.GetCantidad());
        }

        public string ToString()
        {
            return "cantidad:" + this.cantidad;
        }
    }
}