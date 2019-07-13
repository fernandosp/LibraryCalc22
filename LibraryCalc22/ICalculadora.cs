using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc22
{
    /// <summary>
    /// Prove interface calculadora
    /// </summary>
    public interface ICalculadora
    {
        
        int Somar(int valor1, int valor2);
        
        int Dividir(int valor1, int valor2);
        
        int Multiplicar(int valor1, int valor2);

        
        int Sutrair(int valor1, int valor2);

      
        int Somar(int valor1, int valor2, int valor3);
    }
}
