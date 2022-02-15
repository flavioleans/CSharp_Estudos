using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    //Metodo construtor sempre sera executado na instaciação da classe a qual ele se refere.
    class Pessoa
    {
        public string nome;
        public string sobreNome;
        public int anoNascimento;
        public int idade;

        //construtor
        public Pessoa()
        {
            nome = "desconhecido";
            sobreNome = "nenhum";
            anoNascimento = 1969;
            idade = 0;

        }

        //sobrecarga do costrutor

        public Pessoa(string nome, string sobreNome, int anoNascimento)
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.anoNascimento = anoNascimento;
            idade = Idade();

        }


        public Pessoa(string nome, string sobreNome)
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            idade = Idade();

        }


        private int Idade()
        {
            return  2022 - anoNascimento;
        }
    }
}
