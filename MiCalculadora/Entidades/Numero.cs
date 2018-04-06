using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        #region Constructores
        
        public Numero(string strNumero) 
        {
            this.SetNumero = strNumero;
        }

        public Numero(double numero)
            : this(numero.ToString())
        {
        }
        #endregion

        public string SetNumero{
            set {
                numero = ValidarNumero(value);
            }
        }
              
        #region Conversores
        /// <summary>
        /// ValidarNumero comprobará que el valor recibido sea numérico, y lo retornará en        /// formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero) {
           double numeroValido = 0 ;
           if (double.TryParse(strNumero, out numeroValido)) {
               return numeroValido;
           }
           return numeroValido;
       }

        /// <summary>
        ///  DecimalBinario convertirán un número decimal a
        ///  binario, en caso de ser posible. Caso contrario retornará "Valor inválido"
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalABinario(string numero)
        {
            double numeroDecimal;
            if (double.TryParse(numero,out numeroDecimal)) 
            {
                return DecimalABinario(numeroDecimal);
            }
            return "Valor inválido";
        }

        /// <summary>
        ///  DecimalBinario convertirán un número decimal a
        ///  binario, en caso de ser posible. Caso contrario retornará "Valor inválido"
        /// </summary>
        /// <param name="numero">Valor decimal a convertir a binario</param>
        /// <returns>Numero binario</returns>
        public static string DecimalABinario(double numero)
        {
            string numeroBinario = "";
            do
            {
                double resto = numero % 2;
                //agregar un 0 en caso de que el resto de la division por 2 sea par
                int parteBinaria = (resto % 2 == 0) ? 0 : 1;
                //obtener un orden inverso
                numeroBinario = parteBinaria.ToString() + numeroBinario.ToString();
                //procesar el resultado de la division
                numero = numero / 2;
            } while (numero != 1 && numero != 0);
            //110010
            //agregando el ultimo valor
            numeroBinario = numero.ToString() + numeroBinario.ToString();
            return numeroBinario;
        }

        /// <summary>
        ///  El método BinarioDecimal convertirá un número binario a decimal, en caso de ser
        ///  posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numeroBinario">Numero a procesar</param>
        /// <returns>Numero decimal o "Valor Invalido"</returns>
        public static string BinarioDecimal(string binario)
        {
            double numeroDecimal = 0;
            int exponente = 0;
            int numero = 0;
            //Elevar 2 al exponente de cada numero                                                
            for (int i = binario.Length - 1; i >= 0; i--)
            {
                string posibleNumero = binario.Substring(i, 1);
                if (int.TryParse(posibleNumero, out numero))
                {
                    numeroDecimal += (numero * Math.Pow(2, exponente));
                    exponente++;
                }
                else
                {
                    return "Valor inválido";
                }
            }
            return numeroDecimal.ToString();
        }
        
        #endregion

        #region Operadores

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2) 
        {
            return n1.numero - n2.numero;
        }

        public static double operator /(Numero n1, Numero n2) 
        {
            //A fin de evitar la division con resolucion infinito
            if (n2.numero == 0) {
                return 0;
            }
            return n1.numero / n2.numero;
        }

        public static double operator *(Numero n1, Numero n2) 
        {
            return n1.numero * n2.numero;
        }

        #endregion
    }    
}
