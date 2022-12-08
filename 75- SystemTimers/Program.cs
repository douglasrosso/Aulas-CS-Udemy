using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SystemTimers
{
    internal class Program
    {
        //Função para o evento do timer
        static void TimerTick(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        }

        static void Main(string[] args)
        {
            //Criando o timer
            Timer timer = new Timer(1000);
            timer.AutoReset = true;
            //Cadastrando o evento
            timer.Elapsed += TimerTick;

            //Inicializando o timer
            timer.Start();


            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();

            //Parando o timer
            timer.Stop();
        }
    }
}
