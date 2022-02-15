using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    class Program
    {
        //separar o programa em parte
        /*
         Encapsulamento é um princípo de design de código, geralmente ligado a programação orientada, 
        que nos orienta a esconder as funcionalidades e funcionamento do nosso código dentro de 
        pequenas unidades (normalmente métodos e funções). Isso possibilita que modificações no sistema 
        possam ser feitas de maneira mais cirurgicas, sem que uma funcionalidade esteja espalhada por 
        diversas partes do sistema.
        Ganhos:
        **Melhor manutenção de código.
        **Divisão de responsabilidades.
        **Reutilização de código.
         */

        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Cliente = "Flávio";

            //******************Operação de Depósito**********************
            double valor = 100;
            c.Depositar(valor);

            //******************Operação de Saque**********************
            double valor2 = 50;
            c.Sacar(valor2);

            //******************Resultado da Operação**********************
            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Saldo: " + c.Saldo);

            Console.ReadKey();

        }
    }
}
