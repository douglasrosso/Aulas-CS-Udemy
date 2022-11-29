using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Interface é um protótipo de uma classe (esqueleto/contrato)
// Ela define os métodos que serão implementados pela classe

namespace _49__Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro /* Objeto a classe Carro */ = new Carro()/* Classe */;
            meuCarro.AbrirPorta();
            meuCarro.FecharPorta();
            meuCarro.Ligar();
            meuCarro.Desligar();
            meuCarro.Acelerar();

            Aviao meuAviao = new Aviao();
            meuAviao.AbrirPorta();
            meuAviao.FecharPorta();
            meuAviao.Ligar();
            meuAviao.Desligar();
            meuAviao.Decolar();

            IVeiculo meuIVeiculoCarro = new Carro() ; // Por possuir os mesmos métodos, podem ser escritas assim
            meuIVeiculoCarro.AbrirPorta();
            meuIVeiculoCarro.FecharPorta();
            meuIVeiculoCarro.Ligar();
            meuIVeiculoCarro.Desligar();
            // Não pode utilizar o método Acelerar pois nao está na interface


            IVeiculo meuIVeiculoAviao = new Aviao();
            meuIVeiculoAviao.AbrirPorta();
            meuIVeiculoAviao.FecharPorta();
            meuIVeiculoAviao.Ligar();
            meuIVeiculoAviao.Desligar();
            // Não pode utilizar o método Decolar pois nao está na interface

        }
    }
}
