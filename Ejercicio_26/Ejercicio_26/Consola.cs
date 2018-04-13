using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Consola
    {              
        private static string defaultFormat;                
        
        static Consola(){
            defaultFormat =  "{0,20}";
        }

        

        /// <summary>
        /// Muestra un vector con formato 
        /// </summary>
        /// <param name="vector">Vector de valores a mostrar</param>
        /// <param name="formato">formato en el que mostrarlo</param>
        public static void MostrarVector(int[] vector, string formato) 
        {
            Console.WriteLine("Vector Original");
            for (var i = 0; i < vector.Length; i++)
            {                
                Console.WriteLine(formato, vector[i]);
            }                     
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="formato"></param>
        public static void MostrarVectorPositivos(int[] vector, string formato) 
        {
            Console.WriteLine("Vector Positivo");
            for (var i = 0; i < vector.Length; i++)
            {
                if (vector[i] > 0)
                {
                    Console.WriteLine(formato, vector[i]);
                }
            }                     
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="formato"></param>
        public static void MostrarVectorNegativos(int[] vector, string formato)
        {
            Console.WriteLine("Vector Negativo");
            for (var i = 0; i < vector.Length; i++)
            {
                if (vector[i] < 0)
                {
                    Console.WriteLine(formato, vector[i]);
                }
            }
        }

        /// <summary>
        /// Muestra un vector con formato default  {0,10}
        /// </summary>
        /// <param name="vector">vector de valores a mostrar</param>
        public static void MostrarVector(int[] vector)
        {
            MostrarVector(vector,defaultFormat);
        }

        public static void MostrarVectorNegativos(int[] vector)
        {
            MostrarVectorNegativos(vector, defaultFormat);
        }

        public static void MostrarVectorPositivos(int[] vector)
        {
            MostrarVectorPositivos(vector, defaultFormat);
        }

        /// <summary>
        /// Frena la pantalla a la espera del ingreso de respuesta
        /// </summary>
        public static void CongelarPantalla()
        {
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
