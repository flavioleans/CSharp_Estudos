using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    sealed class Bicicleta : Veiculo //impede que a classe seja herdada
    {
       

        public void Pedalar()
        {
            Console.WriteLine("Pedalou");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Pedalou mais rápido");
        }

        public override void Parar()
        {
            Console.WriteLine("Freiou!!");
        }

    }
}
