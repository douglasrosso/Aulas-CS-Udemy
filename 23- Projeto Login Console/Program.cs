using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23__Projeto_Login_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 23- Projeto Login Console
            while (true)
            {
                Console.WriteLine("Digite o nome do seu usuário: ");
                string usuario = Console.ReadLine();
                Console.WriteLine("Digite a sua senha: ");
                string senha = "";
                while (true)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.Enter)
                        break;
                    else
                    {
                        senha += tecla.KeyChar;
                    }
                }
                if (usuario == "Douglas" && senha == "987654321")
                {
                    Console.WriteLine("Usuário logado com sucesso");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Usuário ou senha inválidos");
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("\n---------------------------------------------------------------------------\n");
            Console.WriteLine("Precione qualquer tecla para sair!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
