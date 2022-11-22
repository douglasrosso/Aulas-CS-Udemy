using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17__Operadores_matemáticos_avançados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 17- Operadores matemáticos avançados

            // Ptenciação
            double potenciacao = Math.Pow(4, 2); // 16

            // Radiciação
            double raiz = 3;
            double radiciacao = Math.Pow(27, 1 / raiz); // 3

            // Máxima e o mínimo 
            double maximo = Math.Max(4, 8); // 8
            ;

            double minimo = Math.Min(4, 8); // 4


            // Módulo
            double modulo = Math.Abs(-10); // 10


            // Operações trigonométricas
            double angulo = 30 * (2 * Math.PI) / 360;


            // Seno - Sin
            // Cosseno - Cos
            // Tangente - Tan
            double seno = Math.Sin(angulo); // 0.5


            // Arcseno - Asin
            // Arccosseno - Acon
            // ArcTangente - Atan
            double arcseno = Math.Asin(seno); // 0.523598....

            double arcsenoGraus = arcseno * 360 / (2 * Math.PI);  // 30


            // Arredondamento
            double numeroArredondar = 3.33;
            double arredondarParaCima = Math.Ceiling(numeroArredondar); // 4

            double arredondarParaBaixo = Math.Floor(numeroArredondar); // 3


            // Logaritmo 
            double base10 = Math.Log10(100); // 2

            double baseE = Math.Log(Math.E * Math.E * Math.E); // 3

            Console.WriteLine("\n---------------------------------------------------------------------------\n");
            Console.WriteLine("Precione qualquer tecla para sair!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
