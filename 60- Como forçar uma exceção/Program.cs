using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60__Como_forçar_uma_exceção
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um número positivo");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0)
                    throw new Exception($"O número {numero} é negativo");
                else
                    Console.WriteLine("O número digitador é positivo!");
            }
            catch (Exception e) 
            { 
                Console.WriteLine($"EXCEÇÃO: {e.Message}");
            }
            finally 
            {
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
