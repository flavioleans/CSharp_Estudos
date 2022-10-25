using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
        //trata o nome do usuario
        private string nomeUsuario;
        private StreamWriter stwEniador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;

        //atualizar o formulario com mensagens da outra thread
        private delegate void AtualizarLogCallBack(string strMensagem);

        //necessario para definir o formulario para o estado "disconected" de outra thread
        private delegate void FechaConexaoCallBack(string strMensagem);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private int portaHost;
        private bool conectado;

        public Form1()
        {
            //desconecta ao sair da aplicação
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeComponent();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //se não esta conectado aguarda a conexão
            if (!conectado)
            {
                //inicializa a conexão
                InicializaConexao();
            }
            else
            {
                //se esta conectado desconecta
                FecharConexao("Desconectado a pedido do usuario");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarMensagem();
        }

        private void txtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se pressionou Enter
            if (e.KeyChar == (char)13)
            {
                EnviarMensagem();
            }
        }

        private void InicializaConexao()
        {
            try
            {
                //trata o endereço de ip informado
                enderecoIP = IPAddress.Parse(txtServidorIp.Text);
                //trata o numero da porta do host
                portaHost = (int)numPortaHost.Value;
                //inicia uma nova conexão de tcp com o servidor chat
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIP, portaHost);
                //verifica se esta conectado ou não
                conectado = true;
                //prepara o formulario
                nomeUsuario = txtUsuario.Text;
                //desabilitada os campos
                txtServidorIp.Enabled = false;
                numPortaHost.Enabled = false;
                txtUsuario.Enabled = false;
                txtMensagem.Enabled = true;
                btnEnviar.Enabled = true;
                btnConectar.ForeColor = Color.Red;
                btnConectar.Text = "Desconectar";

                //envia nome do usuario ao servidor
                stwEniador = new StreamWriter(tcpServidor.GetStream());
                stwEniador.WriteLine(txtUsuario.Text);
                stwEniador.Flush();

                //inicia a thread para receber mensagens e nova comunicação
                mensagemThread = new Thread(new ThreadStart(ReceberMensagem));
                mensagemThread.IsBackground = true;
                mensagemThread.Start();

                lblStatus.Invoke(new Action(() =>
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = $"Conectado ao servidor de chat {enderecoIP}:{portaHost}";
                }));

            }
            catch (Exception ex)
            {

                lblStatus.Invoke(new Action(() => {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Erro na conexão com o servidor " + ex.Message;
                }));
            }
        }

        private void ReceberMensagem()
        {
            //recebe mensagem do servidor
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string conResposta = strReceptor.ReadLine();
            //se o primeiro caracter da resposta for 1 a conexão foi feita com sucesso
            if (conResposta[0] == '1')
            {
                //atualiza o formulario para informar que esta conectado
                this.Invoke(new AtualizarLogCallBack(this.AtualizarLog), new object[] { "Conectado com sucesso" });
            }
            else
            {
                //se o primeiro caracter da resposta não for 1 a conexão foi feita com sucesso
                string motivo = "Não conectado";
                //extrai o motivo da resposta mensagem, motivo começa no caractere 3
                motivo += conResposta.Substring(2, conResposta.Length - 2);
                //atualiza o formulario como o motvo da falha na conexão
                this.Invoke(new FechaConexaoCallBack(this.FecharConexao), new object[] { motivo });
                //sai do metodo
                return;
            }

            //le as linhas que estão chegando do servidor
            while (conectado)
            {
                //exibe mensagens no textbox
                this.Invoke(new AtualizarLogCallBack(this.AtualizarLog), new object[] { strReceptor.ReadLine() });


            }
        }

        private void AtualizarLog(string strMensagem)
        {
            //anexa o texto ao final de cada linha
            txtLog.AppendText(strMensagem + "\r\n");
        }

        private void EnviarMensagem()
        {
            //envia mensagem ao servidor
            if (txtMensagem.Lines.Length >= 1)
            {
                stwEniador.WriteLine(txtMensagem.Text);
                stwEniador.Flush();
                txtMensagem.Lines = null;
            }
            txtMensagem.Text = "";

        }

        private void FecharConexao(string motivo)
        {
            //mostra o motivo e fecha a conexão com o servidor
            txtLog.AppendText(motivo + "\r\n");
            //habilita e desabilita os controles apropriados no formulario
            txtServidorIp.Enabled = true;
            numPortaHost.Enabled = true;
            txtUsuario.Enabled = true;
            txtMensagem.Enabled = false;
            btnEnviar.Enabled = false;
            btnConectar.ForeColor = Color.Green;
            btnConectar.Text = "Conectar";

            //fechas os objetos
            conectado = false;
            stwEniador.Close();
            strReceptor.Close();
            tcpServidor.Close();
            lblStatus.Invoke(new Action(() =>
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = $"Desconectado do servidor de chat {enderecoIP}:{portaHost}";
            }));
        }

        public void OnApplicationExit(object sender, EventArgs e)
        {
            //tratador de evento para sair da aplicação
            if (conectado)
            {
                //fecha todoas as conexões
                conectado = false;
                stwEniador.Close();
                strReceptor.Close();
                tcpServidor.Close();
                lblStatus.Invoke(new Action(() =>
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = $"Desconectado do servidor de chat {enderecoIP}:{portaHost}";
                }));
            }
        }

    }
}
