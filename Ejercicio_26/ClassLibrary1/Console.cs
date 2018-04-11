using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus_1
{
    class Console
    {
        public static void init() {            
            int opcion ;            
            do {
                imprimirMenu();
                opcion = leerNumeroEntero();
                if (opcion <= 0 && opcion >= 4){
                    System.Console.WriteLine("Seleccione una opcion valida 1, 2 o 3");
                }else {                     
                    switch (opcion){
                        case 1: EnteroBinario(); break;
                        case 2: BinarioDecimal(); break;
                    }
                }
                System.Console.Clear();
            } while (opcion != 3);   
        }

        /// <summary>
        /// Devuelve un número entero tomado del ingreso del usuario 
        /// </summary>
        /// <returns></returns>
        private static int leerNumeroEntero() {
            bool valido = false;
            int opcion;
            do{                
                if (int.TryParse(System.Console.ReadLine(), out opcion)){                    
                    valido = true;                    
                }else{
                    System.Console.WriteLine("Debe ingresar un número");
                }
            } while (!valido);
            return opcion;
        }

        /// <summary>
        /// Obtener el numero entero y convertirlo a binario mostrandolo
        /// </summary>
        private static void EnteroBinario() {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write("Ingrese un numero decimal: ");
            int numeroEntero = leerNumeroEntero();
            string numeroBinario = Conversor.EnteroBinario(numeroEntero);
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("El numero binario es : " + numeroBinario.ToString());
            System.Console.Write("Presione cual tecla para volver al menu....");
            System.Console.ReadKey();
        }

        /// <summary>
        /// Obtener el numero Binario , convertirlo en decimal y mostrarlo 
        /// </summary>
        private static void BinarioDecimal()
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write("Ingrese un numero binario: ");
            //TODO validar el numero como binario
            string binario = System.Console.ReadLine();
            double numeroDecimal = Conversor.BinarioDecimal(binario);
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("El numero decimal es : "+numeroDecimal.ToString());
            System.Console.Write("Presione cual tecla para volver al menu....");
            System.Console.ReadKey();
        }        

        /// <summary>
        /// Imprimir el menu de opciones
        /// </summary>
        private static void imprimirMenu() {
            System.Console.Clear();
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Menu de opciones");
            System.Console.WriteLine("1 - Convierte un número de entero a binario");
            System.Console.WriteLine("2 -  Convierte un número binario a decimal");
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("3 - Salir");
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write("Selecione una opcion: ");
        }

        

    }
}
