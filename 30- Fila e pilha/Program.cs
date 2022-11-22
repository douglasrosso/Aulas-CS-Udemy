using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30__Fila_e_pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue (Fila) . Semelhante uma lista .Primeiro elemento é o primeiro a sair 

            Queue<string> FilaDeNomes = new Queue<string>();
            // Adicionando elementos
            FilaDeNomes.Enqueue("Guilherme");
            FilaDeNomes.Enqueue("Maria");
            FilaDeNomes.Enqueue("João");
            FilaDeNomes.Enqueue("vagner");

            // Removendo elementos
            string nomeRemovido = FilaDeNomes.Dequeue();
            Console.WriteLine(nomeRemovido);
            nomeRemovido = FilaDeNomes.Dequeue();
            Console.WriteLine(nomeRemovido);

            // Espiando elementos
            Console.WriteLine("-------------------------------------------------------------------------");
            string nomeEspiado = FilaDeNomes.Peek();
            Console.WriteLine(nomeEspiado);

            // Stack (Pilha) .Muito semelhante à fila e à queue .O primeiro elemento é o último a sair
            Console.WriteLine("-------------------------------------------------------------------------");
            Stack<string> PilhaDeNomes = new Stack<string>();

            // Adicionando elementos
            PilhaDeNomes.Push("Mariana");
            PilhaDeNomes.Push("Joaquina");
            PilhaDeNomes.Push("José");
            PilhaDeNomes.Push("Alana");

            // Removendo elementos
            string nomeRemovido2 = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);

            // Espiar elementos
            string nomeEspiado2 = PilhaDeNomes.Peek();
            Console.WriteLine(nomeEspiado2);

            // Possuem os mesmos métodos das listas
            // Count
            // Clear
            // Concat
            // Contains
            // ....

            Console.ReadKey();

        }
    }
}
