using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    class Recursivo
    {
        //não recursivo
        public void Executar(string mensagem, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mensagem);
            }

            
        }

        //Recursivo
        public void ExecutarRecursivo(string msg, int n)
        {
            if (n > 0)
            {
                Console.WriteLine(msg);
                ExecutarRecursivo(msg, n - 1);
            }
          
        }
    }

}
