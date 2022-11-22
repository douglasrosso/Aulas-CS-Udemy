using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24__Manipulação_de_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 24- Manipulação de strings

            // Indexação
            string nome241 = "Guilherme";
            char letra241 = nome241[4]; // h
            Console.WriteLine(letra241);

            Console.WriteLine("\n---------------------------------------------------------------------------\n");

            // Concatenar string
            string sobrenome241 = "Silva";
            // string nomeCompleto24 = nome24 + sobrenome24;
            // Console.WriteLine($"{nome24} {sobrenome24}");
            // Console.WriteLine(nome24  +  sobrenome24");
            string nomeCompleto241 = String.Concat(nome241, sobrenome241); // Guilherme Silva
            Console.WriteLine(nomeCompleto241);

            Console.WriteLine("\n---------------------------------------------------------------------------\n");

            // Substituição de strings
            string endereco241 = "Rua das Rosas Verdes";
            endereco241 = endereco241.Replace("Verdes", "Vermelhas"); // Rua das Rosas Vermelhas
            Console.WriteLine(endereco241);

            Console.WriteLine("\n---------------------------------------------------------------------------\n");

            // Remoção de strings
            string endereco242 = "Rua das Rosas Verdes";
            endereco242 = endereco242.Replace(" Verdes", ""); // Rua das Rosas
            Console.WriteLine(endereco242);
            // Ou
            string endereco243 = "Rua das Rosas Verdes";
            endereco243 = endereco243.Remove(0, 4); // das Rosas Verdes
            Console.WriteLine(endereco243);

            Console.WriteLine("\n---------------------------------------------------------------------------\n");

            // Capitalização de strings
            string nome242 = "João da Silva";
            nome242 = nome242.ToUpper(); // JOÃO DA SILVA
            Console.WriteLine(nome242);
            // Ou
            nome242 = nome242.ToLower();
            Console.WriteLine(nome242); // joão da silva

            Console.WriteLine("\n---------------------------------------------------------------------------\n");

            // Contém
            string nome243 = "João da Silva";
            bool contem = nome243.Contains("João"); // True
            Console.WriteLine(contem);
            // Ou
            contem = nome243.Contains("Marcos"); // False
            Console.WriteLine(contem);

            Console.WriteLine("\n---------------------------------------------------------------------------\n");

            // Localização de textos
            string nome244 = "João da Silva";
            int indice = nome244.IndexOf("da");
            Console.WriteLine(indice);

            Console.WriteLine("\n---------------------------------------------------------------------------\n");

            // Divisão de strings
            string nome245 = "João da Silva";
            string[] divisoes = { " da" };
            string[] resultadoDaDivisao = nome245.Split(divisoes, StringSplitOptions.None); // João Silva
            foreach (string texto in resultadoDaDivisao)
            {
                Console.WriteLine(texto);
            }

            Console.WriteLine("\n---------------------------------------------------------------------------\n");

            // Número de caractéres
            string nome246 = "João da Silva";
            int numeroCaracteres = nome246.Length;
            Console.WriteLine(numeroCaracteres); // 13, conta com os espaços

            Console.WriteLine("\n---------------------------------------------------------------------------\n");

            // Substring
            string nome247 = "João da Silva";
            string ultimoNome = nome247.Substring(8, 5);
            Console.WriteLine(ultimoNome); // Silva

            Console.WriteLine("\n---------------------------------------------------------------------------\n");

            // Formatação composta
            string nome248 = "João {0} {1}";
            Console.WriteLine(nome248, "da Silva", "Sauro"); // João da Silva Sauro
                                                             // Ou
            string nomeCompleto248 = String.Format(nome248, "da Silva", "Sauro"); // João da Silva Sauro
            Console.WriteLine(nomeCompleto248);


            Console.WriteLine("\n---------------------------------------------------------------------------\n");
            Console.WriteLine("Precione qualquer tecla para sair!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
