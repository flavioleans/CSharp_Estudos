using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    class Program
    {
        //Delegate é tipo de dado criado por nos mesmos que serve para armazenar as referencias de metodos
        //do mesmo formato que ele foi declarado (mesmo tipo de retorno e assinatura)
        //Deve ser declarado na raiz do programa.

        delegate void Operacao(int num1, int num2);
        static void Main(string[] args)
        {
            Matematica m = new Matematica();
            
            Operacao conta = null;

            conta += m.Somar; // não passa parametro e sim a referente do metodo "Somar"
            conta += m.Subtrair;
            conta += m.Mutiplicar;
            conta += m.Dividir;

            conta(10, 2);

            Console.WriteLine();

            conta -= m.Dividir;
            conta -= m.Subtrair;

            conta(10, 2);


            Console.ReadKey();
        }
    }
}
