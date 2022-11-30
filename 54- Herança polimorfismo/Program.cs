using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54__Herança_polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro objCarro = new Carro();
            Bicicleta objBicicleta = new Bicicleta();

            objCarro.Andar();
            objBicicleta.Andar();

            Console.ReadKey();
        }
    }
}
