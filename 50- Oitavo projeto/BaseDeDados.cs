using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50__Oitavo_projeto
{
    internal class BaseDeDados
    {
        // Atributo
        private List <CadastroPessoa> listaDePessoas;

        // Métodos
        public void AdicionarPessoa(CadastroPessoa pPessoa)
        {
            listaDePessoas.Add(pPessoa);
        }

        public List <CadastroPessoa> PesquisarPessoaPorDoc(string pNumeroDeDocumento)
        {
            List <CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x /* x que possua um numeroDoDocumento */ => x.NumeroDoDocumento == pNumeroDeDocumento /* Número do documento recebido */ ).ToList();
            if (listaDePessoasTemp.Count /* Número de elementos - Count */ > 0)
                return listaDePessoasTemp;
            else
                return null;
        }

        public List <CadastroPessoa> RemoverPessoaPorDoc(string pNumeroDoDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x /* x que possua um numeroDoDocumento */ => x.NumeroDoDocumento == pNumeroDoDocumento /* Número do documento recebido */ ).ToList();
            if (listaDePessoasTemp.Count /* Número de elementos - Count */ > 0)
            {
                foreach (CadastroPessoa pessoa in listaDePessoasTemp)
                {
                    listaDePessoas.Remove(pessoa);
                }
                return listaDePessoasTemp;
            }
            else
                return null;
        }

        // Construtor
        public BaseDeDados ()
        {
            listaDePessoas = new List<CadastroPessoa>();
        }
    }
}
