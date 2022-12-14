using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace _137__Décimo_segundo_projeto
{
    public partial class Form1 : Form
    {
        TcpListener ? tcpListener;
        TcpClient ? tcpClient;
        Thread ? servidorThread;
        bool podePararThreadServidor;

        public Form1()
        {
            InitializeComponent();
            tcpListener = null;
            tcpClient = null;
            servidorThread= null;
            podePararThreadServidor= false;
        }

        private void buttonEnviarMensagem_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar o cliente para se conectar em algum servidor de outra aplicação
                TcpClient tcpClient= new TcpClient(textBoxIPDoContato.Text, Convert.ToInt32(textBoxPortaDoContato.Text));
                NetworkStream ns = tcpClient.GetStream();

                // Enviando mensagem
                string mensagem = $"{textBoxMeuNome.Text} : {richTextBoxMensagensParaEnviar.Text}";
                byte[] mensagemBytes =  Encoding.ASCII.GetBytes(mensagem);
                ns.Write(mensagemBytes, 0, mensagemBytes.Length);

                // Fechando conexão
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAplicarConfigServidor_Click(object sender, EventArgs e)
        {
            ParaServidor();
            servidorThread = new Thread(() =>
            {
                tcpListener = new TcpListener(IPAddress.Any, Convert.ToInt32(textBoxPortaDoServidor.Text));
                tcpListener.Start();

                do
                {
                    try
                    {
                        tcpClient = tcpListener.AcceptTcpClient();
                        NetworkStream ns = tcpClient.GetStream();

                        // Lendo mensagem do cliente
                        byte[] bufferMensagemRecebida = new byte[256];
                        int bytesRecebidos = ns.Read(bufferMensagemRecebida, 0, bufferMensagemRecebida.Length);
                        string mensagemRecebidaStr = Encoding.ASCII.GetString(bufferMensagemRecebida, 0, bytesRecebidos);

                        AtualizaRichTextBox($"\r\n{mensagemRecebidaStr}");
                    } catch (SocketException ex)
                    {
                        if ((SocketError)ex.ErrorCode != SocketError.Interrupted)
                        {
                            MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } while (podePararThreadServidor == false);
            });
            servidorThread.Start();
        }

        public void AtualizaRichTextBox(string pMensagem)
        {
            if (richTextBoxMensagens.InvokeRequired)
                richTextBoxMensagens.Invoke((MethodInvoker)(() => AtualizaRichTextBox(pMensagem)));
            else
                richTextBoxMensagens.Text += pMensagem;
        }

        public void ParaServidor()
        {
            try 
            {
                podePararThreadServidor = true;
                if (tcpListener != null)
                {
                    tcpListener.Stop();
                    tcpListener = null;
                }
                if (tcpClient != null)
                {
                    tcpClient.Close();
                    tcpClient = null;
                }
                if (servidorThread != null)
                    servidorThread.Join();

                podePararThreadServidor = false;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParaServidor();
        }
    }
}