using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            lista.Items.Add(nome);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            object item = lista.SelectedItem;
            lista.Items.Remove(item);
        }

        private void btnRemomeIndice_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            lista.Items.RemoveAt(indice);
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lista.SelectedItem.ToString();
            textBox1.Text = nome;
        }

        private void btnQtd_Click(object sender, EventArgs e)
        {
            int qtdItems = lista.Items.Count;
            MessageBox.Show("A quantidade de items da lista é: " + qtdItems);
        }
    }
}
