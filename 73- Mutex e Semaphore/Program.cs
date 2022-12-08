using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mutex_e_Semaphore
{
    internal class Program
    {
        static Mutex mutexTask;
        static Semaphore sempahoreTask;

        static void MostraMensagem(int numeroTask)
        {
            //mutexTask.WaitOne();
            sempahoreTask.WaitOne();   
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("Número da task " + numeroTask + " . Número contador: " + i);
                Thread.Sleep(500);
            }
            sempahoreTask.Release();
            //mutexTask.ReleaseMutex();
        }

        static void Main(string[] args)
        {
            mutexTask = new Mutex();
            sempahoreTask = new Semaphore(2, 2);

            Task t1 = Task.Run(() => MostraMensagem(1));
            Task t2 = Task.Run(() => MostraMensagem(2));
            Task t3 = Task.Run(() => MostraMensagem(3));
            Task t4 = Task.Run(() => MostraMensagem(4));

            Console.ReadKey();
        }
    }
}
