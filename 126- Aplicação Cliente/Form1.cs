using ServiceReference;

namespace _126__Aplicação_Cliente
{
    public partial class Form1 : Form
    {
        ContratoServidorClient contratoServidorClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnviaString_Click(object sender, EventArgs e)
        {
            contratoServidorClient = new ContratoServidorClient();
            contratoServidorClient.EnviaStringProServidor(textBoxEnviaString.Text);
            contratoServidorClient.Close();
        }

        private void buttonPegaString_Click(object sender, EventArgs e)
        {
            contratoServidorClient = new ContratoServidorClient();
            textBoxPegaString.Text = contratoServidorClient.PegaStringDoServidor();
            contratoServidorClient.Close();
        }
    }
}