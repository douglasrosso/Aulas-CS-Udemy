using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51__Herança_de_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClasseFilha objFilha = new ClasseFilha();
            objFilha.MetodoDaClasseFilha();
            objFilha.MetodoDaClasseMae();
            Console.WriteLine(objFilha.atributoDaMae);
            Console.WriteLine(objFilha.PropriedadeDaMae);
            Console.ReadKey();
        }
    }
}
