using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo.Items.Add("Carro");
            combo.Items.Add("Moto");
            combo.Items.Add("Barco");
            combo.Items.Add("Avião");

            combo.Items.AddRange(new object[] { "Cavalo", "Elevador", "Bike" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(combo.Items.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object item = combo.SelectedItem;
            int indice = combo.SelectedIndex;
            MessageBox.Show("Item: " + item + " Indice: " + indice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //remove pelo indice
            combo.Items.RemoveAt(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Inseri a posição e o valor que deseja
            combo.Items.Insert(2, "rolemã");
        }
    }
}
