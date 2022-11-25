using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _43__Criando_classes2

//MODIFICADOR_DE_ACESSO class NOME_DA_CLASSE { }
//Modificadores de acesso
//internal (interno) - A nossa classe só poderá ser acessada pelo nosso assembly
//public (público) - O uso da nossa classe é livre
//private (privado) - A nossa classe só poderá ser acessada internamente ao bloco de código que a criou

namespace _43__Criando_classes
{
    internal class Program
    {
        internal class Carro_Internal
        {
            Carro_Public meuCarroPublic = new Carro_Public();
        }
        public class Carro_Public
        {
            Carro_Internal meuCarroInternal = new Carro_Internal();
            //Não temos acesso a classe Carro_Private porque ela é privada (private)
            //Program.Carro_Private meuCarroPrivate = new Program.Carro_Private();
        }

        internal class Program
        {
            //Só podemos criar classes privadas dentro de outras classes!!!!!
            private class Carro_Private
            {

            }
            static void Main(string[] args)
            {
                //NOME_DA_CLASSE NOME_DO_OBJETO = new NOME_DA_CLASSE(PARAMETROS);
                Carro_Internal meuCarroInternal = new Carro_Internal();
                Carro_Public meuCarroPublic = new Carro_Public();
                Carro_Private meuCarroPrivate = new Carro_Private();
                CarroExterno meuCarroExterno = new CarroExterno();
            }
        }
    }
}
