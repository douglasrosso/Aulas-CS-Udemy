using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52__Exemplo_herança_de_classes
{
    internal class Carro : Veiculo
    {
        public void Acelerar(uint pVelocidade)
        {
            if (EstaLigado == true)
            {
                Console.WriteLine("Carro Acelerando...");
                Velocidade = pVelocidade;
                Console.WriteLine($"Velocidade do carro: {Velocidade}");
            }
            else
                Console.WriteLine("Carro desligado!");
        }
        public void Brecar()
        {
            Console.WriteLine("Carro brecando...");
            Velocidade = 0;
            Console.WriteLine($"Velocidade do carro: {Velocidade}");
        }

        public Carro(uint pNumeroRodas, uint pNumeroPortas) : base(pNumeroRodas, pNumeroPortas)
        {

        }
    }
}
