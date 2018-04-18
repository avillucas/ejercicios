using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ejercicio_28
{
    /// <summary>
    /// Utilizar Diccionarios (Dictionary<string, int>) para realizar un contador de palabras, recorriendo el
    /// texto palabra por palabra se deberá lograr que si se trata de una nueva palabra, se la agregará al
    /// diccionario e inicializar su contador en 1, caso contrario se deberá incrementar dicho contador.
    /// Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra.
    /// Informar mediante un MessageBox el TOP 3 de palabras con más apariciones.
    /// </summary>
    class Procesador
    {

        /// <summary>
        /// Determina la cantidad de resultados al mostrar en el ranking del final 
        /// </summary>
        const int tamañoTop = 10;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Contador());
        }

        /// <summary>
        /// Procesa rawText separandolo en palabras y retornando las 3 palabras mas usadas
        /// </summary>
        /// <param name="rawText"></param>
        /// <returns></returns>
        public static Queue<string> Procesar(string rawText) 
        {            
            Dictionary<string, int> contador = new Dictionary<string,int>();
            Queue<string> top3 = new Queue<string>();                        
            //separar palabras            
            MatchCollection coincidencias = Regex.Matches(rawText, @"((\b[^\s]+\b)((?<=\.\w).)?)");
            //
            foreach(var coincidencia in coincidencias)
            {

                string palabra = coincidencia.ToString();
                if(contador.ContainsKey(palabra)) 
                {
                    //sumar al contador de cada palabra 
                    ++contador[palabra];                    
                }
                else 
                {
                    //agregar al diccionario si es que no existe
                    contador.Add(palabra, 1);
                }
            }            
            //OrdenarDescendente y mostrar solo 3 
            foreach (KeyValuePair<string, int> keyValue in  contador.OrderByDescending(i => i.Value))
            {
                top3.Enqueue(keyValue.Key + ": " + keyValue.Value.ToString());
                //cortar cuando encuentre tamaño top pasadas 
                if (top3.Count == tamañoTop) { break; }
            }
            return top3;
        }        
    }
    
}
