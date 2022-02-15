using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        /*
          polimorfismo é a propriedade de duas ou mais classes derivadas (Macaco, Homem e Baleia) 
        de uma mesma superclasse (Mamifero) responderem a mesma mensagem (locomoverSe()), 
        cada uma de uma forma diferente (pulando de galho em galho, andando e nadando, respectivamente).
         */
        static void Main(string[] args)
        {
            //Forma a = new Forma(); comentada porque Forma foi alterada para abstract
            Forma t = new Triangulo();
            Forma c = new Circulo();
            Forma r = new Retangulo();

            //Console.WriteLine("Forma:");
            //a.Desenhar();
            Console.WriteLine("Triangulo:");
            t.Desenhar();
            Console.WriteLine("Circulo:");
            c.Desenhar();
            Console.WriteLine("Retangulo:");
            r.Desenhar();

            Console.ReadKey();


        }
    }
}
