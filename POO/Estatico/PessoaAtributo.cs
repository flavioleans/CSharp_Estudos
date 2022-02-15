using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    //membros pode ser estaticos mesmo que a classe não seja.
   partial class Pessoa
    {
        public static int maioridade = 18;

        public string nome;
        public int idade;

       
    }
}
