using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49__Interfaces
{
    internal class Aviao : IVeiculo
    {
        public void Ligar()
        {
            Console.WriteLine("O avião está ligado!");
        }
        public void Desligar()
        {
            Console.WriteLine("O avião está desligado!");

        }
        public void AbrirPorta()
        {
            Console.WriteLine("A porta avião está aberta!");
        }
        public void FecharPorta()
        {
            Console.WriteLine("A porta avião está fechada!");
        }
        public void Decolar()
        {
            Console.WriteLine("O avião decolou!");
        }
    }
}
