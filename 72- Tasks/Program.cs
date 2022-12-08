using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tasks
{
    internal class Program
    {
        static int ImprimeMensagem(int valorInicialDoContador)
        {
            for(int i = valorInicialDoContador; i < 10; i++)
            {
                Console.WriteLine("Eu sou uma task: " + i);
                Thread.Sleep(500);
            }
            return 10;
        }
        static void Main(string[] args)
        {
            int resultadoTask = 0;
            Task taskImprimeMensagem = Task.Run(() => resultadoTask = ImprimeMensagem(5));
            Task taskImprimeMensagem2 = Task.Run(() => resultadoTask = ImprimeMensagem(7));


            Console.WriteLine("Resultado antes da finalização da nossa task");
            Console.WriteLine("O valor da variável resultadoTask é: " + resultadoTask);

            if(taskImprimeMensagem.Wait(10000) == false)
            {
                Console.WriteLine("#########A task não foi finalizada ainda#########");
            }
            else
            {
                Console.WriteLine("Resultado após a finalização da nossa task");
                Console.WriteLine("O valor da variável resultadoTask é: " + resultadoTask);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Eu sou a thread main: " + i);
                Thread.Sleep(500);
            }

            Console.ReadKey();
        }
    }
}
