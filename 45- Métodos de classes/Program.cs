using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _45__Métodos_de_classes
{
    public class ContaBancaria
    {
        // Atributos
        private double saldo;
        private string senha;
        private string nomeDoCliente;

        // Métodos
        // MODIFICADOR_DE_ACESSO TIPO_DE_SAÍDA NOME_DO_MÉTODO (TIPO_PAR1 NOME_PAR1, TIPO_PAR2 NOME_PAR2, ...)
        // {
        // CONTEÚDO_DO_MÉTODO
        // return VALOR_DE_SÁIDA;
        // }

        // MODIFICADOR_DE_ACESSO
        // public (público) - Todos podem acessar o nosso método
        // private (privado) - Somente a nossa própria classe pode pode acessar o nosso método

        // TIPOS_DE_SAÍDA
        // EXEMPLO: int, string, bool, class, List...

        // PARÂMETROS_DE_SAÍDA
        // TIPO_PAR: int, string, class, List...
        // NOME_PAR:

        public double Sacar(double pValorSacado, string pSenha)
        {

            if (senha == pSenha)
            {
                if (saldo > pValorSacado)
                {
                    saldo -= pValorSacado;
                    Console.WriteLine($"O valor sacado foi de: {pValorSacado}");
                    return pValorSacado;
                }
                else
                {
                    Console.WriteLine("O saldo é insuficiente");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("A senha está incorreta");
                return 0;
            }
        }

        public void Depositar(double pValorDepositado)
        {
            saldo += pValorDepositado;
            Console.WriteLine($"O valor depositado foi de: {pValorDepositado}");
        }

        // Pode ter mais de 1 método com o mesmo nome, porém precisar ter parâmetros diferentes
        public void Depositar(double pValorDepositado, string pNomeDoCliente)
        {
            if (pNomeDoCliente== nomeDoCliente)
            {
                saldo += pValorDepositado;
                Console.WriteLine($"O valor depositado foi de: {pValorDepositado}");
            }
            else
            {
                Console.WriteLine("Depósito feito para a conta errada");

            }

        }

        public void ConsultaSaldo(string pSenha)
        {
            if (senha == pSenha)
                Console.WriteLine($"O saldo da conta é: {saldo}");
            else
                Console.WriteLine("A senha está incorreta");
        }

        // Esse é o método construtor
        // Primeiro método a ser executado quando (instânciamos a classe) / (criamos um objeto)
        // Construtor não possui parâmetros de saída
        // O construtor sempre é publico
        // Normalmente o construtor é usado para fazer as configurações iniciais do nosso objeto

        public ContaBancaria(string pSenha, string pNomeDoCliente) // Construtor 1
        {
            saldo = 0;
            senha= pSenha;
            nomeDoCliente = pNomeDoCliente;
        }

        // Pode ter mais de 1 método com o mesmo nome, porém precisar ter parâmetros diferentes

        public ContaBancaria(double pSaldo, string pSenha, string pNomeDoCliente) // Construtor 2
        {
            saldo = pSaldo;
            senha = pSenha;
            nomeDoCliente = pNomeDoCliente;
        }
    }
    internal class Program
    {
        

        static void Main(string[] args)
        {
            ContaBancaria contaDoPedro = new ContaBancaria("12345", "Pedro Santos"); // Construtor 1

            double valorSacado = contaDoPedro.Sacar(10, "12345"); 
            // Para acessar um método e entender como funciona, basta inserir um breakpoint
            // Logo após clicar f11 quando estiver instanciando um método, ele redirecionará para dentro do método
            contaDoPedro.Depositar(1000);
            contaDoPedro.ConsultaSaldo("12345");
            valorSacado = contaDoPedro.Sacar(10, "12345");
            // Usar método evita repetições de código e permite utilizar quantas vezes for necessário
            // Quando precisar alterar o método ele já altera para todo o resto do código

            ContaBancaria contaDoJoao = new ContaBancaria(1000, "12345", "João da Silva"); // Construtor 2

        }
    }
}
