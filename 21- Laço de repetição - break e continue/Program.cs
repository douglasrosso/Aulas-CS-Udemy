using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21__Laço_de_repetição___break_e_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 21- Laço de repetição - break e continue

            while (true)
            {
                Console.WriteLine("Pressione C para continue");
                Console.WriteLine("Pressione B para break");
                string tecla = Console.ReadKey(true).KeyChar.ToString();
                if (tecla == "c")
                {
                    continue;
                }
                else if (tecla == "b")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tecla desconhecida");
                }

            }
            Console.WriteLine("\n---------------------------------------------------------------------------\n");
            Console.WriteLine("Precione qualquer tecla para sair!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
