using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59__Como_tratar_uma_exceção
{
    internal class Joao
    {
        public void ImprimeNome()
        {
            Console.WriteLine("João");
        }
    }
    internal class Program
    {
        static Joao joao;

        static void Main(string[] args)
        {
            try // Este bloco tem sempre que existir
            {
                Console.WriteLine("Digite o numerador: ");
                int numerador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());

                int resultado = numerador / denominador;

                Console.WriteLine($"O resultado da divisão é: {resultado}");

                joao.ImprimeNome();
            }
            catch (DivideByZeroException e) // Este bloco tem que existir e pode ter vários dele
            {
                Console.WriteLine($"EXCEÇÃO DE DIVISÃO POR ZERO: {e.Message}");
            }
            catch (NullReferenceException e) // Este bloco tem que existir e pode ter vários dele
            {
                Console.WriteLine($"EXCEÇÃO DE OBJETO NULO: {e.Message}");
            }
            catch (Exception e) // Este bloco tem que existir e pode ter vários dele
            {
                Console.WriteLine($"EXCEÇÃO: {e.Message}"); // Bloco de excessão genérica tem que ficar sempre por última
            }
            finally // Este bloco é opcional
            {
                Console.WriteLine("Pressione qualquer tecla para finalizar");
                Console.ReadKey();
            }
            

            
        }
    }
}
