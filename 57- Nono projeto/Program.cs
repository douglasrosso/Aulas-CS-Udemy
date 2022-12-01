using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57__Nono_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ALTERAÇÃO - novo parâmetro
            BaseDeDados baseDeDados = new BaseDeDados("BaseDeDados.xml");
            InterfaceGrafica meuPrograma = new InterfaceGrafica(baseDeDados);
            meuPrograma.IniciaInterface();
        }
    }
}
