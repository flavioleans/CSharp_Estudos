using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
   abstract class Veiculo //não pode ser instaciadas, servem como base
    {
        public string Cor { get; set; }

        public string Marca { get; set; }

        public abstract void Acelerar();// são obrigados a serem executados, mas como "override" no lugar de "abstract", com coportamentos diferentes

        public abstract void Parar();
        
    }
}
