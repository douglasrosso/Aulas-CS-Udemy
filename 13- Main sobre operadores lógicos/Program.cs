using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13__Main_sobre_operadores_lógicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13- Main sobre operadores lógicos

            bool var1 = true;
            bool var2 = false;
            bool resultadoOU_1 = var1 | var2;
            bool resultadoOU_2 = var1 || var2; // Os dois operadores funcionam da mesma maneira

            bool resultadoE_1 = var1 & var2;
            bool resultadoE_2 = var1 && var2;

            Console.WriteLine("\n---------------------------------------------------------------------------\n");
            Console.WriteLine("Precione qualquer tecla para sair!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
