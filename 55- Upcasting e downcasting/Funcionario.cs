using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55__Upcasting_e_downcasting
{
    internal class Funcionario : Pessoa
    {
        private uint salario;

        public void ImprimeSalario()
        {
            Console.WriteLine($"O salário de {Nome} é {salario}");
        }

        public Funcionario(string pNome, uint pSalario ) : base (pNome)
        {
            salario = pSalario;
        }
    }
}
