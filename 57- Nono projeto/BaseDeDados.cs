using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace _57__Nono_projeto
{
    [DataContract]

    internal class BaseDeDados
    {
        // Atributo
        [DataMember]
        private List<CadastroPessoa> listaDePessoas;
        private string caminhoBaseDeDados;

        // Métodos
        public void AdicionarPessoa(CadastroPessoa pPessoa)
        {
            listaDePessoas.Add(pPessoa);
            Serializador.Serializa(caminhoBaseDeDados, this);
        }

        public List<CadastroPessoa> PesquisarPessoaPorDoc(string pNumeroDeDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x /* x que possua um numeroDoDocumento */ => x.NumeroDoDocumento == pNumeroDeDocumento /* Número do documento recebido */ ).ToList();
            if (listaDePessoasTemp.Count /* Número de elementos - Count */ > 0)
                return listaDePessoasTemp;
            else
                return null;
        }

        public List<CadastroPessoa> RemoverPessoaPorDoc(string pNumeroDoDocumento)
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
        public BaseDeDados (string pCaminhoBaseDeDados)
        {
            caminhoBaseDeDados = pCaminhoBaseDeDados;
            BaseDeDados baseDeDadosTemp = Serializador.Desserializa(caminhoBaseDeDados);
            if (baseDeDadosTemp != null)
                listaDePessoas = baseDeDadosTemp.listaDePessoas;
            else
                listaDePessoas = new List<CadastroPessoa>();
        }
    }
}
