using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicion_11
{
    /// <summary>
    /// 11. Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
    /// Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
    /// posea la siguiente firma: bool Validar(int valor, int min, int max):
    /// a. valor: dato a validar
    /// b. min y max: rango en el cual deberá estar la variable valor.
    /// Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
    /// Nota: Utilizar variables escalares, NO utilizar vectores.
    /// </summary>
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            int minAceptable = -100;
            int maxAceptactable = 100;
            int min = int.MaxValue;
            int max = int.MinValue;
            int numero;
            float promedio = 0 ;                        
            for(int i = 0 ; i< 10 ; i++){
                Console.Clear();
                Console.Write("Ingrese el numero {0} de 10: ",(i+1));
                if(int.TryParse(Console.ReadLine(),out numero)){
                    if (Validacion.Validar(numero, minAceptable, maxAceptactable)){
                        if (numero < min)
                            min = numero;                        
                        if (numero > max)
                            max = numero;
                        promedio += (float) numero;
                    }else {                        
                        i--;
                        Console.WriteLine("El numero debe estar entre {0} y {1}", minAceptable, maxAceptactable);
                        Console.WriteLine("presione cualquier tecla para continuar.....");
                        Console.ReadKey();
                    }
                }else{
                    i--;
                    Console.WriteLine("Debe ingresar un entero");
                    Console.WriteLine("presione cualquier tecla para continuar.....");
                    Console.ReadKey();                    
                }
            }
            promedio /= 10;
            Console.WriteLine("min:{0}",min);
            Console.WriteLine("max:{0}", max);
            Console.WriteLine("promedio:{0}", promedio);
            Console.WriteLine("presione cualquier tecla para continuar.....");
            Console.ReadKey();
        }
    }
}
