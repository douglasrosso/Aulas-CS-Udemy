using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35__Delegates
{
    internal class Program
    {
        public delegate double MeuDelegeteOperacoes(double a, double b);

        public static double Soma (double a, double b)
        {
            double resultadoSoma = a + b;
            Console.WriteLine($"A soma de {a} mais {b} é: {resultadoSoma}");
            return resultadoSoma;
        }

        public static double Multiplicacao(double a, double b)
        {
            double resultadoMultiplicacao = a * b;
            Console.WriteLine($"A multiplicação de {a} e {b} é: {resultadoMultiplicacao}");
            return resultadoMultiplicacao;
        }

        public static double Divisao(double a, double b)
        {
            double resultadoDivisao = a / b;
            Console.WriteLine($"A Divisão de {a} por {b} é: {resultadoDivisao}");
            return resultadoDivisao;
        }

        public static void ExecutaOperacao(MeuDelegeteOperacoes minhasoperacoes) // Precisa ter a mesma assinatura que o Delegate, dois doubles
        {
            Console.WriteLine("Executando o método passado como parâmetro de entrada... ");
            minhasoperacoes(50, 20);
        }

        static void Main(string[] args)
        {
            MeuDelegeteOperacoes minhasOperacoes;
            minhasOperacoes = Soma;
            double resultadoDelegate = minhasOperacoes(10, 20); // Executou e o retorno foi o valor retornado do método Soma
            Console.WriteLine($"O resultado do delegate é: {resultadoDelegate}"); // 30

            minhasOperacoes += Multiplicacao;
            minhasOperacoes += Divisao;
            Console.WriteLine("-------------------------------------------");
            resultadoDelegate = minhasOperacoes(30, 5);
            // Método Soma foi executado e é igual a 35
            // Método Multiplicacao foi executado e é igual a 150
            // Método Divisao foi executado e é igual a 6
            Console.WriteLine($"O resultado do delegate é: {resultadoDelegate}"); // Retornou o valor retornado do último método
            // Delegate quando é referênciado a mais de 1 método, ele so vai retornar o valor retonado pelo último método referênciado
            Console.WriteLine("-------------------------------------------");
            ExecutaOperacao(Multiplicacao);

            Console.ReadKey();

        }
    }
}
