using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _37__Manipulação_de_arquivos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = "C:\\Users\\dougl\\OneDrive\\Desktop\\AULAS\\POR CONTA\\Aulas CS Udemy\\Aulas CS Udemy\\37- Manipulação de arquivos 2\\bin\\Debug\\teste.txt";
            string caminhoArquivo2 = "C:\\Users\\dougl\\OneDrive\\Desktop\\AULAS\\POR CONTA\\Aulas CS Udemy\\Aulas CS Udemy\\37- Manipulação de arquivos 2\\bin\\Debug\\teste2.txt";
            string texto1 = "João subiu no telhado. \r\n";
            string texto2 = "Luana, sua mãe, brigou com ele. \r\n";

            // Maneira não correta
            string conteudoInicial = File.ReadAllText(caminhoArquivo);
            string conteudoFinal = conteudoInicial + texto1 + texto2;
            File.WriteAllText(caminhoArquivo, conteudoFinal);

            // Maneira mais correta
            //File.AppendAllText(caminhoArquivo, texto1); 3 Opções para realizar a mesma função da forma correta
            //File.AppendAllText(caminhoArquivo, texto1);
            File.AppendAllText(caminhoArquivo2, texto1 + texto2);

        }
    }
}
