using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54__Herança_polimorfismo
{
    internal class Carro : Veiculo
    {
        override public void Andar()
        {
            base.Andar();
            Console.WriteLine("O carro está andando");
        }
    }
}
