using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc22
{
    public class Calculadora : ICalculadora
    {
        /// <summary>
        /// Metodo Divisão de valores
        /// </summary>
        /// <param name="valor1">Parametro do valor a ser calculado </param>
        /// <param name="valor2">Parametro do valor a ser calculado</param>
        /// <returns>Retorna o resultado da divisaão</returns>
        public int Dividir(int valor1, int valor2)
        {
            return valor1 / valor2;
        }

        /// <summary>
        /// Metodo Multiplicacao
        /// </summary>
        /// <param name="valor1">Parametro do valor a ser calculado </param>
        /// <param name="valor2">Parametro do valor a ser calculado</param>
        /// <returns>Retorna o resultado da multiplicacao</returns>
        public int Multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        /// <summary>
        /// Metodo Soma de valores
        /// </summary>
        /// <param name="valor1">Parametro do valor a ser calculado </param>
        /// <param name="valor2">Parametro do valor a ser calculado</param>
        /// <returns>Retorna o resultado da soma</returns>
        public int Somar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        /// <summary>
        /// Metodo Soma de valores
        /// </summary>
        /// <param name="valor1">Parametro do valor a ser calculado </param>
        /// <param name="valor2">Parametro do valor a ser calculado</param>
        /// <param name="valor3">Parametro do valor a ser calculado</param>
        /// <returns>Retorna o resultado da soma</returns>
        public int Somar(int valor1, int valor2, int valor3)
        {
            return valor1 + valor2 + valor3;
        }

        /// <summary>
        /// Metodo Subtração
        /// </summary>
        /// <param name="valor1">Parametro do valor a ser calculado </param>
        /// <param name="valor2">Parametro do valor a ser calculado</param>
        /// <returns>Retorna o resultado da subtracao</returns>
        public int Sutrair(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
    }
}
