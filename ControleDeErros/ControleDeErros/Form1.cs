using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeErros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //tratado erros usando o limite da matriz usando try catch
        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = { 10, 20, 30, 40, 50 };

            try
            {
                string res = "";
                for (int i = 0; i < 10; i++)
                {
                    res += num[i] + " ";
                }
                label1.Text = res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message); //traz apenas a msg de erro.
                //optando apenas por "ex" sera retornado o erro com mais informações
            }
            //bloco que finaliza a aplicação para não ocupar espaço na memória
            // sempre é executada independente do tray catch.
            finally 
            {
                MessageBox.Show("Operação finalizada");
            }
        }
    }
}
