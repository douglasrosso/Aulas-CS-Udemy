using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27__Struct
{
    internal class Program
    {
        struct DadosCadastrais
        {
            public string Nome;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;
            public DateTime DataDeNascimento;
        }

        static void Main(string[] args)
        {
            // Struct armazena varios tipos de variáveis
            DadosCadastrais meuCadastro;
            meuCadastro.Nome = "João";
            meuCadastro.NomeDaRua = "Rua das Flores";
            meuCadastro.NumeroDaCasa = 100;
            meuCadastro.DataDeNascimento = Convert.ToDateTime("21/12/1985");

            Console.WriteLine(meuCadastro.Nome);
            Console.WriteLine(meuCadastro.NomeDaRua);
            Console.WriteLine(meuCadastro.NumeroDaCasa);
            Console.WriteLine($"{meuCadastro.DataDeNascimento.Day}/{meuCadastro.DataDeNascimento.Month}/{meuCadastro.DataDeNascimento.Year}");
            Console.ReadKey();
        }
    }
}
