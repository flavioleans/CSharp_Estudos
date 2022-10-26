using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part027
{
    public partial class Form1 : Form
    {
        string txt;
        public Form1()
        {
            InitializeComponent();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt = textBox1.Text;
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt = textBox1.Text;
            textBox1.Text = "";
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt != null && txt != "")
            {
                textBox2.Text = txt;
            }
            
        }
    }
}
