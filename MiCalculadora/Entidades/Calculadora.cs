using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        /// <summary>
        /// Deberá validar que el operador recibido sea +, -, / o *. Caso contrario retornará +
        /// </summary>
        /// <param name="operador">Operador deseado</param>
        /// <returns>Operando a utilizar</returns>
        private static string ValidarOperador(string operador)
        {
            if (operador == "-" || operador == "/" || operador == "*")
                return operador;
            return "+";            
        }

        public static double Operar(Numero num1, Numero num2, string operador) { 
            string operadorValido = ValidarOperador(operador);
            double resultado = 0 ;
            switch (operadorValido) { 
                case "+":
                    resultado = num1 + num2;
                break;
                case "-":
                    resultado = num1 - num2;
                break;
                case "/":
                    resultado = num1 / num2;
                break;
                case "*":
                    resultado = num1 * num2;
                break;
            }
            return resultado;
        }

    }
}
