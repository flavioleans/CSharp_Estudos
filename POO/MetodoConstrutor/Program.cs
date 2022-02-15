using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Console.WriteLine(p1.nome + " " + p1.sobreNome + ", nascido em " + p1.anoNascimento + " e tem " + p1.idade + " anos");

            Pessoa p2 = new Pessoa("Girlene", "Marques", 1992);
            Console.WriteLine(p2.nome + " " + p2.sobreNome + ", nascido em " + p2.anoNascimento + " e tem " + p2.idade + " anos");

            Pessoa p3 = new Pessoa("Lara", "Silva");
            Console.WriteLine(p3.nome + " " + p3.sobreNome + ", nascido em " + p3.anoNascimento + " e tem " + p3.idade + " anos");

            Console.ReadKey();
        }
    }
}
