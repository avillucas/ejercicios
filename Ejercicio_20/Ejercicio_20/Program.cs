using Billetes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    /// <summary>
    /// Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí
    /// con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro
    /// equivale a 1,3642 dólares y 1 dólar equivale a 17,55 pesos.
    /// b.Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los
    /// distintos tipos de datos.
    /// c.Colocar dentro del Main el código necesario para probar todos los métodos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Euro  e = new Euro(1);
            Dolar d = (Dolar) e;
            Peso  p = (Peso)  e;
            Console.WriteLine(" 1 Euro son {0:####,00} Dolares y {1:####,00} Pesos", d.ToString(),p.ToString());
            Dolar d1 = new Dolar(1);
            Euro  e1 = (Euro) d1;
            Peso  p1 = (Peso) d1;
            Console.WriteLine(" 1 Dolar son {0:####,00} Euros y {1:####,00} Pesos", e1.ToString(), p1.ToString());
            Peso  p2 = new Peso(1);
            Euro  e2 = (Euro) p2;
            Dolar d2 = (Dolar)p2;
            Console.WriteLine(" 1 Peso son {0:####,00} Dolares y {1:####,00} Euros", d2.ToString(), e2.ToString());
            Peso pa = new Peso(1);
            Peso pb = new Peso(1);
            Dolar da = new Dolar(1);
            Dolar db = new Dolar(1);
            Euro ea = new Euro(1);
            Euro eb = new Euro(1);
            //
            if (pa == pb) Console.WriteLine(" PA == PB");
            if (pa != pb) Console.WriteLine(" PA != PB");
            Console.WriteLine(" 1 Peso + 2 Pesos son: {0}", (new Peso(1) + new Peso(2)).ToString());
            Console.WriteLine(" 1 Peso - 2 Pesos son: {0}", (new Peso(1) - new Peso(2)).ToString());
            //
            if (da == db) Console.WriteLine(" DA == DB");
            if (da != db) Console.WriteLine(" DA != DB");
            Console.WriteLine(" 1 Dolar + 2 Dolares son: {0}", (new Dolar(1) + new Dolar(2)).ToString());
            Console.WriteLine(" 1 Dolar - 2 Dolares son: {0}", (new Dolar(1) - new Dolar(2)).ToString());
            //
            if (ea == eb) Console.WriteLine(" EA == EB");
            if (ea != eb) Console.WriteLine(" EA != EB");
            Console.WriteLine(" 1 Euro + 2 Euros son: {0}", (new Euro(1) + new Euro(2)).ToString());
            Console.WriteLine(" 1 Euro - 2 Euros son: {0}", (new Euro(1) - new Euro(2)).ToString());
            //
            Console.ReadKey();
        }
    }
}
