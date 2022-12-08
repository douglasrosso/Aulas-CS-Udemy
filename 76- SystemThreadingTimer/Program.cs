using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SystemThreadingTimer
{
    internal class Program
    {
        //Método executado pelo timer
        static void TimerTick(object state)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        }

        static void Main(string[] args)
        {
            //Criando o timer
            TimerCallback tcb = new TimerCallback(TimerTick);
            Timer meuTimer = new Timer(tcb, null, 0, 1000);

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();

            //Encerrando o timer
            meuTimer.Dispose();
        }
    }
}
