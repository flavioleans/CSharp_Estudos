using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FTClient.LabelMensagem = lblStatus;
        }

        private void linkLabelArquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Enviar arquivo";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                linkLabelArquivo.Text = dialog.FileName;
            }

        }

        private void brnEnviarArquivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIP.Text) || 
                string.IsNullOrEmpty(numUpPorta.Value.ToString()) ||
                linkLabelArquivo.Text == "Clique para selecionar um arquivo...")
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Dados inválidos";
                return;
            }

            string enderecoIP = txtIP.Text;
            int porta = (int)numUpPorta.Value;
            string nomeArquivo = linkLabelArquivo.Text;

            FTClient.EnderecoIP = enderecoIP;
            FTClient.PortaHost = porta;
            

            try
            {
                Task.Factory.StartNew(() =>
                {
                    FTClient.EnviarArquivo(nomeArquivo);
                });
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Erro:\n" + ex.Message;
            }
        }
    }
}
