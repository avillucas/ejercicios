using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Contador());
        }

        public static Queue<string> Procesar(string rawText) 
        {
            Dictionary<string, int> contador = new Dictionary<string,int>();
            Queue<string> top3 = new Queue<string>();
            string[] palabras = rawText.Split(' ');
            foreach(string palabra in palabras)
            {
                if (contador.Keys.Any(i => i == palabra))
                {
                    ++contador[palabra];                    
                }
                else 
                {
                    contador.Add(palabra, 1);
                }
            }
            contador= contador.OrderByDescending(v => v.Value);                                               
            
            foreach (KeyValuePair<string, int> keyValue in contador) {
                top3.Enqueue(keyValue.Key + ": " + keyValue.Value.ToString());
                if (top3.Count == 3) { break; }
            }
            return top3;
        }
        
    }
    
}
