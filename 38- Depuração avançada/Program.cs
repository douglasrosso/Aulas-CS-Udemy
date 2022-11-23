using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _38__Depuração_avançada
{
    internal class Program
    {
        public static double PegaDouble(string mensagem)
        {
            Console.WriteLine(mensagem);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static void Divide()
        {
            double numerador = PegaDouble("Digite o numerador");
            double denominador = PegaDouble("Digite o denominador");
            double resultadoDivisao = numerador/denominador;
            Console.WriteLine($"O resultado da divisão de {numerador} por {denominador} é {resultadoDivisao}");
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Divide();
            // Adicione um breakpoint
            // Após isso clique f11 para entrar dentro de um método
            // f10 para ir para o próximo passo de execusão
            // Na janela Call Stack, consegue acompanhar a execução do código
            // Basta arrastar a seta amarela para pular alguma execução
        }
    }
}
