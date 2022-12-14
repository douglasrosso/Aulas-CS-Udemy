using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125__Aplicação_servidor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuServidorWebService meuServidorLocal = new MeuServidorWebService("http://localhost:8080/MeuServidorLocal");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
