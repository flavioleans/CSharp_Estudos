﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MontarTree();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           string node = treeView1.SelectedNode.Text;
            MessageBox.Show(node);
        }

        private void MontarTree()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Nomes");
            treeView1.Nodes[0].Nodes.Add("Flavio");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("dados pessoais");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("dados profissionais");
            treeView1.Nodes[0].Nodes.Add("Leandro");
            treeView1.Nodes[0].Nodes.Add("Silva");
            treeView1.EndUpdate();
        }
    }
}
