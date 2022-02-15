using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            //Carro c = new Carro();
            //Bicicleta b = new Bicicleta();
            //Caminhonete cm = new Caminhonete();

            //b.Pedalar();
            //b.Acelerar();
            //b.Parar();

            //c.LigarMotor();
            //c.Acelerar();
            //c.Parar();

            //cm.CabineExtendida = true;
            #endregion

            Humano a = new Humano();
            Pessoa p = new Pessoa();
            Homem h = new Homem();

            Console.WriteLine("\nHumano: ");
            a.Olhos();
            a.Cabelos();

            Console.WriteLine("\nPessoa: ");
            p.Olhos();
            p.Cabelos();

            Console.WriteLine("\nHomem: ");
            h.Olhos();
            h.Cabelos();



            Console.ReadKey();
        }
    }
}
