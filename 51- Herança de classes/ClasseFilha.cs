using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51__Herança_de_classes
{
    // Modificadores de acesso
    // public - todo mundo tem acesso (classes filhas e externamente)
    // private - somente a própria classe tem acesso (nem as filhas nem externamente conseguiremos acessar)
    // protected - somente poderá acessado pela classe filha e pela própria classe (externamente não poderá ser acessado)


    internal class ClasseFilha : ClasseMae
    {

        public string atributoDaFilha = "Atributo da filha";

        public string PropriedadeDaFilha
        {
            get;
            set;
        }
        public void MetodoDaClasseFilha()
        { 
            Console.WriteLine("Método da classe filha");
        }

        public ClasseFilha() : base("dagdxgvgvhgnsgxgxa")
        {
            PropriedadeDaFilha = "Propriedade da filha";
        }
    }
}
