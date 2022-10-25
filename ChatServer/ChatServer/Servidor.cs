using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    //necessario para especificar os parametros que estamos passando no nosso evento
    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
    class Servidor
    {
        //esta has table armazena os usuarios e as conexões (acessado/consultado por usuario)
        public static Hashtable htUsuarios = new Hashtable(30); //30 usuarios é o limite definido
       
        //este hash table armazena os suario e as conexões (acessada/consultada por conexão)
        public static Hashtable htConexoes = new Hashtable(30); //30 usuarios é o limite definido

        //armazena o endereço IP passado
        private IPAddress enderecoIP;
        private int portaHost;
        private TcpClient tcpCliente;

        //o evento e o seu argumento irá notificar o formulario quando um usuario se conecta,
        public static event StatusChangedEventHandler StatusChanged;
        private static StatusChangedEventArgs e;

        //construtor define o endereço ip para aquele retornado pela instaciação do objeto
        public Servidor(IPAddress endereco, int porta)
        {
            enderecoIP = endereco;
            portaHost = porta;
        }

        //A thread que ira tratar o escutador de conexões
        private Thread thrListener;

        //O  objeto TCP object que escuta as conexões
        private TcpListener tlsCliente;

        //Ira dizer ao laçõ while para manter a monitoração das conexões
        bool ServRodando = false;

        public static void IncluiUsuario(TcpClient tcpUsuario, string strUsername)
        {
            //primeiro inclui o nome e conexão assciada para amabas as hash tables
            Servidor.htUsuarios.Add(strUsername, tcpUsuario);
            Servidor.htConexoes.Add(tcpUsuario, strUsername);

            //informa a nova conexão para todos os usuarios para  o formulario do servidor
            EnviaMensagemAdmin(htConexoes[tcpUsuario] + " Entrou...");
        }

        //remove o usuario das tabelas (has tables)
        public static void RemoveUsuario(TcpClient tcpUsuario)
        {
            //se o usuario existir
            if (htConexoes[tcpUsuario] != null)
            {
                //primeiro moestra a informação e informa os outros usuario sobre a conexão
                EnviaMensagemAdmin(htConexoes[tcpUsuario] + " Saíu...");

                //remove o usuario da hashtable
                Servidor.htUsuarios.Remove(Servidor.htConexoes[tcpUsuario]);
                Servidor.htConexoes.Remove(tcpUsuario);
            }
        }

        //chamado quando queremos disparar o evento StatusChanged
        public static void OnStatusChanged(StatusChangedEventArgs e)
        {
            StatusChangedEventHandler statusHandler = StatusChanged;

            if (statusHandler != null)
            {
                //invoca o delegate
                statusHandler(null, e);
            }
        }

        //envia mensagens administrativas
        public static void EnviaMensagemAdmin(string Mensagem)
        {
            StreamWriter swSenderSender;

            //exibe primeiro na aplicaçao
            e = new StatusChangedEventArgs("Administrador " + Mensagem);
            OnStatusChanged(e);

            //criar um array de clientes TCPs do tamanho do numero de clientes existentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];

            //copia os objetos TcpClient no array
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            //percorre a lista de clientes TCP
            for (int i = 0; i < tcpClientes.Length; i++)
            {
                //tenta enviar a mensagem para cada cliente
                try
                {
                    //se a mensagem estiver em braco u a conexão for nula sai..
                    if (Mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }

                    //envia mensagem para o usuario atual no laço
                    swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSenderSender.WriteLine("Admnistrador: " + Mensagem);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch (Exception)
                {
                    //se houver um problema, usuario não existe, então remove-o
                    RemoveUsuario(tcpClientes[i]);
                }
            }

        }

        //envia mensagem de m usuario para todos os outros
        public static void EnviaMensagem(string origem, string Mensagem)
        {
            StreamWriter swSenderSender;

            //primeiro exibe a mensagem na aplicação
            e = new StatusChangedEventArgs(origem + " disse: " + Mensagem);
            OnStatusChanged(e);

            //cria um array de clientes TCPs do tamanho do numero de clientes existentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];
            
            //copia os objetos TcpClient no array
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            //percorre a lista de clientes TCP
            for (int i = 0; i < tcpClientes.Length; i++)
            {
                //tenta enviar a mensagem para cada cliente
                try
                {
                    //se a mensagem estiver em braco u a conexão for nula sai..
                    if (Mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }

                    //envia mensagem para o usuario atual no laço
                    swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSenderSender.WriteLine("Usuario: " + Mensagem);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch (Exception)
                {
                    //se houver um problema, usuario não existe, então remove-o
                    RemoveUsuario(tcpClientes[i]);
                }
            }
        }

        public void IniciaAtendimento()
        {
            try
            {
                //Pega o Ip
                IPAddress ipaLocal = enderecoIP;
                int portaLocal = portaHost;

                //cria um objeto TCP listener usando o ip do servidor e porta definidas
                tlsCliente = new TcpListener(ipaLocal, portaLocal);

                //inicia o TCP listener e escuta as conexões
                tlsCliente.Start();

                //o laço while verifica se o servidro esta rodando antes de checar as conexões
                ServRodando = true;

                //inicia uma nova tread que hospeda o listener
                thrListener = new Thread(MantemAtendimento);
                thrListener.IsBackground = true;
                thrListener.Start();
            }
            catch (Exception ex)
            {

            }
        }

        private void MantemAtendimento()
        {
            //enquanto o servidor estiver rodando
            while (ServRodando)
            {
                //aceita uma conexão pendente
                tcpCliente = tlsCliente.AcceptTcpClient();

                //cria uma nova instancia da conexão
                Conexao newConnection = new Conexao(tcpCliente);
            }
        }
    }
}
