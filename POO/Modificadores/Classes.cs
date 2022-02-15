using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Teste
    {
        private string nome; //visivel somente dentro dessa classe
        public string sobreNome;
        public void Metodo1()
        {

        }

        public void Executar()
        {

        }
    }

    class Humano
    {
        protected string nome;// define que o membro é particular da classe e das heranças
        private string sobreNome;
        internal int idade;//restrito a esta aplicação, se criar uma dll desta classe não será visivel
    }

    class Homem : Humano
    {
       public void Metodo()
        {
            nome = "";
        }
    }
}
