using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejericio 16";
            //
            Alumno alumno1 = new Alumno(101,"Tito","Perez");
            alumno1.Estudiar(4,5);
            Alumno alumno2 = new Alumno(102, "Edgar","MatMahon");
            alumno2.Estudiar(1,1);
            Alumno alumno3 = new Alumno(103, "Pepito", "CarlSon");
            alumno3.Estudiar(2,8);
            //
            alumno1.Mostrar();
            VisualSeparator();
            alumno2.Mostrar();
            VisualSeparator();
            alumno3.Mostrar();
            Console.ReadKey();
        }

        private static void VisualSeparator()
        {
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
