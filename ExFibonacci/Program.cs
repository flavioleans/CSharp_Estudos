using System;

namespace ExFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
        inicio:
            int a = 0, b = 1, c = 0;

            Console.WriteLine("Informe a quantidade de sequência a ser verificada:");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequencia de Fibonacci com " + valores + " valores.");
            for (int i = 0; i < valores; i++)
            {
                if (i < valores -1)
                {
                    Console.Write(a + ",");
                }
                else
                {
                    Console.WriteLine(a);
                }

                c = a + b;
                a = b;
                b = c;

                
            }

            Console.WriteLine("Deseja realizar uma nova consulta? S(SIM) / N(NÃO)");
            char resp = char.Parse(Console.ReadLine());

            if ((resp == 's') || (resp == 'S'))
            {
                Console.Clear();
                goto inicio;
            }

            Console.ReadKey();

        }
    }
}
