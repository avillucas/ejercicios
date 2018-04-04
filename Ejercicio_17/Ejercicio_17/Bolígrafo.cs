using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_Library
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta) {
            this.SetTinta(tinta);
            this.color = color;
        }

        /// <summary>
        /// Retorna el color del boligrafo
        /// </summary>
        /// <returns></returns>
        public ConsoleColor GetColor() { 
            return this.color; 
        }

        /// <summary>
        /// Retorna cantidad de tinta
        /// </summary>
        /// <returns></returns>
        public short GetTinta() { 
            return this.tinta; 
        }

        /// <summary>
        /// Define el color del boligrafo
        /// </summary>
        /// <param name="color"></param>
        public void SetColor(ConsoleColor color) {
            this.color = color;
        }

        /// <summary>
        /// Permite determinar la cantidad de tinta
        /// </summary>
        /// <param name="tinta"></param>
        public void SetTinta(short tinta) {
            if (tinta <= Boligrafo.cantidadTintaMaxima && tinta >= 0)
            {
                this.tinta = tinta;
            }
            //TODO tirar un error en caso de que sea mayor 
        }

        /// <summary>
        /// El método Pintar(int, out string) restará la tinta gastada, sin poder quedar el nivel en
        /// negativo, avisando si pudo pintar (nivel de tinta mayor a 0). También informará mediante el
        /// out string tantos "*" como haya podido "gastar" del nivel de tinta. O sea, si nivel de tinta es
        /// 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es 10 "***".
        /// </summary>
        /// <param name="gasto">Cantidad de tinta que se desea gastar</param>
        /// <param name="dibujo">Contendra el dibujo</param>
        /// <returns> Determina si se pudo pintar todo el dubijo pretendido</returns>
        public bool Pintar(int gasto, out string dibujo) { 
            dibujo = "";
            bool fuePosiblePintar = true;
            for (int i = 1; i <= gasto; i++) {
                if ((this.tinta - 1) >= 0)
                {
                    dibujo += "*";
                    this.SetTinta((short)(this.tinta - 1));                                        
                }
                else
                {
                    fuePosiblePintar = false;
                    break;                    
                }
            }            
            return fuePosiblePintar; 
        }

        /// <summary>
        ///  Recargar() colocará a tinta en su nivel máximo de tinta.
        /// </summary>
        public void Recargar() {
            this.SetTinta(cantidadTintaMaxima);
        }       

    }
}
