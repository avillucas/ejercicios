using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private float lado;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;


        /// <summary>
        /// TODO completar
        /// La base de todos los rectángulos de esta clase será siempre horizontal. Por lo tanto, debe
        /// tener un constructor para construir el rectángulo por medio de los vértices 1 y 3 (utilizar el
        /// método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para
        /// obtener la distancia entre puntos).
        /// </summary>
        /// <param name="vertice1"></param>
        /// <param name="vertice2"></param>
        /// <returns></returns>
        public Rectangulo(Punto vertice1, Punto vertice2) { 
        }

                
        /// <summary>
        /// TODO completar el area
        /// </summary>
        /// <returns></returns>
        public float Area()
        {
            return (float) 1;
        }

        /// <summary>
        /// TODO completar
        /// </summary>
        /// <returns></returns>
        public float Perimetro()
        {
            return (float)1;
        }

        /// <summary>
        /// Retorna el perimetro
        /// </summary>
        /// <returns></returns>
        public float GetPerimetro() {
            if (this.perimetro) {
                Perimetro();
            }
                return this.perimetro;
        }


        /// <summary>
        /// Retorna el lado
        /// </summary>
        /// <returns></returns>
        public float GetLado()
        {
            return this.lado;
        }

        /// <summary>
        /// Retorna el area
        /// </summary>
        /// <returns></returns>
        public float GetArea()
        {
            return this.area;
        }
    }
}
