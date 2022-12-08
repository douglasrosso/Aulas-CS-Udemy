using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Programacao_paralela_threads_2
{
    internal class ParametroDaThread
    {
        public int InicioContador
        {
            get;
            set;
        }
        public string Nome
        {
            get;
            set;
        }
        public ParametroDaThread(int pInicioContador, string pNome)
        {
            InicioContador = pInicioContador;
            Nome = pNome;
        }
    }
    internal class Program
    {
        public static void MinhaThreadSemParametro()
        {
            int contador = 10;
            do
            {
                Console.WriteLine(contador++);
                Thread.Sleep(250);
            } while (contador < 20);
        }

        public static void MinhaThreadComParametro(object inicioContador)
        {
            int contador = (int)inicioContador;
            do
            {
                Console.WriteLine(contador++);
                Thread.Sleep(250);
            } while (contador < 20);
        }

        public static void MinhaThreadComParametro2(object pParametroDaThread)
        {
            ParametroDaThread parametroDaThread = (ParametroDaThread)pParametroDaThread;
            int contador = parametroDaThread.InicioContador;
            Console.WriteLine(parametroDaThread.Nome);
            do
            {
                Console.WriteLine(contador++);
                Thread.Sleep(250);
            } while (contador < 20);
        }

        public static void MinhaThreadComParametro3(int inicioContador, string nome)
        {
            int contador = inicioContador;
            Console.WriteLine(nome);
            do
            {
                Console.WriteLine(contador++);
                Thread.Sleep(250);
            } while (contador < 20);
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MinhaThreadSemParametro));
            t1.Start();
            Console.ReadKey();
            Console.Clear();

            Thread t2 = new Thread(new ParameterizedThreadStart(MinhaThreadComParametro));
            t2.Start(11);
            Console.ReadKey();
            Console.Clear();

            Thread t3 = new Thread(new ParameterizedThreadStart(MinhaThreadComParametro2));
            ParametroDaThread parametroDaThread = new ParametroDaThread(12, "Maria");
            t3.Start(parametroDaThread);
            Console.ReadKey();
            Console.Clear();

            Thread t4 = new Thread(()=> MinhaThreadComParametro3(13, "Valeria"));
            t4.Start();
            Console.ReadKey();
            Console.Clear();

            int inicioContador = 14;
            string nome = "Pedro";
            Thread t5 = new Thread(() =>
            {
                int contador = inicioContador;
                Console.WriteLine(nome);
                do
                {
                    Console.WriteLine(contador++);
                    Thread.Sleep(250);
                } while (contador < 20);
            });
            t5.Start();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
