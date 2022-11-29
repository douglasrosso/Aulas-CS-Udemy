using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46__Modificador_STATIC_e_palavra_THIS
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

        public void ImprimeNome()
        {
            Console.WriteLine($"O nome é: {nome}");
        }

        public Pessoa(string pNome)
        {
            nome= pNome;
        }
    }

    // A classe calcula possui o modificador static

    public class Calculadora
    {
        public static double PI = 3.1415;
        public static double CalculaAreaCircunferencia (double pRaio)
        {
            return PI * Math.Pow(pRaio, 2);
        }
    }


    // Palavra this (este) - é utilizado para se referir aquilo que pertence a nossa classe
    public class MinhaPessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void ImprimeNome()
        {
            Console.WriteLine($"O nome é: {nome}");
        }

        public Pessoa(string nome/* Parâmetro do método */)
        {
            this.nome/* Atributo da classe */ = nome; // Parâmetro do método
        }
    }

    internal class Program
    {
        static void Main(string[] args) // Static seria uma variável global
        {
            Pessoa pessoa1 = new Pessoa("João");
            Pessoa pessoa2 = new Pessoa("Pedro");
            pessoa1.ImprimeNome();
            pessoa1.Nome = "Maria";

            Console.WriteLine($"O valor de PI é: {Calculadora/* Esse é um método */.PI/* O PI é atributo e pertence a classe */}");
            Console.WriteLine($"A área é: {Calculadora.CalculaAreaCircunferencia(2)}");
            
            // Não podemos acessar  oque é static através do nome do objeto, pois ele pertence a classe
            Calculadora calc = new Calculadora();

            Console.ReadKey();
        }
    }
}
