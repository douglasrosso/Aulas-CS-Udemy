using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55__Upcasting_e_downcasting
{
    internal class Program
    {
        // Upcasting = Conversão para cima
        // Resumindo: É a conversão de um objeto da classe filha para um objeto da classe mãe

        // Downcasting = Conversão para baixo
        // Resumindo: É a conversão de um objeto da classe mãe para um objeto da classe filha

        static void Main(string[] args)
        {
            // Upcasting
            Funcionario meuFuncionario = new Funcionario("João", 10000);
            Pessoa minhaPessoa = meuFuncionario;
            minhaPessoa.ImprimeNome();

            // Downcasting
            // Não funicona, pois está vindo de um contexto que tem apenas o nome,
            // para um contexto que necessita do nome e salário
            /*Pessoa minhaPessoa2 = new Pessoa("Manoel");
            Funcionario meuFuncionario2 = (Funcionario)minhaPessoa2;
            meuFuncionario2.ImprimeSalario();*/

            // O downcasting abaixo funciona, pois trata-se do retorno de um upcasting
            Funcionario meuFuncionario2 = new Funcionario("Manoel", 15000);
            Pessoa minhaPessoa2 = meuFuncionario2;
            Funcionario meuFuncionario3 = (Funcionario)minhaPessoa2;
            meuFuncionario3.ImprimeSalario();

            Console.ReadKey();

        }
    }
}
