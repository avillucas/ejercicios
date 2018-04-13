using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Consola
    {
        private static string defaultFormat;

        static Consola()
        {
            defaultFormat = "{0,20}";
        }




        public static void MostrarPila(Stack<int> vector, string formato)
        {
            Console.WriteLine("Vector Original");
            foreach( int valor in vector)
            {
                Console.WriteLine(formato, valor);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="formato"></param>
        public static void MostrarPilaPositivos(Stack<int> vector, string formato)
        {
            Console.WriteLine("Vector Positivo");
            foreach( int valor in vector)            
            {
                if (valor  > 0)
                {
                    Console.WriteLine(formato, valor);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="formato"></param>
        public static void MostrarPilarNegativos(Stack<int> vector, string formato)
        {
            Console.WriteLine("Vector Negativo");
            foreach (int valor in vector)
            {
                if (valor < 0)
                {
                    Console.WriteLine(formato, valor);
                }
            }
        }

        /// <summary>
        /// Muestra un vector con formato default  {0,10}
        /// </summary>
        /// <param name="vector">vector de valores a mostrar</param>
        public static void MostrarPila(Stack<int> vector)
        {
            MostrarPila(vector, defaultFormat);
        }

        public static void MostrarPilaNegativos(Stack<int> vector)
        {
            MostrarPilarNegativos(vector, defaultFormat);
        }

        public static void MostrarPilaPositivos(Stack<int> vector)
        {
            MostrarPilaPositivos(vector, defaultFormat);
        }

        /// <summary>
        /// Frena la pantalla a la espera del ingreso de respuesta
        /// </summary>
        public static void CongelarPantalla()
        {
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        /// <summary>
        /// Muestra una lista
        /// </summary>
        /// <param name="lista"></param>
        public static void MostrarLista(List<int> lista)
        {
            MostrarLista(lista, "Lista Original");
        }

        /// <summary>
        /// Mostrar lista 
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="titulo">titulo  a usar</param>
        public static void MostrarLista(List<int> lista, string titulo)
        {
            Console.WriteLine(titulo);
            foreach (int valor in lista)
            {
                Console.WriteLine(defaultFormat, valor);                
            }
        }        
    }
}
