﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    class Matematica
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine("A soma é: " + (n1 + n2));
        }

        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine("A subtração é: " + (n1 - n2));
        }

        public void Mutiplicar(int n1, int n2)
        {
            Console.WriteLine("A Multiplicação é: " + (n1 * n2));
        }

        public void Dividir(int n1, int n2)
        {
            Console.WriteLine("A divisão é: " + (n1 / n2));
        }
    }
}
