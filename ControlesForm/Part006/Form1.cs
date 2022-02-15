using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.Add("Carro");
            checkedListBox1.Items.Add("Barto");
            checkedListBox1.Items.Add("Moto");
            checkedListBox1.Items.Add("Avião");

            int qtdItens = checkedListBox1.Items.Count;
            //MessageBox.Show("total" + qtdItens);
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            //checkedListBox1.Items.Clear(); //desmarcar

            //checkedListBox1.Items.AddRange(new object[] { "Bike", "Mobilete", "Ônibus" });

            //bool res = checkedListBox1.Items.Contains("Moto");

            //if (res)
            //{
            //    MessageBox.Show("Contem");
            //}

            //checkedListBox1.Items.Remove("Moto");

            //Remover por indice
            //checkedListBox1.Items.RemoveAt(1);

            //inserir após determinado indice
            //checkedListBox1.Items.Insert(1, "Cavalo");

            //retorna itens marcados

            // var itens = checkedListBox1.CheckedItems;

            var itens = checkedListBox1.SelectedItems;

            foreach (var item in itens)
            {
                MessageBox.Show(item.ToString());
            }



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = checkedListBox1.SelectedItem.ToString();
        }
    }
}
