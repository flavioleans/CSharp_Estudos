using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region TryParse
            //caso não consiga converter retorna 0
            //int num;
            //bool res = int.TryParse("1987sad", out num); atribuição fora do if
            //if (int.TryParse("1987sad", out num))
            //{
            //    label1.Text = num.ToString();
            //}
            //else
            //{
            //    label1.Text = "Impossivel converter";
            //}
            #endregion

            #region ToString / Convert.ToString
            //int num = 120;
            ////formatando as saidas dos decimais
            ////não modifica o valor, apenas a acrescenta 00 na saida
            //label1.Text = num.ToString("#.00");

            //converter para hexadecimal - para minimo de digito ("x3")
            //int num = 256;
            // label1.Text = num.ToString("x");
            //decimal
            // label1.Text = num.ToString("d");
            //monetario R$
            //label1.Text = num.ToString("C");

            //converter de forma direta com convert no segundo parametro
            //podendo ser em 8 octal, 10 decimal, 16 hexa
            //label1.Text = Convert.ToString(num, 8);
            #endregion

            #region Classe Math
            double pi = Math.PI;
            double E = Math.E;
            double seno = Math.Sin(3);
            double conseno = Math.Cos(3);
            double potencia = Math.Pow(2, 3);
            double raizq = Math.Sqrt(60);
            double arredonda = Math.Round(15.35);
            double ignoraDecimal = Math.Truncate(25.35);
            double arredondaBaixo = Math.Floor(75.75);
            double arredondaCima = Math.Ceiling(75.75);

            label1.Text = arredondaCima.ToString();
            #endregion
        }
    }
}
