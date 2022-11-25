using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45__Métodos_de_classes
{
    internal class Program
    {
        public class CantaBancaria
        {
            // Atributos
            public double saldo;
            private string senha;
            public string nomeDoCliente;

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
                if(senha == pSenha)
                {
                    if(saldo > pValorSacado)
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
        }

        static void Main(string[] args)
        {
             
        }
    }
}
