using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    //trata as conexão e instancias dos usuarios conectados
    class Conexao
    {
        TcpClient tcpCliente;

        //Thread que ira enviar a informação para o cliente
        private Thread thrSender;
        private StreamReader srReceptor;
        private StreamWriter swEnviador;
        private string usuarioAtual;
        private string strResposta;

        //o construtor da classe que pega a conexão TCP
        public Conexao(TcpClient tcpCon)
        {
            tcpCliente = tcpCon;
            // a thread que aceita o cliente e espera a mensagem
            thrSender = new Thread(AceitaCliente);
            thrSender.IsBackground = true;

            //a thread chama o metodo aceitacliente()
            thrSender.Start();

        }

        private void FechaConexao()
        {
            //Fecha os objetos abertos
            tcpCliente.Close();
            srReceptor.Close();
            swEnviador.Close();
        }

        //ocorre quando um novo cliente é aceito
        private void AceitaCliente()
        {
            srReceptor = new StreamReader(tcpCliente.GetStream());
            swEnviador = new StreamWriter(tcpCliente.GetStream());

            //le a informação da conta do cliente
            usuarioAtual = srReceptor.ReadLine();

            //temos uma resposta do cliente
            if (usuarioAtual != "")
            {
                //armazena o nome do usuario na hash table
                if (Servidor.htUsuarios.Contains(usuarioAtual))
                {
                    //0 => não conectado
                    swEnviador.WriteLine("0| este nome de usario ja existe");
                    swEnviador.Flush();
                    return;
                }
                else if (usuarioAtual == "Administrador")
                {
                    swEnviador.WriteLine("0| este nome de usario ja existe");
                    swEnviador.Flush();
                    return;
                }
                else
                {
                    // 1 =>  conectou com sucesso
                    swEnviador.WriteLine("1");
                    swEnviador.Flush();

                    //inclui o usuario na hash table e inicia a escuta de suas mensagens
                    Servidor.IncluiUsuario(tcpCliente, usuarioAtual);
                }
            }
            else
            {
                FechaConexao();
                return;
            }

            try
            {
                //continua aguardando por uma mensagem do usuario
                while ((strResposta = srReceptor.ReadLine()) != "")
                {
                    //se for inválido remove-o
                    if (strResposta == null)
                    {
                        Servidor.RemoveUsuario(tcpCliente);
                    }
                    else
                    {
                        //envia a mensagem para todos os outros usuarios
                        Servidor.EnviaMensagem(usuarioAtual, strResposta);
                    }
                }
            }
            catch (Exception)
            {
                //se houver problema com o usuario, desconecta-o
                Servidor.RemoveUsuario(tcpCliente);
                throw;
            }
        }

    }
}
