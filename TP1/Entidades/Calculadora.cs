using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida operador y realiza cálculo solicitado
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Resultado de la operación o el mínimo de un doble si hubo error</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno=double.MinValue;
            switch(ValidarOperador(operador))
            {
                case '+':
                    retorno = num1 + num2;
                    break;
                case '-':
                    retorno = num1 - num2;
                    break;
                case '*':
                    retorno = num1 * num2;
                    break;
                case '/':
                    if(!num2.Equals(0))
                    {
                        retorno = num1 / num2;
                    }
                    break;
            }
            return retorno;
        }
        /// <summary>
        /// Valida operador
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Retorna el operador correcto o el operador + si hubo error</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador.Equals('-') ||
                operador.Equals('*') ||
                operador.Equals('/'))
            {
                return operador;
            }
            else
                return '+';
            
        }
    }
}
