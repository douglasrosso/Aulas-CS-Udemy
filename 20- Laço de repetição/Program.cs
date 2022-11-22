using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20__Laço_de_repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 20- Laço de repetição

            string[] nomes = { "Guilherme", "Pedro", "Douglas", "Ana", "Maria", "Paula" };
            foreach (string nome in nomes /* "Para cada string nome dentro do array nomes" */)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("\n---------------------------------------------------------------------------\n");

            // Laço do...while
            int k = 0;
            do
            {
                Console.WriteLine("Boa tarde");
                k += 100;
            } while (k > 1000);
            Console.WriteLine("\n---------------------------------------------------------------------------\n");
            Console.WriteLine("Precione qualquer tecla para sair!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
