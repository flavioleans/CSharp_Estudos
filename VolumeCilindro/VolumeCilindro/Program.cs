using System;

namespace VolumeCilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A, H, V;
            R = 0;
            while (R <= 0)
            {
                Console.WriteLine("Digite o valor do raio da base do cilindro: ");

                R = double.Parse(Console.ReadLine());
            }

            H = 0;
            while (H <= 0)
            {
                Console.WriteLine("Digite o valor da altura do cilindro: ");
                H = double.Parse(Console.ReadLine());

            }

            Console.WriteLine();
            //area da base
            A = Math.PI * Math.Pow(R, 2);

            //volume do cilindro
            V = A * H;

            Console.WriteLine($"O volume do cilindro é de {V}");
        }
    }
}
