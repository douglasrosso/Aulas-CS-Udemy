using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48__Mais_sobre_o_modificador_STATIC
{
    // Modificador static (estático ou fixo) - Ele é sempre usado após o modificador de acesso
    // O static transforma o que está sendo modificado por ele em pertencente à classe e não mais ao objeto
    // Pode ser usado
    // Atributo
    // Propriedade
    // Método
    // Struct
    // Classe
    // ...


    // Não tem nada estático na classe Pessoa

    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public static void ImprimeNome(Pessoa pPessoa)
        {
            Console.WriteLine($"O nome é: {pPessoa.nome}");
        }

        public Pessoa(string pNome)
        {
            nome = pNome;
        }
    }

    // A classe calculadora possui o modificador static indiretamente
    // Quando se declara static na classe diretamente, ela obriga todo mundo que pertence a classe, seja static ou terá erro

    public static class Calculadora
    {
        public static double PI = 3.1415;
        public static double CalculaAreaCircunferencia(double pRaio)
        {
            return PI * Math.Pow(pRaio, 2);
        }
    }

    internal class Program
    {
        static void Main(string[] args) // Static seria uma variável global
        {
            Pessoa pessoa1 = new Pessoa("João");

            // Pessoa - Classe
            // ImprimeNome - Método
            // ( .... ) - Parâmetro de entrada
            // pessoa1 - Objeto
            Pessoa/* Classe */.ImprimeNome/* Método */(pessoa1/* Objeto */)/* Parâmetro de entrada */;
            

            Console.ReadKey();
        }
    }
}
