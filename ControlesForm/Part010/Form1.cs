using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ListViewItem item1 = new ListViewItem("Flávio");
            item1.SubItems.Add("1195988-8156");
            item1.SubItems.Add("leans.flavio@gmail.com");

            ListViewItem item2 = new ListViewItem("Flávio");
            item2.SubItems.Add("118156-95988");
            item2.SubItems.Add("flavioleans@gmail.com");

            ListViewItem item3 = new ListViewItem("da Silva");
            item3.SubItems.Add("1195988-6518");
            item3.SubItems.Add("flavio.leans@gmail.com");

            ListViewItem item4 = new ListViewItem(new string[]
            { "Girlene", "98542-5949", "mp.girlene@hotmail.com" });

            lista.Items.Add(item1);
            lista.Items.Add(item2);
            lista.Items.Add(item3);
            lista.Items.Add(item4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpar
            //lista.Items.Clear();

            //remover item da lista 
            //lista.Items.Remove(lista.SelectedItems[0]);

            //remover por indice
            //lista.Items.RemoveAt(0);


        }
    }
}
