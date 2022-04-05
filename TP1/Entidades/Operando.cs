using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        #region CONSTRUCTORES
        public Operando()
        {
            this.Numero = "0";
        }
        public Operando(string strNumero)
            : this()
        {
            this.Numero = strNumero;
        }
        public Operando(double numero)
            : this(numero.ToString())
        {

        }
        #endregion

        #region PROPIEDADES
        private string Numero 
        {
            set 
            { 
                if(ValidarOperando(value) != 0)
                {
                    this.numero = ValidarOperando(value);
                }                 
            } 
        }
        #endregion

        #region MÉTODOS
        /// <summary>
        /// Convierte un número binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Numero convertido  en formato string si la operación se concreta -
        ///          Mensaje de error si no se pudo convertir</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno;
            double numAuxiliar = 0;
            int binarioLen = binario.Length;
            if (EsBinario(binario))
            {
                foreach (char caracter in binario)
                {
                    binarioLen--;
                    if (caracter == '1')
                    {
                        numAuxiliar += Math.Pow(2, binarioLen);
                    }
                }
                retorno = numAuxiliar.ToString();
            }
            else
            {
                retorno = "Valor Inválido";
            }
            return retorno;

        }
        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Numero convertido  en formato string si la operación se concreta -
        ///          Mensaje de error si no se pudo convertir</returns>
        public string DecimalBinario(double numero)
        {
            string retorno = string.Empty;
            int operando = (int)numero;
            int resto;
            if (operando >= 0)
            {
                do
                {
                    resto = operando % 2;
                    operando /= 2;
                    retorno = resto.ToString() + retorno;
                } while (operando > 0);
            }
            else
                retorno = "Valor Inválido";
            return retorno;
        }
        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Numero convertido  en formato string si la operación se concreta -
        ///          Mensaje de error si no se pudo convertir</returns>
        public string DecimalBinario(string numero)
        {
            string retorno;
            double numAuxiliar;
            //string retorno;
            if (double.TryParse(numero, out numAuxiliar))
            {
                retorno = DecimalBinario(numAuxiliar);
            }
            else
                retorno = "Valor inválido";
            return retorno;
        }
        /// <summary>
        /// Valida que una cadena esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>True si es binario - False si no es binario o hubo error</returns>
        private bool EsBinario(string binario)
        {
            char[] arrayBinario = binario.ToCharArray();
            bool retorno = false;
            foreach (char item in arrayBinario)
            {
                if (item.Equals('0') || item.Equals('1'))
                {
                    retorno = true;
                    continue;
                }
                else
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Valida que el valor recibido sea numérico, y lo retornará en formato double.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            if (Convert.ToDouble(strNumero) != 0)
            {
                return Convert.ToDouble(strNumero);
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static double operator -(Operando n1, Operando n2)
        {
            return (n1.numero - n2.numero);
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return (n1.numero + n2.numero);
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return (n1.numero * n2.numero);
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
                return (n1.numero / n2.numero);
        }
        #endregion    
    }
}
