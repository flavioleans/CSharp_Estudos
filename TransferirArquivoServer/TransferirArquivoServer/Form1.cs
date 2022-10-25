using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoServer
{
    public partial class Form1 : Form
    {
        Task tarefa;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabelPasta.Text = FTServer.PastaRecepcaoArquivos;
            FTServer.ListaMensagem = listBoxLog;
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            int porta = (int)numUpPorta.Value;
            string endIP = tbxIP.Text;
            try
            {
                FTServer.EndereceIP = endIP;
                FTServer.PortaHost = porta;

                tarefa = Task.Factory.StartNew(() => {
                    FTServer.IniciarServidor();
                });
            }
            catch (Exception ex)
            {
                listBoxLog.Invoke(new Action(() => {
                    listBoxLog.Items.Add("Erro ao conectar: " + ex.Message);
                    listBoxLog.SetSelected(listBoxLog.Items.Count - 1, true);
                }));
            }
        }

        private void btnPararConexao_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {

                listBoxLog.Invoke(new Action(() => {
                    listBoxLog.Items.Add("Erro: " + ex.Message);
                    listBoxLog.SetSelected(listBoxLog.Items.Count - 1, true);
                }));
            }
        }

        private void linkLabelPasta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
                FTServer.PastaRecepcaoArquivos = dialog.SelectedPath + @"\";
                linkLabelPasta.Text = FTServer.PastaRecepcaoArquivos;
            }
        }

       
    }
}
