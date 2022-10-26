using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            //expressão lambda que tem uma expressão como corpo:
            //(input - parameters) => expression

            //instrução lambda que tem um bloco de instrução como corpo:
            //(input - parameters) => { < sequence - of - statements > }

            //sem lambda
            //Func<int, int> square = quadrado;
            //labelResultado.Text = "o resultado é: " + square(5);

            //com lambda
            Func<int, int> square = x => x * x;
            //labelResultado.Text = "o resultado é: " + square(5);

            Expression<Func<int, int>> ex = x => x + x;
            //labelResultado.Text = ex.ToString();

            //lambda com link
            int[] numbers = { 2, 3, 4, 5 };
            var squareNumbers = numbers.Select(x => x * x);
            //labelResultado.Text = string.Join(" ", squareNumbers);

            //Action<string> greet = name =>
            //{
            //    string greeting = $"Hello {name}!";
            //    labelResultado.Text = greeting;
            //};

            //greet("Flavio");

            //-----------------------------------------
            //Action line = () => Console.WriteLine();
            //Console.WriteLine("Flavio ");
            //line();
            //Console.WriteLine("Leandro");

            Func<int, int, bool> testForEquality = (x, y) => x == y;
            labelResultado.Text = testForEquality(10,10).ToString();
            
        }

        int quadrado(int x)
        {
            return x * x;
        }
    }
}
