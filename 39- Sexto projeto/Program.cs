using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _39__Sexto_projeto
{
    internal class Program
    {
        static string delimitadorInicio;
        static string delimitadorFim;
        static string tagNome;
        static string tagDataNascimento;
        static string tagNomeDaRua;
        static string tagNumeroDaCasa;

        public struct DadosCadastraisStruct
        {
            public string Nome;
            public DateTime DataDeNascimento;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;

        }

        public enum Resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excecao = 2
        }

        public static void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public static Resultado_e PegaString(ref string minhaString, string mensagem)
        {
            Resultado_e retorno;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if (temp == "s" || temp == "S")
            {
                retorno = Resultado_e.Sair;
            }
            else
            {
                minhaString = temp;
                retorno = Resultado_e.Sucesso;
            }
            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaData(ref DateTime data, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        retorno = Resultado_e.Sair;
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"EXCEÇÃO: {e.Message}");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;
                }
            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaUInt32(ref UInt32 numeroUInt32, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        retorno = Resultado_e.Sair;
                    else
                    {
                        numeroUInt32 = Convert.ToUInt32(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"EXCEÇÃO: {e.Message}");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;
                }
            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        public static void CadastraUsuario(ref List<DadosCadastraisStruct> listaDeUsuarios)
        {
            DadosCadastraisStruct cadastroUsuario;
            cadastroUsuario.Nome = "";
            cadastroUsuario.DataDeNascimento = new DateTime();
            cadastroUsuario.NomeDaRua = "";
            cadastroUsuario.NumeroDaCasa = 0;
            if (PegaString(ref cadastroUsuario.Nome, "Digite o nome completo ou digite S para sair") != Resultado_e.Sucesso)
                return;
            if (PegaData(ref cadastroUsuario.DataDeNascimento, "Digite a data de nascimento no formato DD/MM/AAAA ou digite S para sair") != Resultado_e.Sucesso)
                return;
            if (PegaString(ref cadastroUsuario.NomeDaRua, "Digite o nome da rua ou digite S para sair") != Resultado_e.Sucesso)
                return;
            if (PegaUInt32(ref cadastroUsuario.NumeroDaCasa, "Digite o numero da casa ou digite S para sair") != Resultado_e.Sucesso)
                return;
            listaDeUsuarios.Add(cadastroUsuario);

        }

        public static void GravaDados(string caminho, List <DadosCadastraisStruct> listaDeUsuarios)
        {
            try
            {
                string conteudoArquivo = "";
                foreach (DadosCadastraisStruct cadastro in listaDeUsuarios)
                {
                    conteudoArquivo += delimitadorInicio + "\r\n";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"EXCECAO: {e.Message}");
            }
        }

        static void Main(string[] args)
        {
            List<DadosCadastraisStruct> ListaDeUsuarios = new List<DadosCadastraisStruct>();
            string opcao = "";
            delimitadorInicio = "##### INICIO #####";
            delimitadorFim = "##### FIM #####";
            tagNome = "NOME: ";
            tagDataNascimento = "DATA_DE_NASCIMENTO: ";
            tagNomeDaRua = "NOME_DA_RUA: ";
            tagNumeroDaCasa = "NUMERO_DA_CASA: ";
            do
            {
                Console.WriteLine("Digite C para cadastrar um nome usuário ou S para sair:");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    // Cadastrar um novo usuário
                    CadastraUsuario(ref ListaDeUsuarios);
                }
                else if (opcao == "s")
                {
                    // Sair da aplicação
                    MostraMensagem("Encerrando o programa");
                }
                else
                {
                    // Opção desconhecida
                    MostraMensagem("Opção desconhecida");
                }
            } while (opcao != "s");
        }
    }
}
