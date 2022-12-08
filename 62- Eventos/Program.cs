using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62__Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cozinha cozinhaHamburguer = new Cozinha();
            Cozinha cozinhaJaponesa = new Cozinha();

            TabletGarcom tableJoao = new TabletGarcom("João", cozinhaHamburguer);
            TabletGarcom tablePedro = new TabletGarcom("Pedro", cozinhaHamburguer);
            TabletGarcom tableMaria = new TabletGarcom("Maria", cozinhaHamburguer);

            TabletGarcom tableJoana = new TabletGarcom("Joana", cozinhaJaponesa);
            TabletGarcom tableAline = new TabletGarcom("Aline", cozinhaJaponesa);
            TabletGarcom tableMarcos = new TabletGarcom("Marcos", cozinhaJaponesa);

            cozinhaHamburguer.EnviaMensagemPedidoPronto(12);

            cozinhaJaponesa.EnviaMensagemPedidoPronto(29);

            Console.ReadKey();
        }
    }
}
