using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda{

    public class Dolar
    {
		private const double cotizacionDefault = 1;
		private double cantidad;
		private static double cotizRespectoDolar;

		static Dolar(){
			cotizRespectoDolar = cotizacionDefault;
		}

		public Dolar(double cantidad){ 
			this.cantidad = cantidad;
		}

		public Dolar(double cantidad, double cotizacion):this(cantidad){
			cotizRespectoDolar  = cotizacion;
		}

		public static explicit operator Dolar( Euro e){			 
			double cantidad = e.GetCantidad() / Euro.GetCotizacion();
            return new Dolar(cantidad);
		}

		public static explicit operator Dolar( Peso p){
			double cantidad = p.GetCantidad() / Peso.GetCotizacion();
			return new Dolar(cantidad);
		}

		public static double GetCotizacion(){
			return cotizRespectoDolar;
		}

		public double GetCantidad(){
			return this.cantidad;
		}

		public static implicit operator Dolar(double d){
			return new Dolar(d);
		}
		
		public static bool operator != (Dolar d, Euro e){
			Dolar d2 = (Dolar) e;
			return (d != d2);
        }    
		
		public static bool  operator != (Dolar d, Peso p){
			Dolar d2 = (Dolar) p;
			return (d != d2);
		}
		
		public static bool  operator != (Dolar d, Dolar d2){
			return ( d.GetCantidad() != d2.GetCantidad());
		}

		public static Dolar operator - (Dolar d, Euro e){		
			return d - (Dolar) e;
		}

		public static Dolar operator - (Dolar d, Peso p){
			return d - (Dolar) p;
		}
		
		public static Dolar operator - (Dolar d, Dolar d2){
			double cantidad =  d.GetCantidad() - d2.GetCantidad();	
			return new Dolar(cantidad);
		}

		public static Dolar operator + (Dolar d, Euro e){		
			return d+ (Dolar) e;
		}

		public static Dolar operator + (Dolar d, Peso p){
			return d + (Dolar) p;
		}
		
		public static Dolar operator + (Dolar d, Dolar d2){
			double cantidad =  d.GetCantidad() + d2.GetCantidad();	
			return new Dolar(cantidad);
		}

		public static bool  operator == (Dolar d, Euro e){
			return (d == (Dolar) e);
		}
		
		public static bool  operator == (Dolar d, Peso p){
			return (d == (Dolar) p);
		}
		
		public static bool  operator == (Dolar d, Dolar d2){
			return ( d.GetCantidad() == d2.GetCantidad());
		}

        public string ToString() {
            return "cantidad:" + this.cantidad;
        }
	}
}