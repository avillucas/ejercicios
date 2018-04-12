using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    /// <summary>
    /// Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de
    /// cero de forma aleatoria utilizando la clase Random.
    /// a. Mostrar el vector tal como fue ingresado
    /// b. Luego mostrar los positivos ordenados en forma decreciente.
    /// c. Por último, mostrar los negativos ordenados en forma creciente.
    /// </summary>
    class Ejercicio_26
    {
        const short cantidadDeNumeros = 20;

        static void Main(string[] args)
        {            
            int[] numeros = new int[cantidadDeNumeros];
            int numero;
            Random random = new Random();               
            for (var i = 0; i < cantidadDeNumeros; i++ ) {
                numero = random.Next(int.MinValue, int.MaxValue);
                if (numero != 0)
                {
                    numeros[i] = numero;                    
                }
                else 
                {
                    i--;
                }
            }
            //a. Mostrar el vector tal como fue ingresado
            Consola.MostrarVector(numeros);
            // b. Luego mostrar los positivos ordenados en forma decreciente.
            foreach (int nro in numeros) { 
                
            }
            // c. Por último, mostrar los negativos ordenados en forma creciente.

        }
        

    }
}
