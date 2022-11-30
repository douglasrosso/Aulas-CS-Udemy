using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54__Herança_polimorfismo
{
    internal class Bicicleta : Veiculo
    {
        override public void Andar()
        {
            Console.WriteLine("A bicicleta está andando");
        }
    }
}

