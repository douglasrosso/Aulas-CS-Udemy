using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _28__Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ListaDeNomes = new List<string>();

            // Adiciona elementos
            ListaDeNomes.Add("João");
            ListaDeNomes.Add("Marcos");
            ListaDeNomes.Add("Mariana");
            ListaDeNomes.Add("Aline");

            // Removendo elementos
            ListaDeNomes.Remove("Marcos"); // Removeu Marcos

            // Removendo elementos em posições específicas
            ListaDeNomes.RemoveAt(0); // Removeu João
            ListaDeNomes.RemoveAt(1); // Removeu Aline


            foreach (string nome in ListaDeNomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("---------------------------------------------------------------------------------");

            List<string> ListaDeNomes2 = new List<string>();

            ListaDeNomes2.Add("João");
            ListaDeNomes2.Add("Marcos");
            ListaDeNomes2.Add("Mariana");
            ListaDeNomes2.Add("Aline");

            // Removendo uma faixa de elementos
            ListaDeNomes2.RemoveRange(1, 2); // Remove 2 elementos a partir do índece 1

            foreach (string nome in ListaDeNomes)
            {
                Console.WriteLine(nome);
            }

            // Pegando o número de elementos
            Console.WriteLine($"A lista ListaDeNomes2 possui: {ListaDeNomes2.Count} elementos");

            // Concatenando listas
            List<string> ListaDeNomes3 = new List<string>();
            ListaDeNomes3.Add("João");
            ListaDeNomes3.Add("Marcos");
            ListaDeNomes3.Add("Mariana");
            ListaDeNomes3.Add("Aline");

            List<string> ListaDeNomes4 = new List<string>();
            ListaDeNomes4.Add("Manoel");
            ListaDeNomes4.Add("João");
            ListaDeNomes4.Add("Pedro");
            ListaDeNomes4.Add("Alan");

            List<string> ListaDeNomesConcatenada = ListaDeNomes3.Concat(ListaDeNomes4).ToList();

            foreach (string nome in ListaDeNomesConcatenada)
            {
                Console.WriteLine(nome);
            }

            // Verificando se a lista possui um determinado valor

            bool contemNome = ListaDeNomesConcatenada.Contains("Pedro");
            Console.WriteLine("A ListaDeNomesConcatenada contem o nome Pedro?");
            Console.WriteLine(contemNome);

            contemNome = ListaDeNomesConcatenada.Contains("Manoela");
            Console.WriteLine("A ListaDeNomesConcatenada contem o nome Manoela?");
            Console.WriteLine(contemNome);

            // Descobrindo o índice de um elemento
            int indice = ListaDeNomesConcatenada.IndexOf("Mariana");
            Console.WriteLine($"O índice do nome Mariana é {indice}");

            Console.WriteLine("---------------------------------------------------------------------------------");

            // Operador where

            List<string> listaWhere = ListaDeNomesConcatenada.Where(x => /* => Tal que */ x.StartsWith("M")/* Começa com M */).ToList();

            foreach (string nome in listaWhere)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }
    }
}
