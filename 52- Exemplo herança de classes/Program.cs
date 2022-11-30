using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52__Exemplo_herança_de_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro(4, 4);
            Aviao meuAviao = new Aviao(3, 2);
            meuCarro.Ligar();
            meuAviao.Ligar();
            meuCarro.Acelerar(100);
            meuAviao.Decolar(200, 1000);

            meuCarro.Brecar();
            meuAviao.Pousar();

            meuCarro.Desligar();
            meuAviao.Desligar();

            Console.ReadKey();

        }
    }
}
