using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _36__Manipulação_de_arquivos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando caminhos de arquivo
            // Primeiro método
            string caminho1 = "C:\\Users\\dougl\\OneDrive\\Desktop\\AULAS\\POR CONTA\\Aulas CS Udemy\\Aulas CS Udemy\\36- Manipulação de arquivos 1\\bin\\Debug\\teste.txt";
            // Segunda maneira
            string caminho2 = @"C:\Users\dougl\OneDrive\Desktop\AULAS\POR CONTA\Aulas CS Udemy\Aulas CS Udemy\36- Manipulação de arquivos 1\bin\Debug\teste.txt";

            // Criando um arquivo
            FileStream meuArquivo = File.Create(caminho1);
            meuArquivo.Close();

            // Verificando se um arquivo existe
            bool arquivoExiste = File.Exists(caminho1); // File.Exists vai retornar um booleano
            if (arquivoExiste) // Retorna, pois o diretório ou arquivo não existe
            {
                Console.WriteLine("O arquivo existe");
            }
            else
            {
                Console.WriteLine("O arquivo não existe");
            }

            arquivoExiste = File.Exists(@"\minha pasta\teste.txt"); // File.Exists vai retornar um booleano
            if (arquivoExiste) // Retorna false, pois o diretório ou arquivo não existe
            {
                Console.WriteLine("O arquivo existe");
            }
            else
            {
                Console.WriteLine("O arquivo não existe");
            }

            // Deletando arquivos
            File.Delete(caminho1);

            // Renomeando ou movendo arquivo
            string caminho3 = @"C:\Users\dougl\OneDrive\Desktop\AULAS\POR CONTA\Aulas CS Udemy\Aulas CS Udemy\36- Manipulação de arquivos 1\bin\Debug\teste2.txt";
            FileStream meuArquivo2 = File.Create(caminho3);
            meuArquivo2.Close();
            string caminho4 = @"C:\Users\dougl\OneDrive\Desktop\AULAS\POR CONTA\Aulas CS Udemy\Aulas CS Udemy\36- Manipulação de arquivos 1\bin\Debug\teste3.txt";
            File.Move(caminho3, caminho4);

            File.Delete(caminho4);

            // Escrevendo em um arquivo de texto
            string caminho5 = @"C:\Users\dougl\OneDrive\Desktop\AULAS\POR CONTA\Aulas CS Udemy\Aulas CS Udemy\36- Manipulação de arquivos 1\bin\Debug\nomes.txt";
            FileStream meuArquivo3 = File.Create(caminho5);
            meuArquivo3.Close();

            string conteudo = "Marcos é um cara muito legal \r\nPedro é um cara muito inteligente";
            File.WriteAllText(caminho5, conteudo);

            // Escrevendo um array de strings no nosso arquivo
            string[] conteudoArray = { "Guilherme", "Marcos", "Pedro", "Maria" };
            File.WriteAllLines(caminho5, conteudoArray);

            // Lendo todo o conteúdo de um arquivo
            string conteudoLido = File.ReadAllText(caminho5);
            Console.WriteLine(conteudoLido);

            // Lendo o conteúdo de um arquivo e gravando em um array de strings
            Console.WriteLine("---------------------------------------------------------------------");
            string[] conteudoLidoArray = File.ReadAllLines(caminho5);
            foreach(string nome in conteudoLidoArray)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }
    }
}