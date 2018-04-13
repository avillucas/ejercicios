using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        const short cantidadDeNumeros = 20;

        static void Main(string[] args)
        {
        
            conListas();
            //conPilas();
        }

        private static void conListas() 
        {
            int numero;
            List<int> numeros = new List<int>();
            Random random = new Random();
            for (int i = 0; i < cantidadDeNumeros; i++)
            {
                numero = random.Next(int.MinValue, int.MaxValue);
                if (numero != 0)
                {
                    numeros.Add(numero);
                }
                else
                {
                    i--;
                }
            }
            //lista original
            Consola.MostrarLista(numeros);
            //
            List<int> positivos = numeros.Where(i => (i > 0)).ToList<int>();
            //positivos descendentes
            Consola.MostrarLista(positivos.OrderByDescending(i => i).ToList<int>(), "Positivos Descendentes");
            //negativos ascendentes
            List<int> negativos = numeros.Where(i => (i < 0)).ToList<int>();
            Consola.MostrarLista(negativos.OrderBy(i => i).ToList<int>(), "Negativos Ascendentes");
            Consola.CongelarPantalla();
        }
      
        private static void tester() {
        
        }
        
        private static void conPilas(){
            //Generar los valores 
            Stack<int> numeros = new Stack<int>();
            Stack<int> positivos = new Stack<int>();
            Stack<int> negativos = new Stack<int>();            
            int numero ;
            Random random = new Random();               
            for (var i = 0; i < cantidadDeNumeros; i++ ) {
                numero = random.Next(int.MinValue, int.MaxValue);
                if (numero != 0)
                {
                    if (numero > 0)
                    {
                        positivos.Push(numero);
                    }
                    else 
                    {
                       negativos.Push(numero);
                    }
                    numeros.Push(numero);                    
                }
                else 
                {
                    i--;
                }
            }
            //a. Mostrar el vector tal como fue ingresado
            Consola.MostrarPila(numeros);
            numeros.OrderBy(num => num);
            Consola.MostrarPila(numeros);
            Consola.CongelarPantalla();
        }
    }
}
