using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__Primeiro_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9- Primeiro projeto

            Console.WriteLine("Digite o seu nome:");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade:");
            UInt16 Idade = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Digite o número do seu documento:");
            string Documento = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua rua:");
            string NomeDaRua = Console.ReadLine();

            Console.WriteLine("Digite o número da casa:'");
            UInt32 NumeroDaCasa = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Informe o seu gênero. Pressione F para feminino e M para masculino");
            string Genero = Console.ReadKey(true).KeyChar.ToString();

            Console.WriteLine("Olá " + Nome);
            Console.WriteLine("Você tem " + Idade + " anos de idade.");
            Console.WriteLine("O número do documento informado é: " + Documento);
            Console.WriteLine("O nome da sua rua é " + NomeDaRua);
            Console.WriteLine("O número da sua casa é: " + NumeroDaCasa);
            Console.WriteLine("O seu gênero é: " + Genero);

            Console.WriteLine("Pressione qualquer tecla para encerrar");
            Console.ReadKey();
        }
    }
}
