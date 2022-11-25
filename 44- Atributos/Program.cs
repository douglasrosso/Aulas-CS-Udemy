using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44__Atributos
{
    public class Carro
    {
        // MODIFICADOR_DE_ACESSO TIPO_DO_ATRIBUTO NOME_DO_ATRIBUTO
        // Modificadores
        // public (público) - Todos podem acessar o nosso atributo/variável
        // private (privado) - Somente a nossa classe poderá acessar o atributo

        // Criando atributo
        public string marca;
        private double velocidade;

        public void ConfiguraVelocidade(double VelocidadeFinal)
        {
            velocidade= VelocidadeFinal;
            marca = "Fiat";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.marca = "'Honda";
            // Atributos privados só podem ser acessados dentro da nossa própria classe
            // meuCarro.velocidade = 100;
        }
    }
}
