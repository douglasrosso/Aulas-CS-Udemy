using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53__Herança___classe_abstrata
{
    internal class Funcionario : Pessoa
    {
        private UInt32 salario;

        public UInt32 Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public void MostraSalario()
        {
            Console.WriteLine($"O salário do funcionário {Nome} é: {Salario}");
        }

        public Funcionario(string pNome, UInt32 pSalario) : base (pNome)
        {
            salario = pSalario;
        }

    }
}
