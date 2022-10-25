using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoServer
{
    class FTServer
    {
        static IPEndPoint iPEndPointServer;
        static Socket socketServer;
        public static string EndereceIP = "127.0.0.1";
        public static int PortaHost = 1000;
        public static string PastaRecepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
        public static ListBox ListaMensagem;

        public static void IniciarServidor()
        {
            try
            {
                iPEndPointServer = new IPEndPoint(IPAddress.Parse(EndereceIP), PortaHost);

                socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                socketServer.Bind(iPEndPointServer);
            }
            catch (Exception ex)
            {

                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Erro ao iniciar Servidor: " + ex.Message);
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));
                return;
            }

            try
            {
                socketServer.Listen(100);
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Servidor em atendimento e aguardando para receber arquivos");
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));

                Socket socketClient = socketServer.Accept();
                socketClient.ReceiveBufferSize = 16384; //16kb

                byte[] dadosCliente = new byte[1024 * 50000];

                int tamanhoBytesRecebidos = socketClient.Receive(dadosCliente, dadosCliente.Length, 0);
                int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliente, 0);
                string nomeArquivo = Encoding.UTF8.GetString(dadosCliente, 4, tamanhoNomeArquivo);

                BinaryWriter binaryWriter = new BinaryWriter(File.Open(PastaRecepcaoArquivos + nomeArquivo, FileMode.Append));
                binaryWriter.Write(dadosCliente, 4 + tamanhoNomeArquivo, tamanhoBytesRecebidos - 4 - tamanhoNomeArquivo);

                while (tamanhoBytesRecebidos > 0)
                {
                    tamanhoBytesRecebidos = socketClient.Receive(dadosCliente, dadosCliente.Length, 0);

                    if (tamanhoBytesRecebidos == 0)
                    {
                        binaryWriter.Close();
                    }
                    else
                    {
                        binaryWriter.Write(dadosCliente, 0, tamanhoBytesRecebidos);
                    }

                    ListaMensagem.Invoke(new Action(() =>
                    {
                        ListaMensagem.Items.Add("Arquivo recebido e arquivado [" + nomeArquivo + "]" );
                        ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                    }));

                    binaryWriter.Close();
                    socketClient.Close();
                }
            }
            catch (SocketException ex)
            {
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Erro ao receber o arquivo: " + ex.Message);
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));
            }
            finally
            {
                socketServer.Close();
                socketServer.Dispose();
                IniciarServidor();
            }
        }

    }
}
