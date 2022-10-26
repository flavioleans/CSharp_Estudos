﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Browser.Navigate("http://" + textUrl.Text);
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        private void buttonAvancar_Click(object sender, EventArgs e)
        {
            Browser.GoForward();
        }
    }
}
