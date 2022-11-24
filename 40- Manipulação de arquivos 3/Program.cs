using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _40__Manipulação_de_arquivos_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "teste.txt";
            FileStream fs = File.Create(caminho);
            fs.Close();

            StreamWriter sw = new StreamWriter(caminho);
            sw.Write('a');
            sw.Write('-');
            sw.Write("Olá mundo!\r\n");
            sw.Write("b-Olá mundo 2!\r\n");

            sw.WriteLine("c-Olá  mundo 3!");
            sw.WriteLine("d-Olá  mundo 4!");

            sw.Close();

            StreamReader sr1 = new StreamReader(caminho);

            char[] buffer = new char[128];
            sr1.Read(buffer, 4, 5);
            sr1.Read(buffer, 8, 7);
            sr1.Close();

            StreamReader sr2 = new StreamReader(caminho);
            string linha = sr2.ReadLine();
            linha = sr2.ReadLine();
            sr2.Close();

            StreamReader sr3 = new StreamReader(caminho);
            string arquivoInterio = sr3.ReadToEnd();
             sr3.Close();
        }
    }
}