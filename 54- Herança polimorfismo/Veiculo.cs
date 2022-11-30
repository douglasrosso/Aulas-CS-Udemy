using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54__Herança_polimorfismo
{
    internal class Veiculo
    {
        virtual public void Andar()
        {
            Console.WriteLine("O veículo está andando");
        }
    }
}
