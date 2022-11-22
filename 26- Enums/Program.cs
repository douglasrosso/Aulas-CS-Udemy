using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Enums
{
    internal class Program
    {
        enum NotasDeReal_e
        // São tipos que possuem valores numéricos associados a nomes (Cada valor está ligado a um nome)
        // Só permite números inteiros, porém pode ser negativos também
        {
            NotaDe2 = 2,
            NotaDe5 = 5,
            NotaDe10 = 10
        }

        enum NotaDaProva_e
        {
            /* Ao colocar apenas o valor no primeiro, os demais são incrementados com +1,
            Caso não for informado nenhum valor, começa de 0
            Nota0, vale 0
            Nota1, vale 1
            Nota2, vale 2
            Nota3, vale 3
            Nota4  vale 4 */
            Nota_1 = -1,
            Nota0,
            Nota1, // Vale 1
            Nota2, // Vale 2
            Nota3, // Vale 3
            Nota4  // Vale 4
        }

        static void Main(string[] args)
        {
            NotasDeReal_e minhaNota = NotasDeReal_e.NotaDe10;
            Console.WriteLine($"{minhaNota} vale {Convert.ToInt32(minhaNota)}");

            NotaDaProva_e minhaNotaDaProva = NotaDaProva_e.Nota4;
            Console.WriteLine($"{minhaNotaDaProva} vale {Convert.ToInt32(minhaNotaDaProva)}");
        }
    }
}
