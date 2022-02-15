using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    //Falando de atributos/campos da classe
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        //Falando de Metodos/comportamentos Simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá eu sou " + nome + " " + sobrenome + "\n");
        }
    }
}
