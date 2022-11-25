using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42__Introdução_orientação_a_objeto
{
    internal class Program
    {
        public class Carro
        {
            // Atributos ou variáveis
            private string marca; // Só pode ser acessado dentro da classe quando é private
            private string modelo; // Só pode ser acessado dentro da classe quando é private
            private UInt32 velocidade; // Só pode ser acessado dentro da classe quando é private
            private bool carroLigado; // Só pode ser acessado dentro da classe quando é private

            // Propriedades
            public string Marca
            {
                get { return marca; } 
                set { marca= value; }
            }

            public string Modelo
            {
                get { return modelo; }
                set { modelo = value; }
            }

            public UInt32 Velocidade
            {
                get { return velocidade; }
                set { velocidade = value; }
            }

            public bool CarroLigado
            {
                get { return carroLigado; }
                set { carroLigado = value; }
            }

            // Método

            public void LigarCarro()
            {
                carroLigado = true;
                Console.WriteLine($"Ligando o carro da marca {marca} e do modelo {modelo}");
            }

            public void DesligarCarro()
            {
                carroLigado = false;
                Console.WriteLine($"Desligando o carro da marca {marca} e do modelo {modelo}");
            }

            public void AcelerarCarro(UInt32 velocidadeFinal)
            {
                if(carroLigado == true)
                {
                    velocidade = velocidadeFinal;
                    Console.WriteLine($"A velocidade do carro da marca {marca} e do modelo {modelo} é {velocidade}");
                }
                else
                {
                    Console.WriteLine($"O carro da marca {marca} e do modelo {modelo} está desligado");
                }
            }

            public void PararCarro()
            {
                if(velocidade == 0)
                {
                    Console.WriteLine($"O carro da marca {marca} e do modelo {modelo} já está parado");
                }
                else
                {
                    velocidade = 0;
                    Console.WriteLine($"O carro da marca {marca} e do modelo {modelo} está parado");
                }
            }

        }
        static void Main(string[] args)
        {
            Carro hondaFit = new Carro();
            hondaFit.Marca = "Honda";
            hondaFit.Modelo = "FIT";
            hondaFit.LigarCarro();
            hondaFit.AcelerarCarro(80);
            hondaFit.PararCarro();
            hondaFit.DesligarCarro();

            Carro fiatUno = new Carro();
            fiatUno.Marca = "Fiat";
            fiatUno.Modelo = "Uno";
            fiatUno.AcelerarCarro(80);
            fiatUno.LigarCarro();
            fiatUno.AcelerarCarro(80);
            fiatUno.PararCarro();
            fiatUno.DesligarCarro();

            Console.ReadKey();
        }
    }
}
