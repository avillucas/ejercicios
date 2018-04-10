using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversores;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;
            string a = (string)objBinario;
            double d = (double)objDecimal;
            Console.WriteLine("El numero binario {0} es {1} en decimal", a, (double)(NumeroDecimal)objBinario);
            Console.WriteLine("El numero decimal {0} es {1} en binario", d,(string) (NumeroBinario)objDecimal);

            //
            string nb1 = objBinario + objDecimal;
            double nd1 = objDecimal + objBinario;
            Console.WriteLine("El numero binario {0} es {1} sumados dan {2} y en decimal {3}",(string)objDecimal, (string)objBinario, nb1, nd1);
            //
            string nb2 = objBinario - objDecimal;
            double nd2 = objDecimal - objBinario;
            Console.WriteLine("El numero binario {0} es {1} restados dan {2} y en decimal {3}", (string)objDecimal, (string)objBinario, nb1, nd1);
            //
            if (objBinario == objDecimal) {
                Console.WriteLine("El numero binario {0} es {1} son  iguales", (string)objDecimal, (string)objBinario);
            }
            if (objBinario != objDecimal) {
                Console.WriteLine("El numero binario {0} es {1} son  destintos", (string)objDecimal, (string)objBinario);
            }
            if (objDecimal == objBinario)
            {
                Console.WriteLine("El numero binario {0} es {1} son  iguales", (string)objDecimal, (string)objBinario);
            }
            if (objDecimal != objBinario)
            {
                Console.WriteLine("El numero binario {0} es {1} son  destintos", (string)objDecimal, (string)objBinario);
            }
            Console.ReadKey();
        }
    }
}
