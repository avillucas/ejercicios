using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal = -1;
        string apellido;
        int legajo;
        string nombre;

        public Alumno(int legajo, string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        /// <summary>
        ///El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
        ///iguales a 4, caso contrario la inicializará con -1.
        ///Para darle un valor a la nota final utilice el método de instancia Next de la clase Random.
        /// </summary>
        public void CalcularFinal() {
            if (this._nota1 >= 4 && this._nota2 >= 4) { 
                Random r = new Random();
                this._notaFinal = (float) r.Next(0, 10);
            }
        }

        /// <summary>
        /// Metodo de carga de las notas
        /// </summary>
        /// <param name="notaUno">Nota del primer examen</param>
        /// <param name="notaDos">Nota del segundo examen</param>
        public void Estudiar(byte notaUno, byte notaDos) {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
            this._notaFinal();
        }

        /// <summary>
        /// d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
        /// mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno        /// desaprobado".
        /// </summary>
        public void Mostrar() {
            Console.WriteLine("Nombre: {0}", this.nombre);
            Console.WriteLine("Apellido: {0}", this.apellido);
            Console.WriteLine("Legajo: {0}", this.legajo);
            Console.WriteLine("Notas: primera = {0}, segunda= {1}", this._nota1, this._nota2);
            if (this._notaFinal != -1)
            {
                Console.WriteLine("Final: {0}",_notaFinal);
            }
            else 
            {
                Console.WriteLine("Alumno desaprobado");
            }
        }
        
    }
}
