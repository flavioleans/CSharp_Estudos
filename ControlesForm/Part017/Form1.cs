using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Flavio")
            {
                MessageBox.Show("Texto digitado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor++;
        }
    }
}
