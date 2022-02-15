using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    sealed class Caminhonete : Carro // não pode ser herdada
    {
        public bool CabineExtendida { get; set; }
    }
}
