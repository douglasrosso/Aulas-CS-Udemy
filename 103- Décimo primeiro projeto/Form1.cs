using _103__CadastroBiblioteca;
using System.Windows.Forms;

namespace _103__Décimo_primeiro_projeto
{
    public partial class Form1 : Form
    {
        BaseDeDados baseDeDados;

        public Form1()
        {
            InitializeComponent();
            baseDeDados = new BaseDeDados("BaseDeDados.xml");
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa(textBoxNomeCompleto.Text, textBoxNumeroDoDocumento.Text, Convert.ToDateTime(textBoxDataDeNascimento.Text), textBoxNomeDaRua.Text, Convert.ToUInt32(textBoxNumeroDaCasa.Text));
            baseDeDados.AdicionarPessoa(cadastroPessoa);
            MessageBox.Show("Usuário cadastradado com sucesso", "Cadastro concluído");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.PesquisarPessoaPorDoc(textBoxBuscaNumeroDoDocumento.Text);
            if (listaPessoas != null && listaPessoas.Count > 0)
            {
                labelNomeCompleto.Text = listaPessoas[0].Nome;
                labelDataDeNascimento.Text = listaPessoas[0].DataDeNascimento.ToString();
                labelNomeDaRua.Text = listaPessoas[0].NomeDaRua;
                labelNumeroDaCasa.Text = listaPessoas[0].NumeroDaCasa.ToString();
            }
            else
            {
                MessageBox.Show("Usuário não localizado", "Exceção");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.RemoverPessoaPorDoc(textBoxBuscaNumeroDoDocumento.Text);
            if (listaPessoas != null && listaPessoas.Count > 0)
            {
                labelNomeCompleto.Text = listaPessoas[0].Nome;
                labelDataDeNascimento.Text = listaPessoas[0].DataDeNascimento.ToString();
                labelNomeDaRua.Text = listaPessoas[0].NomeDaRua;
                labelNumeroDaCasa.Text = listaPessoas[0].NumeroDaCasa.ToString();
                MessageBox.Show("Usuário removido com sucesso", "Usuário removido");
            }
            else
            {
                MessageBox.Show("Usuário não localizado", "Exceção");
            }
        }
    }
}