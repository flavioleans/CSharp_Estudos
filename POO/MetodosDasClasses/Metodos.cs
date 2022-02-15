using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    class Metodos
    {
        //Metodo Simples - sem retorno e parametros

        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo!");
        }

        //Metodo com parametros

        public  void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos.");
        }

        //Passagem de parametro por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é: " + valor);
        }

        //passagem de parametro por referencia - altera na raiz

        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por referencia) é: " + valor);
        }

        //Metodos com retorno de valores 
        public string MontaNome(string nome, string sobreNome)
        {
           // string nomeCompleto = nome + " " + sobreNome;
            return nome + " " + sobreNome; ;
        }

        public int CodigoChar(char caractere)
        {
            //int codigo = (int)caractere;
            return caractere;
        }

        public double ValorPi()
        {
            return 3.1415;
        }

        //Sobrecarga/Overloading de metodos - mesmo metodo, mas com assinatura/parametros diferente

        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá, "+ nome);
        }

        public void Cumprimentar(string nome, int hora)
        {
            string msg = hora < 12 ? "Bom dia" + nome : "Boa tarde " + nome;
            Console.WriteLine(msg);
        }

        public bool Comparar(int num, int num2)
        {
            return num == num2;
        }

        public bool Comparar(string txtNum, string txtNum2)
        {
            return txtNum == txtNum2;
        }



    }
}
