using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = args[0];
            string senha = "1234";

            if (senha != args[1])
            {
                Console.WriteLine("Senha invalida, acesso negado!");
            }
            else
            {
                Console.WriteLine("Olá "+ args[0]); 
            }

            

            Console.ReadKey();
        }
    }
}
