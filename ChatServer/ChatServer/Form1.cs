using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        private delegate void AtualizaStatusCallBack(string strMensagem);
        bool conectado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                Application.Exit();
                return;
            }

            if (txtIp.Text == string.Empty)
            {
                MessageBox.Show("Informe o endereço IP");
                txtIp.Focus();
                return;
            }
            try
            {
                //analisa o endereço ip do servior informado no textbox
                IPAddress enderecoIP = IPAddress.Parse(txtIp.Text);
                int portaHost = (int)numPorta.Value;

                //cria uma nova instancia do objeto chatservidor
                Servidor mainServidor = new Servidor(enderecoIP, portaHost);

                //vincula o tratamento de ecento statusChanged a mainServer_StatusChanged
                Servidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);
                //inicia o atendimento das conexões
                mainServidor.IniciaAtendimento();

                //mostrar que o atendimento foi iniciado
                listaLog.Items.Add("Servidor Ativo, aguardando usuarios se conectarem...");
                listaLog.SetSelected(listaLog.Items.Count - 1, true);
            }
            catch (Exception ex)
            {
                listaLog.Items.Add("Erro de conexão: " + ex.Message);
                listaLog.SetSelected(listaLog.Items.Count - 1, true);
                return;
            }

            conectado = true;
            txtIp.Enabled = false;
            numPorta.Enabled = false;
            btnStartServer.ForeColor = Color.Red;
            btnStartServer.Text = "Sair";
        }

        public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            //chama o metodo que atualiza o formulario
            this.Invoke(new AtualizaStatusCallBack(this.AtualizaSatus), new object[] { e.EventMessage });
        }

        private void AtualizaSatus(string strMensagem)
        {
            //atualiza o log com a mensagens
            listaLog.Items.Add(strMensagem);
            listaLog.SetSelected(listaLog.Items.Count - 1, true);
        }
    }
}
