using Estaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classe estatica
            //Matematica.taxa = 10;

            //int v1 = Matematica.Adicionar(100);
            //int v2 = Matematica.Diminuir(50);

            //Console.WriteLine(v1);
            //Console.WriteLine(v2);
            #endregion

            Pessoa.maioridade = 21;
            
            Pessoa p1 = new Pessoa();
            p1.nome = "Flávio";
            p1.idade = Pessoa.CalcularIdade(1987);

            Console.WriteLine(p1.nome + " tem " + p1.idade + " anos");

            Console.ReadKey();
        }
    }
}
