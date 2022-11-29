using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47__Propriedades_de_classes
{
    public class Carro
    {
        // MODIFICADOR_DE_ACESSO TIPO_DO_ATRIBUTO NOME_DO_ATRIBUTO
        // Modificadores
        // public (público) - Todos podem acessar o nosso atributo/variável
        // private (privado) - Somente a nossa classe poderá acessar o atributo

        // Atributos
        private string marca;
        private double velocidade = 0;
        private bool carroLigado = false;

        // Criando atributo
        // Propriedades
        // MODIFICADOR_DE_ACESSO TIPO NOME
        // {
        //  get { return ATRIBUTO; } - É utilizado para retornar o conteúdo do nosso atributo
        //  set { ATRIBUTO = value; } - É utilizado para alterar o conteúdo do nosso atributo
        // }

        public bool CarroLigado // Propriedades deixa public, resto (atributos) é private
        {
            get { return carroLigado; }
            set 
            {
                if (velocidade == 0)
                    carroLigado = value;
                else
                    return; // Retorna a velocidade atual do veiculo
            }
        }

        public double Velocidade
        {
            get { return velocidade; }
            set
            {
                if (carroLigado) // Se o carro estiver ligado (true), ele vai alterar a velocidade
                    velocidade = value;
                else
                    return; 
            }
        }

        // Exemplo de propriedade sem declarar os atributos antes

        public uint NumeroDePortas
        {
            get;
            set;
        }

        public void ConfiguraVelocidade(double VelocidadeFinal)
        {
            velocidade = VelocidadeFinal;
            marca = "Fiat";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.CarroLigado = true;
            meuCarro.Velocidade = 100;
            meuCarro.CarroLigado = false; // Não é possivel desligar, pois a velocidade é diferente de 0
            meuCarro.Velocidade = 0; // Modificado para 0
            meuCarro.CarroLigado = false; // Agora é possivel desligar
            meuCarro.NumeroDePortas = 4;
            // Atributos privados só podem ser acessados dentro da nossa própria classe
            // meuCarro.velocidade = 100;
        }
    }
}
