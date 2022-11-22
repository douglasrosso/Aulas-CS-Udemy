using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33__Métodos
{
    internal class Program
    {

        // tipo_de_acesso modificador_de_instancia tipo_de_retorno nome_do_metodo(parametros_de_entrada)
        public static double Soma(double a, double b /* Parâmetros */)
        {
            // Método
            double resultadoSoma = a + b; // Recebe a soma
            return resultadoSoma;
        }

        public static void ImprimeMensagens()
        {
            Console.WriteLine("Olá. Este é um método vazio!");
            Console.WriteLine("Ele não tem parâmetros de entrada e nem retorna nada");
        }

        // Modificadores de parâmetros de entrada
        /*
         * ref - Sinaliza que o parâmetro de entrada PODE ser modificado pelo método
         * out - Sinaliza que o parâmetro de entrada DEVE ser modificado pelo método
         */

        public static void Multiplica(double a, double b, ref double resultadoDaOperacao)
        {
            double resultadoMultiplicacao = a * b;
            resultadoDaOperacao = resultadoMultiplicacao;
        }

        public static void Multiplica2(double a, double b, out double resultadoDaOperacao)
        {
            double resultadoMultiplicacao = a * b;
            resultadoDaOperacao = resultadoMultiplicacao;
        }

        static void Main(string[] args)
        {
            // Chamando métodos
            double resultado = Soma(10, 20);
            Console.WriteLine($"O resultado da soma de 10 e 20 é: {resultado}");

            double numero1 = 20;
            double numero2 = 20.5;
            resultado = Soma(numero1, numero2);
            Console.WriteLine($"O resultado da soma de {numero1} + {numero2} resulta em: {resultado}");

            ImprimeMensagens(); // Aparece a mensagem do método

            double resultadoMultiplica = 0;
            Multiplica(numero1, numero2, ref resultadoMultiplica);
            Console.WriteLine($"O resultado da multiplicação é: {resultadoMultiplica}"); // 410

            resultadoMultiplica = 0;
            Multiplica2(numero1, numero2, out resultadoMultiplica);
            Console.WriteLine($"O resultado da multiplicação é: {resultadoMultiplica}"); // 410



            Console.ReadKey(); 
        }

    }
}
