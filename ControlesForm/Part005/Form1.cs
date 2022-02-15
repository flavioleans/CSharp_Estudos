using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string texto = checkBox1.Text;
            bool status = checkBox1.Checked;
            MessageBox.Show(texto + " " + status);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string texto = checkBox2.Text;
            bool status = checkBox2.Checked;
            MessageBox.Show(texto + " " + status);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string texto = checkBox3.Text;
            bool status = checkBox3.Checked;
            MessageBox.Show(texto + " " + status);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checados = "";
            if (checkBox1.Checked)
            {
                checados += checkBox1.Text + " - ";
            }

            if (checkBox2.Checked)
            {
                checados += checkBox2.Text + " - ";
            }

            if (checkBox3.Checked)
            {
                checados += checkBox3.Text + " - ";
            }

            MessageBox.Show(checados);
        }
    }
}
