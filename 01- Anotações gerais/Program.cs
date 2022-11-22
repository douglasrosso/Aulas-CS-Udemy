using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Anotações_gerais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- Anotações gerais

            string numero = "65";
            int numero1 = Convert.ToInt32(numero); // Converte de string para int
            string numero2 = Convert.ToString(numero); // Converte de int para string

            /* char teclaPressionada = Console.ReadKey(true).KeyChar; 
            // Captura a tecla pressionada e salva, mas não exibe
            // Console.ReadKey(true).KeyChar 
            // Recebe a tecla e não mostra*/


            DateTime dataDeNascimento = new DateTime(1998, 7, 10, 7, 15, 10);
            // Conta nessa sequência, ano (year), mês (month), dia (day), hora (hour), minutos (minutes) e segundos (seconds)

            char teclaPressionada = Console.ReadKey(true).KeyChar; // Captura a tecla pressionada e salva, mas não exibe
            // Console.ReadKey(true).KeyChar 
            // Recebe a tecla e não mostra

            Console.WriteLine("\n---------------------------------------------------------------------------\n");
            Console.WriteLine("Precione qualquer tecla para sair!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
