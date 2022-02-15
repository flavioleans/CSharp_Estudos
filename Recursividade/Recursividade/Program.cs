using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursivo r = new Recursivo();
            r.ExecutarRecursivo("Olá mundo", 1);

            Console.ReadKey();
        }
    }
}
