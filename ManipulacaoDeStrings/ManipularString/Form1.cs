using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region Contains / ToString
            //string texto = "Este tipo de variavel é alfanumerica";

            //if (texto.Contains("var"))
            //{
            //    label1.Text = "Contem";
            //}
            //else
            //{
            //    label1.Text = "não Contem";
            //}

            //int num = 5400;

            //label1.Text = num.ToString();
            #endregion

            #region ToUpper / ToLower
            //string nome = "flavio";
            //label1.Text = nome.ToUpper();
            //label1.Text = nome.ToLower();
            #endregion

            #region IndexOf / LastIndexOf
            //string nome = "Flavio Leandro";
            //// int indice = nome.IndexOf('a');
            //// int indice = nome.IndexOf('a', 5, 4); a partir de 5, percorrer 4 caracteres
            //int indiceString = nome.IndexOf("vio");
            //label1.Text = "Indice: " + indiceString;

            //string nome = "Flávio";
            //int indice = nome.LastIndexOf('a'); //ultima ocerrencia
            #endregion

            #region Insert / Replace
            string nome = "Leandro da Silva";

            // string nomeFinal = nome.Insert(0, "Flávio ");

            // string nomeFinal = nome.Replace('a', 'x');

            string nomeFinal = nome.Replace("Leandro", "Girlene");

            label1.Text = nomeFinal;
            #endregion

            #region Length / Substring
            //Length retorna a quantidade de caracters
            //string nome = "Flavio Leandro";
            //int tam = nome.Length;

            //label1.Text = "Meu nome tem " + tam + "Letras";

            //for (int i = 0; i < nome.Length; i++)
            //{
            //    label1.Text += nome[i] + "\n";
            //}

            //Substring retorna um trecho da string original

            //string parte = nome.Substring(nome.IndexOf(" "));

            //label1.Text = parte;
            #endregion

            #region Split
            //SEPARA UMA STRING EM PARTES
            //string nomes = " Flavio Girlene Lucas Nelso Fabio";
            //char[] separador = { ' ' };
            //string[] resultado = nomes.Split(separador);

            //foreach  (string nome in resultado)
            //{
            //    label1.Text += nome + "\n";
            //}

            #endregion

            #region StartsWith / EndsWith
            //string nome = "Flavio";

            //// bool res = nome.StartsWith("Fl", StringComparison.OrdinalIgnoreCase);
            ////segundo atributo ignora o 

            //bool res = nome.EndsWith("vio", StringComparison.OrdinalIgnoreCase);

            //if (res)
            //{
            //    label1.Text = "Positivo";
            //}
            //else
            //{
            //    label1.Text = "Negativo";
            //}
            #endregion

            #region Trim - TrimStart - TrimEnd

            // string msg = " - _ Ola Flávio! ";

            // char[] c = { ' ', '-', '_', ',' };

            //label1.Text = ">"+ msg.Trim(c) +"<";

            // label1.Text = ">" + msg.TrimStart() + "<";

            // label1.Text = ">" + msg.TrimEnd() + "<";
            #endregion

            #region CompareTo - Equals
            //string nome = "Flavio";
            //string nome2 = "Flavio";
            //if (nome.Equals("Flavio"))
            //{
            //    label1.Text = "positivo, "+ nome;
            //}
            //else
            //{
            //    label1.Text = "Negativo, " + nome;
            //}

            //classifica ordem alfabetica
            // label1.Text = nome.CompareTo(nome2).ToString();
            #endregion

            #region Format
            //converte o valor de objeto em cadeias de caracteres

            //decimal valor = 19.95m;

            // string s = "o valor do produto é: " + valor;

            // string s = String.Format("o valor do produto é: {0:C2}", valor);

            // string s = String.Format("Hoje é {0:d} e são {0:t}", DateTime.Now);

            //{ 0:d} retorna R$
            //{ 0:d} retorna data dd/mm/aaaa
            //{ 0:t} retorna horae minuto

            //string s = $"O valor é {valor:C2}";

            //string s = $"Data é {DateTime.Now:D} e Hora é {DateTime.Now:T}";

            //label1.Text = s;
            #endregion
        }
    }
}
