using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Carro : Veiculo
    {

        public int velocidadeMax { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("Ligou");
        }
        public override void Acelerar()
        {
            Console.WriteLine("Acelerou");
        }
        public override void Parar()
        {
            Console.WriteLine("Freiou!!");
        }

    }
}
