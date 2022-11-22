using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11__Operadores_logicos_entre_variaveis_booleanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;//verdadeiro
            bool var2 = false;//falso

            //Negação - !
            bool resultadoNegacao = !var1;
            Console.WriteLine("A negação de " + var1 + " é " + resultadoNegacao);
            resultadoNegacao = !var2;
            Console.WriteLine("A negação de " + var2 + " é " + resultadoNegacao);

            //Operador E (AND) - &
            bool resultadoE = var1 & var1;
            Console.WriteLine("O resultado da operação E entre " + var1 + " e " + var1 + " resulta em: " + resultadoE);
            resultadoE = var1 & var2;
            Console.WriteLine("O resultado da operação E entre " + var1 + " e " + var2 + " resulta em: " + resultadoE);
            resultadoE = var2 & var2;
            Console.WriteLine("O resultado da operação E entre " + var2 + " e " + var2 + " resulta em: " + resultadoE);

            //Operador OU (OR) - |
            bool resultadoOU = var1 | var1;
            Console.WriteLine("O resultado da operação OU entre " + var1 + " e " + var1 + " resulta em: " + resultadoOU);
            resultadoOU = var1 | var2;
            Console.WriteLine("O resultado da operação OU entre " + var1 + " e " + var2 + " resulta em: " + resultadoOU);
            resultadoOU = var2 | var2;
            Console.WriteLine("O resultado da operação OU entre " + var2 + " e " + var2 + " resulta em: " + resultadoOU);

            //Operador OU EXCLUSIVO (XOR) - ^
            bool resultadoXOR = var1 ^ var1;
            Console.WriteLine("O resultado da operação XOR entre " + var1 + " e " + var1 + " resulta em: " + resultadoXOR);
            resultadoXOR = var1 ^ var2;
            Console.WriteLine("O resultado da operação XOR entre " + var1 + " e " + var2 + " resulta em: " + resultadoXOR);
            resultadoXOR = var2 ^ var2;
            Console.WriteLine("O resultado da operação XOR entre " + var2 + " e " + var2 + " resulta em: " + resultadoXOR);

            Console.ReadKey();
        }
    }
}
