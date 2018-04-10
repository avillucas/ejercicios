using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    class Conversor
    {
        /// <summary>
        /// Tomando un numero entero devuelve un numero binario 
        /// </summary>
        /// <param name="numeroDecimal">Valor decimal a convertir a binario</param>
        /// <returns>Numero binario</returns>
        public static string EnteroBinario(int numeroEntero) {
            string numeroBinario = "";            
            do {
                float resto = numeroEntero % 2;
                //agregar un 0 en caso de que el resto de la division por 2 sea par
                int parteBinaria = (resto % 2 == 0) ? 0 : 1;                
                //obtener un orden inverso
                numeroBinario = parteBinaria.ToString() + numeroBinario.ToString();
                //procesar el resultado de la division
                numeroEntero = numeroEntero / 2;
            } while (numeroEntero != 1 && numeroEntero != 0);
            //110010
            //agregando el ultimo valor
            numeroBinario = numeroEntero.ToString() + numeroBinario.ToString();
            return numeroBinario;
        }

        /// <summary>
        /// Ingresando un numero binario devuelve su valor decimal
        /// </summary>
        /// <param name="numeroBinario">Numero a procesar</param>
        /// <returns>Numero decimal </returns>
        ///
        public static double BinarioDecimal(string numeroBinario)  {
            double numeroDecimal = 0;
            int exponente = 0 ;
            int numero = 0;
            //Elevar 2 al exponente de cada numero                                                
            for (int i = numeroBinario.Length-1;  i >= 0 ; i--) {
                string posibleNumero = numeroBinario.Substring(i, 1);                
                if (int.TryParse(posibleNumero, out numero)){
                    if (numero != 0 && numero != 1) {
                        throw new Exception(String.Format("El numero {0} no es binario", numeroBinario));
                    }
                    numeroDecimal += (numero *Math.Pow(2, exponente));
                    exponente++;
                }else {
                    throw new Exception(String.Format("Es imposible convertir {0} a decimal", numeroBinario));
                }
            }
            return numeroDecimal;
        }
    }
}
