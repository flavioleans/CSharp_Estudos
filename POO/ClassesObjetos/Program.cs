    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //OutraClasse outra = new OutraClasse();
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Flávio";
            p1.sobrenome = "Leandro";
            p1.anoNascimento = 1987;

            //outro modo

            Pessoa p2 = new Pessoa()
            {
                nome = "Girlene",
                sobrenome = "Marques",
                anoNascimento = 1992
            };

            Console.WriteLine("Pessoa modo 1:");
            Console.WriteLine(p1.nome + "\n" + p1.sobrenome + "\n" + p1.anoNascimento);

            p1.Cumprimentar();

            Console.WriteLine("Pessoa modo 2:");
            Console.WriteLine(p2.nome + "\n" + p2.sobrenome + "\n" + p2.anoNascimento);

            p2.Cumprimentar();

            Console.ReadKey();

        }

        class MinhaClasse
        {

        }
    }
}
