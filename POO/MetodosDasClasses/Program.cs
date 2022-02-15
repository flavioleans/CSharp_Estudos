using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            #region Metodo Simples
            //m.Cumprimentar();
            //m.Somar(10, 5);
            #endregion

            #region Metodo com Parametros
            // m.Apresentar("Flávio", 33);
            #endregion

            #region Passagem de parametro por valor e por referencia
            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentarValor(valor1);
            //Console.WriteLine();
            //m.AumentarRef(ref valor2);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);
            #endregion

            #region Metodos com retorno de valores
            //string nomeCompleto = m.MontaNome("Flávio", "Leandro");
            //int codigoChar = m.CodigoChar('a');
            //double pi = m.ValorPi();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codigoChar);
            //Console.WriteLine(pi);
            #endregion

            m.Cumprimentar();
            m.Cumprimentar("Flávio");
            m.Cumprimentar("Flávio", 15);

            bool res1 = m.Comparar(100, 5);
            bool res2 = m.Comparar("Flavio", "Flavio");

            Console.WriteLine(res1);
            Console.WriteLine(res2);

            Console.ReadKey();
        }
    }
}
