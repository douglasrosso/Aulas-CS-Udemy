using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61__Como_criar_a_sua_própria_exceção
{
    public class NumeroNegativoException : Exception
    {
        public NumeroNegativoException(int numero) : base($"Número {numero} não é positivo")
        {

        }
    }
}
