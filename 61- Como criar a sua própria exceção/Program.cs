using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61__Como_criar_a_sua_própria_exceção
{
    internal class Program
    {
        static void VerificaNumero(int numero)
        {
            if(numero < 0)
                throw new NumeroNegativoException(numero);

        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um número positivo");
                int numero = Convert.ToInt32(Console.ReadLine());
                VerificaNumero(numero);
                Console.WriteLine("O número digitado é positivo");
            }
            catch (NumeroNegativoException e)
            {
                Console.WriteLine($"Exceção específica: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exceção genérica: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla para finalizar");
                Console.ReadKey();
            }
        }
    }
}
