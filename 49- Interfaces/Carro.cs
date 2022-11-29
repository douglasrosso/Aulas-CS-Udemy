using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49__Interfaces
{
    internal class Carro : IVeiculo
    {
       public void Ligar()
        {
            Console.WriteLine("O carro está ligado!");
        }
        public void Desligar()
        {
            Console.WriteLine("O carro está desligado!");
        }
        public void AbrirPorta()
        {
            Console.WriteLine("A porta do carro está aberta!");
        }
        public void FecharPorta()
        {
            Console.WriteLine("A porta do carro está fechada!");
        }
        public void Acelerar()
        {
            Console.WriteLine("O carro acelerou!");
        }
    }
}
