using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53__Herança___classe_abstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Classe abstrata não pode ser instânciada. Logo o código da linha abaixo está incorreto
            // Pessoa minhaPessoa = new Pessoa("João");

            Funcionario meuFuncionario = new Funcionario("João", 10000);
            meuFuncionario.MostraNome();
            meuFuncionario.MostraSalario();
            Console.ReadKey();
        }
    }
}
