using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16__Operadores_matematicos_basicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soma +
            double numero1 = 15.5;
            double numero2 = 10;
            double resultadoSoma = numero1 + numero2;
            Console.WriteLine("O resultado da soma de " + numero1 + " mais " + numero2 + " é: " + resultadoSoma);


            //Subtração -
            double resultadoSubtracao = numero1 - numero2;
            Console.WriteLine("O resultado da subtração de " + numero1 + " menos " + numero2 + " é: " + resultadoSubtracao);


            //Multiplicação *
            double resultadoMultiplicaco = numero1 * numero2;
            Console.WriteLine("O resultado da multiplicação de " + numero1 + " vezes " + numero2 + " é: " + resultadoMultiplicaco);


            //Divisão /
            double resultadoDivisao = numero1 / numero2;
            Console.WriteLine("O resultado da divisão de " + numero1 + " por " + numero2 + " é: " + resultadoDivisao);


            //Resto %
            int numero3 = 5;
            int numero4 = 3;
            int resultadoResto = numero3 % numero4;
            Console.WriteLine("O resto da divisão de " + numero3 + " por " + numero4 + " é: " + resultadoResto);


            //Somar ou subtrair um valor ao conteúdo de uma variável
            double numero5 = 10;
            numero5 += 10;//numero5 = numero5 + 10;
            Console.WriteLine("O resultado da soma de " + 10 + " mais " + 10 + " é: " + numero5);

            numero5 = 10;
            numero5 -= 10;//numero5 = numero5 - 10;
            Console.WriteLine("O resultado da subtração de " + 10 + " menos " + 10 + " é: " + numero5);

            //Dividir e multiplicar o valor do conteúdo de uma variável por outro valor
            numero5 = 10;
            numero5 *= 10;//numero5 = numero5 * 10;
            Console.WriteLine("O resultado da multiplicação de " + 10 + " vezes " + 10 + " é: " + numero5);

            numero5 = 10;
            numero5 /= 10;//numero5 = numero5 / 10;
            Console.WriteLine("O resultado da divisão de " + 10 + " por " + 10 + " é: " + numero5);



            //Incremento ++
            double numero6 = 10;
            //numero6 = numero6 + 1;
            //numero6 += 1;
            numero6++;
            Console.WriteLine("O resultado da operação incremento de " + 10 + " é: " + numero6);

            //Decremento --
            double numero7 = 10;
            //numero7 = numero7 - 1;
            //numero7 -= 1;
            numero7--;
            Console.WriteLine("O resultado da operação decremento de " + 10 + " é: " + numero7);
            Console.ReadKey();
        }
    }
}
