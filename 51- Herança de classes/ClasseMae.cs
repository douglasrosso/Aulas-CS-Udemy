using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _51__Herança_de_classes
{
    internal class ClasseMae
    {
        public string atributoDaMae = "Atributo da mãe";

        public string PropriedadeDaMae
        {
            get; 
            set;
        }

        public void MetodoDaClasseMae()
        {
            Console.WriteLine("Método da classe mãe");
        }

        public ClasseMae(string pPropriedadeDaMae)
        {
            PropriedadeDaMae = pPropriedadeDaMae;
        }
    }
}
