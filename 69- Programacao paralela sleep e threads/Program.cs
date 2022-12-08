using System;
using System.Threading;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_paralela_sleep_e_threads
{
    internal class Program
    {
        static Thread t1;
        static Thread t2;
        static bool podeFinalizar;
        static UInt16 numeroDaThread;
        static object objLock;
        static Mutex meuMutex;

        static void MinhaThread1()
        {
            try
            {
                while (podeFinalizar == false)
                {
                    /* lock (objLock)
                    {
                        numeroDaThread = 1;
                        Thread.Sleep(1000);
                        Console.WriteLine("THREAD1 - Passou 1 segundo - Numero da thread " + numeroDaThread);
                    }*/

                    meuMutex.WaitOne();
                    numeroDaThread = 1;
                    Thread.Sleep(1000);
                    Console.WriteLine("THREAD1 - Passou 1 segundo - Numero da thread " + numeroDaThread);
                    meuMutex.ReleaseMutex(); 
                }
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine("THREAD1 EXCEÇÃO: " + e.Message);
            }
            finally 
            {
                Console.WriteLine("THREAD1 - Finalizando");
            }
        }
        static void MinhaThread2()
        {
            try 
            { 
                while (podeFinalizar == false)
                {
                    /*lock (objLock)
                    {
                        numeroDaThread = 2;
                        Thread.Sleep(1000);
                        Console.WriteLine("THREAD2 - Passou 1 segundo - Numero da thread " + numeroDaThread);
                    }*/

                    meuMutex.WaitOne();
                    numeroDaThread = 2;
                    Thread.Sleep(1000);
                    Console.WriteLine("THREAD2 - Passou 1 segundo - Numero da thread " + numeroDaThread);
                    meuMutex.ReleaseMutex();
                }
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine("THREAD2 EXCEÇÃO: " + e.Message);
            }
            finally 
            {
                Console.WriteLine("THREAD2 - Finalizando");
            }

        }

        static void Main(string[] args)
        {
            //O Sleep é usado para fazer a execução ser pausada por um determinado tempo
            /*for(int i = 0; i<5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Passou 1 segundo.");
            }
            Console.ReadKey();*/

            objLock = new object();
            meuMutex = new Mutex();

            podeFinalizar = false;

            t1 = new Thread(new ThreadStart(MinhaThread1));
            t1.Priority = ThreadPriority.BelowNormal;

            t2 = new Thread(new ThreadStart(MinhaThread2));
            t1.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.ReadKey();

            //podeFinalizar = true;
            t1.Abort();
            t2.Abort();

            Console.WriteLine("Pressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
