using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao C#");
        }

        private void lblTexto_MouseEnter(object sender, EventArgs e)
        {
            lblTexto.ForeColor = Color.Red;
        }

        private void lblTexto_MouseLeave(object sender, EventArgs e)
        {
            lblTexto.ForeColor = Color.Blue;
        }
    }
}
